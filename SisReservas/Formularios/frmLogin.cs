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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string correo = txtCorreo.Text.Trim();
            string claveIngresada = txtContraseña.Text.Trim();
            string claveHash = Seguridad.HashPassword(claveIngresada); // 🔐 Hashea la contraseña

            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                con.Open();

                // 🔍 Validación para Cliente
                string queryCliente = "SELECT Id_cliente FROM Cliente WHERE Correo=@correo AND Password=@pass";
                SqlCommand cmdCliente = new SqlCommand(queryCliente, con);
                cmdCliente.Parameters.AddWithValue("@correo", correo);
                cmdCliente.Parameters.AddWithValue("@pass", claveHash);
                var idCliente = cmdCliente.ExecuteScalar();

                if (idCliente != null)
                {
                    new frmDashboardCliente(Convert.ToInt32(idCliente)).Show();
                    this.Hide();
                    return;
                }

                // 🔍 Validación para Usuario
                string queryUsuario = "SELECT Id_usuario, Rol FROM Usuario WHERE Correo=@correo AND Password=@pass";
                SqlCommand cmdUsuario = new SqlCommand(queryUsuario, con);
                cmdUsuario.Parameters.AddWithValue("@correo", correo);
                cmdUsuario.Parameters.AddWithValue("@pass", claveHash);
                SqlDataReader reader = cmdUsuario.ExecuteReader();

                if (reader.Read())
                {
                    int idUsuario = reader.GetInt32(0);
                    string rol = reader.GetString(1);

                    if (rol == "Administrador")
                        new frmDashboardAdmin(idUsuario).Show();
                    else if (rol == "Recepcionista")
                        new frmDashboardRecepcionista(idUsuario).Show();

                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Credenciales incorrectas");
                }
            }
        }


        private void linkRegistroCliente_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmRegistroCliente registro = new frmRegistroCliente();
            registro.Show();
            this.Hide(); 
        }

      
    }
}
