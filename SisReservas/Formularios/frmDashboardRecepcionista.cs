using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SisReservas.Servicios;

namespace SisReservas.Formularios
{
    public partial class frmDashboardRecepcionista : Form
    {
        private int idUsuario;

        public frmDashboardRecepcionista(int usuarioId)
        {
            InitializeComponent();
            idUsuario = usuarioId;
        }

        private void frmDashboardRecepcionista_Load(object sender, EventArgs e)
        {
            cargarNombreRecepcionista();
            cargarTodasLasReservas();
        }

        private void cargarNombreRecepcionista()
        {
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = "SELECT Nombre FROM Usuario WHERE Id_usuario = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idUsuario);
                con.Open();
                string nombre = cmd.ExecuteScalar()?.ToString();
                lblRecepcionista.Text = "Panel de Recepcionista: " + nombre;
            }
        }

        private void cargarTodasLasReservas()
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
                dgvTodasReservas.DataSource = dt;
            }
        }

        private void btnActualizarEstado_Click(object sender, EventArgs e)
        {
            cargarTodasLasReservas();
        }
    }
}
