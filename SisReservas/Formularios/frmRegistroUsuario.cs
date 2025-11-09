using SisReservas.Servicios;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SisReservas.Formularios
{
    public partial class frmRegistroUsuario : Form
    {
        public frmRegistroUsuario()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
        
            string claveOriginal = txtContraseña.Text.Trim();
            string claveHash = Seguridad.HashPassword(claveOriginal);

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO Usuario (Nombre, Correo, Password, Rol)
                                 VALUES (@nombre, @correo, @pass, @rol)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text.Trim());
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text.Trim());
                cmd.Parameters.AddWithValue("@pass", claveHash); 
                cmd.Parameters.AddWithValue("@rol", cbRol.SelectedItem.ToString());

                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado con éxito");
                this.Close();
            }
        }
    }
}
