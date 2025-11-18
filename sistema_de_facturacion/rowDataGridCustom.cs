using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas
{
    internal class rowDataGridCustom: Panel
    {

        private Panel panelRow = new Panel();
        private Label labelNombreRecursos = new Label();
        private NumericUpDown numericUpDownCantidad = new NumericUpDown();
        private Label labelPrecio = new Label();
        private Label labelExistencias = new Label();
        private Label labelTotal = new Label();
        private int _id;
        private decimal _costo;
        public rowDataGridCustom(int id, string nombre, int existencias, decimal costo)
        {

            _id = id;
            _costo = costo;
            this.BackColor = Color.FromArgb(100, 100, 100);
            //this.Controls.Add();
            //this.Location = new Point(750, 270);  
            this.Name = "panelGridRecursos";
            this.Size = new Size(959, 98);
            this.Margin = new Padding(20);

            labelExistencias.AutoSize = true;
            labelExistencias.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelExistencias.ForeColor = SystemColors.Control;
            labelExistencias.Location = new Point(410, 29);
            labelExistencias.Name = "labelExistencias";
            labelExistencias.Size = new Size(215, 32);
            labelExistencias.TabIndex = 12;
            labelExistencias.Text = $"En existencias: {existencias}";
          
            labelTotal.AutoSize = true;
            labelTotal.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelTotal.ForeColor = SystemColors.Control;
            labelTotal.Location = new Point(193, 60);
            labelTotal.Name = "labelExistencias";
            //labelTotal.Size = new Size(215, 32);
            labelTotal.TabIndex = 12;
            labelTotal.Text = "Total: $0";

            // 
            // labelPrecio
            // 
            labelPrecio.AutoSize = true;
            labelPrecio.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPrecio.ForeColor = SystemColors.Control;
            labelPrecio.Location = new Point(193, 29);
            labelPrecio.Name = "labelPrecio";
            labelPrecio.Size = new Size(128, 32);
            labelPrecio.TabIndex = 11;
            labelPrecio.Text = $"Precio: ${costo}";
            // 
            // numericUpDownCantidad
            // 
            numericUpDownCantidad.Location = new Point(795, 27);
            numericUpDownCantidad.Name = "numericUpDownCantidad";
            numericUpDownCantidad.Size = new Size(124, 39);
            numericUpDownCantidad.Maximum = existencias;
            numericUpDownCantidad.TabIndex = 10;
            numericUpDownCantidad.ValueChanged += changeValueNumericUpdownCantidad;

            labelNombreRecursos.AutoSize = true;
            labelNombreRecursos.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelNombreRecursos.ForeColor = SystemColors.Control;
            labelNombreRecursos.Location = new Point(27, 29);
            labelNombreRecursos.Name = "labelNombreRecursos";
            labelNombreRecursos.Size = new Size(67, 32);
            labelNombreRecursos.TabIndex = 9;
            labelNombreRecursos.Text = $"{nombre}";



            // -----------------------------
            // AGREGAR AL PANEL
            // -----------------------------
            this.Controls.Add(labelNombreRecursos);
            this.Controls.Add(numericUpDownCantidad);
            this.Controls.Add(labelPrecio);
            this.Controls.Add(labelTotal);
            this.Controls.Add(labelExistencias);
        }

        public int GetId()
        {
            return _id;
        }

        public int GetCantidadReservados()
        {
            return Convert.ToInt32(numericUpDownCantidad.Value);
        }

        private void changeValueNumericUpdownCantidad(object sender, EventArgs e)
        {
            labelTotal.Text = $"Total: {_costo * GetCantidadReservados()}";
        }

    }
}
