using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.ClasesDao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_reservas.formularios.Clientes
{
    public partial class FormClientes : Form
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void maskedTextBoxTelefono_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {
                string nombre = textBox1.Text.Trim();
                string correo = textBox3.Text.Trim();
                string dui = maskedTextBox1.Text.Trim();
                string telefono = maskedTextBoxTelefono.Text.Trim();

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(correo) ||
                    string.IsNullOrEmpty(dui) || string.IsNullOrEmpty(telefono))
                {
                    MessageBox.Show("Completa todos los campos correctamente.");
                    return;
                }

                Cliente cliente = new Cliente
                {
                    IdCliente = idCliente,
                    Nombre = nombre,
                    Correo = correo,
                    Dui = dui,
                    Telefono = telefono
                };

                ClienteDao dao = new ClienteDao();

                if (idCliente > 0)
                {
                    dao.Update(cliente);
                    MessageBox.Show("Cliente actualizado correctamente.");
                }
                else
                {
                    int nuevoId = dao.Insert(cliente);
                }

                this.Close();
            }
        }

        private int idCliente = 0;

        public FormClientes(int value) : this()
        {
            idCliente = value;
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            if (idCliente > 0)
            {
                ClienteDao dao = new ClienteDao();
                Cliente cliente = dao.GetById(idCliente);

                if (cliente != null)
                {
                    textBox1.Text = cliente.Nombre;
                    textBox3.Text = cliente.Correo;
                    maskedTextBox1.Text = cliente.Dui;
                    maskedTextBoxTelefono.Text = cliente.Telefono;
                    this.Text = $"Editar Cliente: {cliente.Nombre}";
                }
                else
                {
                    MessageBox.Show("No se encontró el cliente.");
                    this.Close();
                }
            }
            else
            {
                this.Text = "Registro de Cliente Nuevo";
            }
        }
    }
}
