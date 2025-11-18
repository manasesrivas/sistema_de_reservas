using System.Windows.Forms;

namespace sistema_de_reservas.formularios.Reservaciones
{
    partial class FormReservaciones
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            comboBoxEstadoReserva = new ComboBox();
            label5 = new Label();
            comboBoxClientes = new ComboBox();
            buttonGuardarReserva = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            comboBoxSala = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(comboBoxEstadoReserva);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(comboBoxClientes);
            panel1.Controls.Add(buttonGuardarReserva);
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxSala);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(label2);
            panel1.Location = new Point(54, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1907, 831);
            panel1.TabIndex = 0;
            // 
            // comboBoxEstadoReserva
            // 
            comboBoxEstadoReserva.Font = new Font("Segoe UI", 12F);
            comboBoxEstadoReserva.FormattingEnabled = true;
            comboBoxEstadoReserva.Items.AddRange(new object[] { "Concretada", "Cancelada", "Pendiente" });
            comboBoxEstadoReserva.Location = new Point(875, 94);
            comboBoxEstadoReserva.Name = "comboBoxEstadoReserva";
            comboBoxEstadoReserva.Size = new Size(540, 53);
            comboBoxEstadoReserva.TabIndex = 16;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(872, 39);
            label5.Name = "label5";
            label5.Size = new Size(243, 32);
            label5.TabIndex = 15;
            label5.Text = "Estado de la reserva";
            // 
            // comboBoxClientes
            // 
            comboBoxClientes.Font = new Font("Segoe UI", 12F);
            comboBoxClientes.FormattingEnabled = true;
            comboBoxClientes.Location = new Point(60, 84);
            comboBoxClientes.Name = "comboBoxClientes";
            comboBoxClientes.Size = new Size(590, 53);
            comboBoxClientes.TabIndex = 14;
            // 
            // buttonGuardarReserva
            // 
            buttonGuardarReserva.BackColor = Color.FromArgb(156, 108, 254);
            buttonGuardarReserva.FlatAppearance.BorderSize = 0;
            buttonGuardarReserva.FlatStyle = FlatStyle.Flat;
            buttonGuardarReserva.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonGuardarReserva.ForeColor = Color.White;
            buttonGuardarReserva.Image = Properties.Resources.save;
            buttonGuardarReserva.ImageAlign = ContentAlignment.MiddleLeft;
            buttonGuardarReserva.Location = new Point(300, 670);
            buttonGuardarReserva.Name = "buttonGuardarReserva";
            buttonGuardarReserva.Size = new Size(215, 101);
            buttonGuardarReserva.TabIndex = 13;
            buttonGuardarReserva.Text = "Guardar";
            buttonGuardarReserva.TextAlign = ContentAlignment.MiddleRight;
            buttonGuardarReserva.UseVisualStyleBackColor = false;
            buttonGuardarReserva.Click += button1_Click_1;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoScroll = true;
            tableLayoutPanel1.BackColor = Color.FromArgb(61, 60, 60);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Location = new Point(850, 310);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(1028, 483);
            tableLayoutPanel1.TabIndex = 12;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(51, 39);
            label4.Name = "label4";
            label4.Size = new Size(107, 32);
            label4.TabIndex = 9;
            label4.Text = "Cliente: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(850, 243);
            label3.Name = "label3";
            label3.Size = new Size(116, 32);
            label3.TabIndex = 8;
            label3.Text = "Recursos";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(84, 494);
            label1.Name = "label1";
            label1.Size = new Size(60, 32);
            label1.TabIndex = 7;
            label1.Text = "Sala";
            // 
            // comboBoxSala
            // 
            comboBoxSala.Font = new Font("Segoe UI", 12F);
            comboBoxSala.FormattingEnabled = true;
            comboBoxSala.Location = new Point(84, 539);
            comboBoxSala.Name = "comboBoxSala";
            comboBoxSala.Size = new Size(543, 53);
            comboBoxSala.TabIndex = 6;
            comboBoxSala.TextChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.BackColor = Color.FromArgb(61, 60, 60);
            dateTimePicker1.CalendarFont = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateTimePicker1.Location = new Point(84, 301);
            dateTimePicker1.MinDate = new DateTime(2025, 11, 14, 0, 0, 0, 0);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(615, 50);
            dateTimePicker1.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(84, 257);
            label2.Name = "label2";
            label2.Size = new Size(173, 32);
            label2.TabIndex = 3;
            label2.Text = "Dia reservado";
            // 
            // FormReservaciones
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(1973, 937);
            Controls.Add(panel1);
            Name = "FormReservaciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Crear reservacion";
            Load += FormReservaciones_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBoxSala;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private TableLayoutPanel tableLayoutPanel1;
        private Button buttonGuardarReserva;
        private ComboBox comboBoxClientes;
        private Label label5;
        private ComboBox comboBoxEstadoReserva;
    }

}