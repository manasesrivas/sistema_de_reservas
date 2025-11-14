using System;
using System.Drawing;
using System.Windows.Forms;
using sistema_de_reservas.Core.Dao.ClasesDao;
using sistema_de_reservas.Core.Clases;

namespace sistema_de_reservas.formularios.Salas
{
    public partial class FormSalas : Form
    {
        private int value;

        public FormSalas()
        {
            InitializeComponent();
        }

        public FormSalas(int value)
        {
            InitializeComponent();
            this.value = value;
        }

        private void FormSalas_Load(object sender, EventArgs e)
        {
            cbDisponible.Items.Clear();
            cbDisponible.Items.Add("Sí");
            cbDisponible.Items.Add("No");
            cbDisponible.SelectedIndex = 0;

            btnGuardarSala.BackColor = Color.SeaGreen;
            btnGuardarSala.ForeColor = Color.White;
            btnGuardarSala.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            btnCancelar.BackColor = Color.Firebrick;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Font = new Font("Segoe UI", 10, FontStyle.Bold);

            if (value > 0)
            {
                SalasDao dao = new SalasDao();
                Sala sala = dao.GetById(value);

                if (sala != null)
                {
                    txtNombreSala.Text = sala.Nombre;
                    numCapacidad.Value = sala.Capacidad;
                    cbDisponible.SelectedItem = sala.Disponible == 1 ? "Sí" : "No";
                    this.Text = $"Editar Sala: {sala.Nombre}";
                }
                else
                {
                    MessageBox.Show("No se encontró la sala.");
                    this.Close();
                }
            }
            else
            {
                this.Text = "Registro de Sala Nueva";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreSala.Text.Trim();
            int capacidad = (int)numCapacidad.Value;
            bool disponibleBool = cbDisponible.SelectedItem?.ToString() == "Sí";

            if (string.IsNullOrEmpty(nombre) || capacidad <= 0)
            {
                MessageBox.Show("Completa todos los campos correctamente.");
                return;
            }

            Sala sala = new Sala
            {
                IdSalas = value,
                Nombre = nombre,
                Capacidad = capacidad,
                Disponible = disponibleBool ? 1 : 0
            };

            SalasDao salas = new SalasDao();

            if (value > 0)
            {
                salas.Update(sala);
                MessageBox.Show("Sala actualizada correctamente.");
            }
            else
            {
                int idGenerado = salas.Insert(sala);
            }

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
