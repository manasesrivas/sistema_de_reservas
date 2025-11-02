using SisReservas.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"INSERT INTO Usuario (Nombre, Correo, Contraseña, Rol)
                         VALUES (@nombre, @correo, @pass, @rol)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@nombre", txtNombre.Text);
                cmd.Parameters.AddWithValue("@correo", txtCorreo.Text);
                cmd.Parameters.AddWithValue("@pass", txtContraseña.Text);
                cmd.Parameters.AddWithValue("@rol", cbRol.SelectedItem.ToString());
                con.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Usuario registrado con éxito");
                this.Close();
            }
        }

    }
}
