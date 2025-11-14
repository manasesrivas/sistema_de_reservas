
using Microsoft.Data.SqlClient;
using sistema_de_facturacion.servicios;
using sistema_de_reservas.formularios;
using sistema_de_reservas.Servicios;
using System.Configuration;
using System.Data;

namespace sistema_de_reservas
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            string correo = textBoxCorreo.Text.Trim();
            string claveIngresada = textBoxPassword.Text.Trim();
            string claveHash = seguridad.HashPassword(claveIngresada); // Hashea la contrasena
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString))
            {
                con.Open();

                // Validación para Cliente
                string queryCliente = "SELECT Id_usuario FROM Usuarios WHERE Correo=@correo AND Password=@pass";
                SqlCommand cmdCliente = new SqlCommand(queryCliente, con);
                cmdCliente.Parameters.AddWithValue("@correo", correo);
                cmdCliente.Parameters.AddWithValue("@pass", claveHash);
                var idCliente = cmdCliente.ExecuteScalar();
            

                string queryUsuario = "SELECT Id_usuario, Rol FROM Usuarios WHERE Correo=@correo AND Password=@pass";
                SqlCommand cmdUsuario = new SqlCommand(queryUsuario, con);
                cmdUsuario.Parameters.AddWithValue("@correo", correo);
                cmdUsuario.Parameters.AddWithValue("@pass", claveHash);
                SqlDataReader reader = cmdUsuario.ExecuteReader();

                if (reader.Read())
                {
                    int idUsuario = reader.GetInt32(0);
                    string rol = reader.GetString(1);

                    if (rol == "Administrador")
                        new FormDashboardAdmin(idUsuario).Show();
                    //else if (rol == "Recepcionista")
                    //    new frmDashboardRecepcionista(idUsuario).Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}