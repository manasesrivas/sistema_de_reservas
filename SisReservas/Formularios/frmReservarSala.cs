using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SisReservas.Servicios;
using SisReservas.Modelos;

namespace SisReservas.Formularios
{
    public partial class frmReservarSala : Form
    {
        private int idCliente;

        public frmReservarSala(int clienteId)
        {
            InitializeComponent();
            idCliente = clienteId;
            this.Load += new EventHandler(frmReservarSala_Load); // Asegura que el evento Load se conecte
        }

        private void frmReservarSala_Load(object sender, EventArgs e)
        {
            cargarSalas();
            cargarRecursos();
            cargarTipos();
        }

        private void cargarSalas()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_salas, Nombre FROM Salas WHERE Disponible = 1";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cbSala.DataSource = dt;
                cbSala.DisplayMember = "Nombre";
                cbSala.ValueMember = "Id_salas";
            }
        }

        private void cargarTipos()
        {
            cbTipo.Items.Clear();
            cbTipo.Items.Add("Karaoke");
            cbTipo.Items.Add("Cita");
            cbTipo.Items.Add("Evento");
            cbTipo.SelectedIndex = 0;
        }

        private void cargarRecursos()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_recursos, Nombre, Tipo, Costo FROM Recursos";
                SqlCommand cmd = new SqlCommand(query, con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    Recurso r = new Recurso
                    {
                        Id_recursos = reader.GetInt32(0),
                        Nombre = reader.GetString(1),
                        Tipo = reader.GetString(2),
                        Costo = reader.GetDecimal(3)
                    };
                    clbRecursos.Items.Add(r);
                }
            }
        }

        private void btnReservar_Click(object sender, EventArgs e)
        {
            if (cbSala.SelectedIndex == -1 || cbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Seleccioná una sala y tipo de reserva.");
                return;
            }

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();
                SqlTransaction trans = con.BeginTransaction();

                try
                {
                    string insertReserva = @"INSERT INTO Reservas (SalaId, ClienteId, FechaInicio, FechaFin, Tipo, Estado)
                                             VALUES (@sala, @cliente, @inicio, @fin, @tipo, 'Confirmada');
                                             SELECT SCOPE_IDENTITY();";
                    SqlCommand cmd = new SqlCommand(insertReserva, con, trans);
                    cmd.Parameters.AddWithValue("@sala", cbSala.SelectedValue);
                    cmd.Parameters.AddWithValue("@cliente", idCliente);
                    cmd.Parameters.AddWithValue("@inicio", dtInicio.Value);
                    cmd.Parameters.AddWithValue("@fin", dtFin.Value);
                    cmd.Parameters.AddWithValue("@tipo", cbTipo.SelectedItem.ToString());
                    int reservaId = Convert.ToInt32(cmd.ExecuteScalar());

                    foreach (var item in clbRecursos.CheckedItems)
                    {
                        Recurso recurso = (Recurso)item;
                        SqlCommand cmdRecurso = new SqlCommand("INSERT INTO ReservaRecurso (ReservaId, RecursoId) VALUES (@reserva, @recurso)", con, trans);
                        cmdRecurso.Parameters.AddWithValue("@reserva", reservaId);
                        cmdRecurso.Parameters.AddWithValue("@recurso", recurso.Id_recursos);
                        cmdRecurso.ExecuteNonQuery();
                    }

                    trans.Commit();
                    MessageBox.Show("Reserva registrada con éxito.");
                    this.Close();
                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show("Error al registrar la reserva: " + ex.Message);
                }
            }
        }
    }
}
