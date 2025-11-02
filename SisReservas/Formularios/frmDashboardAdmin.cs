using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SisReservas.Servicios;

namespace SisReservas.Formularios
{
    public partial class frmDashboardAdmin : Form
    {
        private int idAdmin;

        public frmDashboardAdmin(int adminId)
        {
            InitializeComponent();
            idAdmin = adminId;
            this.Load += new EventHandler(frmDashboardAdmin_Load); // Asegura que el evento Load esté conectado
        }

        private void frmDashboardAdmin_Load(object sender, EventArgs e)
        {
            cargarNombreAdmin();
            cargarUsuarios();
            cargarSalas();
            cargarRecursos();
            cargarReservas();
            cargarClientes();
            cargarEstadosReserva();


            // Verificación visual rápida
            MessageBox.Show("Dashboard cargado correctamente.");
        }

        private void cargarNombreAdmin()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Nombre FROM Usuario WHERE Id_usuario = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idAdmin);
                con.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string nombre = resultado.ToString();
                    lblAdmin.Text = $"Panel de Administrador: {nombre}";
                }
                else
                {
                    lblAdmin.Text = "Panel de Administrador: (sin nombre)";
                }
            }
        }

        private void cargarClientes()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_cliente, Nombre, Correo, Dui FROM Cliente";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvClientes.DataSource = dt;
            }
        }

        private void cargarUsuarios()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_usuario, Nombre, Correo, Rol FROM Usuario";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvUsuarios.DataSource = dt;
            }
        }

        private void cargarSalas()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_salas, Nombre, Capacidad, Disponible FROM Salas";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvSalas.DataSource = dt;
            }
        }

        private void cargarRecursos()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Id_recursos, Nombre, Tipo, Costo FROM Recursos";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvRecursos.DataSource = dt;
            }
        }

        private void cargarReservas()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"SELECT r.Id, c.Nombre AS Cliente, s.Nombre AS Sala, 
                                        r.FechaInicio, r.FechaFin, r.Tipo, r.Estado
                                 FROM Reservas r
                                 JOIN Cliente c ON r.ClienteId = c.Id_cliente
                                 JOIN Salas s ON r.SalaId = s.Id_salas";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservas.DataSource = dt;
            }
        }

        private void cargarEstadosReserva()
        {
            cbEstadoReserva.Items.Clear();
            cbEstadoReserva.Items.Add("Confirmada");
            cbEstadoReserva.Items.Add("Cancelada");
            cbEstadoReserva.Items.Add("Terminada");
            cbEstadoReserva.SelectedIndex = 0;
        }



        private void btnRegistrarUsuario_Click_1(object sender, EventArgs e)
        {
            frmRegistroUsuario registro = new frmRegistroUsuario();
            registro.ShowDialog(); // Abre el formulario como ventana modal

            cargarUsuarios();
        }

        private void btnCambiarEstado_Click(object sender, EventArgs e)
        {
            if (dgvReservas.SelectedRows.Count > 0)
            {
                int reservaId = Convert.ToInt32(dgvReservas.SelectedRows[0].Cells["Id"].Value);
                string nuevoEstado = cbEstadoReserva.SelectedItem.ToString();

                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    string query = "UPDATE Reservas SET Estado = @estado WHERE Id = @id";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@estado", nuevoEstado);
                    cmd.Parameters.AddWithValue("@id", reservaId);
                    con.Open();
                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Estado actualizado correctamente.");
                cargarReservas(); // recarga la tabla
            }
            else
            {
                MessageBox.Show("Seleccioná una reserva primero.");
            }
        }

        private void btnBuscarReserva_Click(object sender, EventArgs e)
        {
            string filtro = txtBuscarReserva.Text.Trim();

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"SELECT r.Id, c.Nombre AS Cliente, s.Nombre AS Sala, 
                                r.FechaInicio, r.FechaFin, r.Tipo, r.Estado
                         FROM Reservas r
                         JOIN Cliente c ON r.ClienteId = c.Id_cliente
                         JOIN Salas s ON r.SalaId = s.Id_salas
                         WHERE c.Nombre LIKE @filtro OR r.Tipo LIKE @filtro";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                da.SelectCommand.Parameters.AddWithValue("@filtro", "%" + filtro + "%");
                DataTable dt = new DataTable();
                da.Fill(dt);
                dgvReservas.DataSource = dt;
            }
        }

       
    }
}
