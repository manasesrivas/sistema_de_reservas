using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using SisReservas.Servicios;

namespace SisReservas.Formularios
{
    public partial class frmRegistroCliente : Form
    {
        public frmRegistroCliente()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                string.IsNullOrWhiteSpace(txtCorreo.Text) ||
                string.IsNullOrWhiteSpace(txtContraseña.Text) ||
                string.IsNullOrWhiteSpace(txtDui.Text))
            {
                MessageBox.Show("Por favor, completá todos los campos.");
                return;
            }

            try
            {
                using (SqlConnection con = new SqlConnection(Conexion.cadena))
                {
                    string query = @"INSERT INTO Cliente (Nombre, Correo, Contraseña, Dui)
                                     VALUES (@nombre, @correo, @pass, @dui)";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@pass", txtContraseña.Text.Trim());
                    cmd.Parameters.AddWithValue("@dui", txtDui.Text.Trim());

                    con.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Cliente registrado con éxito.");

                    // Volver al login
                    frmLogin login = new frmLogin();
                    login.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }
    }
}
