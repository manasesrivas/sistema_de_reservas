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


namespace sistema_de_reservas.formularios.Reservaciones
{
    public partial class FormReservaciones : Form
    {
        private int _id;
        private RecursoDao recursoDao = new RecursoDao();
        private SalasDao salasDao = new SalasDao();
        private ClienteDao clienteDao = new ClienteDao();
        private ReservaDao reservaDao = new ReservaDao();
        //private 
        public FormReservaciones()
        {
            InitializeComponent();
            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker1.MaxDate = DateTime.Today.AddYears(1);   // Máximo: un año desde hoy
        }

        private void FormReservaciones_Load(object sender, EventArgs e)
        {



            foreach (var item in clienteDao.GetAll())
            {
                comboBoxClientes.Items.Add(item);
            }
            foreach (var sala in salasDao.GetAll())
            {
                comboBoxSala.Items.Add(sala);
            }


            var recursos = recursoDao.GetAll();

            tableLayoutPanel1.SuspendLayout();

            tableLayoutPanel1.RowCount = recursos.Count;
            tableLayoutPanel1.RowStyles.Clear();

            int fila = 0;
            foreach (var recurso in recursos)
            {
                tableLayoutPanel1.Controls.Add(new rowDataGridCustom(recurso.IdRecurso, recurso.Nombre, recurso.Cantidad, recurso.Costo), 0, fila);
                fila++;
            }

            tableLayoutPanel1.ResumeLayout();


        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Guardar la posición del cursor
            return;
            string texto = comboBoxSala.Text;
            int pos = comboBoxSala.SelectionStart;

            // Filtrar lista
            var filtrados = salasDao.GetAll()
                .Where(x => x.Nombre.Contains(texto, StringComparison.OrdinalIgnoreCase))
                .ToList();
            comboBoxSala.Items.Clear();
            comboBoxSala.SelectedIndex = -1;
            foreach (var sala in filtrados)
            {
                comboBoxSala.Items.Add(sala);
            }

            // Volver a mostrar sugerencias

            // Restaurar el texto y la posición del cursor
            comboBoxSala.Text = texto;
            comboBoxSala.SelectionStart = pos;
            comboBoxSala.DroppedDown = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        // guardar reserva
        private void button1_Click_1(object sender, EventArgs e)
        {

            if (
                comboBoxClientes.SelectedIndex == -1 ||
                comboBoxEstadoReserva.SelectedIndex == -1 ||
                comboBoxSala.SelectedIndex == -1
    )
            {
                MessageBox.Show("Porfavor No dejes campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Sala salaselect = (Sala)comboBoxSala.SelectedItem;
            Cliente clienteselect = (Cliente)comboBoxSala.SelectedItem;

            var reserva = new Reserva()
            {
                ClienteId  = clienteselect.IdCliente,
                SalaId = salaselect.IdSalas,
                FechaReservado = dateTimePicker1.Value,
                Estado = comboBoxEstadoReserva.Text
            };
            try
            {
                var id_reserva = reservaDao.Insert(reserva);

                if (id_reserva > 0)
                {
                    MessageBox.Show(
                        "registro ingresado con exito",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "registro ingresado sin exito",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error inesperado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            foreach (var row in tableLayoutPanel1.Controls.OfType<rowDataGridCustom>())
            {

                if (row.GetCantidadReservados() > 0) { 
                    MessageBox.Show($"recurso con id {row.GetId()} con cantidad de productos prestados {row.GetCantidadReservados()}");

                }

            }

            MessageBox.Show("porfavor ingresa la cantidad de recursos que recursos");
        }
    }
}
