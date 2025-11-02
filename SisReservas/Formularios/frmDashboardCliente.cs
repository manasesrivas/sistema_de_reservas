using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SisReservas.Servicios;

namespace SisReservas.Formularios
{
    public partial class frmDashboardCliente : Form
    {
        private int idCliente;

        public frmDashboardCliente(int clienteId)
        {
            InitializeComponent();
            idCliente = clienteId;
            this.Load += new EventHandler(frmDashboardCliente_Load); // Asegura que el evento Load esté conectado
        }

        private void frmDashboardCliente_Load(object sender, EventArgs e)
        {
            cargarNombreCliente();
            cargarReservas();
        }

        private void cargarNombreCliente()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Nombre FROM Cliente WHERE Id_cliente = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idCliente);
                con.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string nombre = resultado.ToString();
                    lblBienvenida.Text = $"Bienvenido, {nombre}";
                }
                else
                {
                    lblBienvenida.Text = "Bienvenido, cliente";
                }
            }
        }

        private void cargarReservas()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"SELECT r.Id, s.Nombre AS Sala, r.FechaInicio, r.FechaFin, r.Tipo, r.Estado
                                 FROM Reservas r
                                 JOIN Salas s ON r.SalaId = s.Id_salas
                                 WHERE r.ClienteId = @id";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@id", idCliente);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservas.DataSource = dt;
            }
        }

        private void btnNuevaReserva_Click(object sender, EventArgs e)
        {
            frmReservarSala reservar = new frmReservarSala(idCliente);
            reservar.ShowDialog();
            cargarReservas(); // recarga después de reservar
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show("¿Estás seguro que querés salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirm == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
