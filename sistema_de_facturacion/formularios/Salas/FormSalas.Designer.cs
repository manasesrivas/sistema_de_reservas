namespace sistema_de_reservas.formularios.Salas
{
    partial class FormSalas
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
            btnGuardarSala = new Button();
            panel1 = new Panel();
            panel5 = new Panel();
            cbDisponible = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            numCapacidad = new NumericUpDown();
            btnCancelar = new Button();
            panel3 = new Panel();
            numericUpDownPrecio = new NumericUpDown();
            label1 = new Label();
            panel2 = new Panel();
            label2 = new Label();
            txtNombreSala = new TextBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarSala
            // 
            btnGuardarSala.Location = new Point(540, 659);
            btnGuardarSala.Margin = new Padding(6);
            btnGuardarSala.Name = "btnGuardarSala";
            btnGuardarSala.Size = new Size(199, 73);
            btnGuardarSala.TabIndex = 0;
            btnGuardarSala.Text = "Guardar";
            btnGuardarSala.TextAlign = ContentAlignment.MiddleRight;
            btnGuardarSala.UseVisualStyleBackColor = true;
            btnGuardarSala.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGuardarSala);
            panel1.Location = new Point(22, 26);
            panel1.Margin = new Padding(6);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 866);
            panel1.TabIndex = 1;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(61, 60, 60);
            panel5.Controls.Add(cbDisponible);
            panel5.Controls.Add(label5);
            panel5.Location = new Point(260, 490);
            panel5.Margin = new Padding(6);
            panel5.Name = "panel5";
            panel5.Size = new Size(399, 102);
            panel5.TabIndex = 4;
            // 
            // cbDisponible
            // 
            cbDisponible.FormattingEnabled = true;
            cbDisponible.Items.AddRange(new object[] { "Si", "No" });
            cbDisponible.Location = new Point(24, 52);
            cbDisponible.Name = "cbDisponible";
            cbDisponible.Size = new Size(344, 40);
            cbDisponible.TabIndex = 3;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(4, 0);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(139, 29);
            label5.TabIndex = 2;
            label5.Text = "Disponible";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(201, 28);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(538, 79);
            label4.TabIndex = 7;
            label4.Text = "AGREGAR SALA";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(61, 60, 60);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numCapacidad);
            panel4.Location = new Point(481, 356);
            panel4.Margin = new Padding(6);
            panel4.Name = "panel4";
            panel4.Size = new Size(399, 102);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(4, 0);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(138, 29);
            label3.TabIndex = 2;
            label3.Text = "Capacidad";
            // 
            // numCapacidad
            // 
            numCapacidad.BackColor = Color.FromArgb(61, 60, 60);
            numCapacidad.ForeColor = SystemColors.Window;
            numCapacidad.Location = new Point(6, 47);
            numCapacidad.Margin = new Padding(6);
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(388, 39);
            numCapacidad.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(152, 659);
            btnCancelar.Margin = new Padding(6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(199, 73);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(numericUpDownPrecio);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(32, 356);
            panel3.Margin = new Padding(6);
            panel3.Name = "panel3";
            panel3.Size = new Size(399, 102);
            panel3.TabIndex = 3;
            // 
            // numericUpDownPrecio
            // 
            numericUpDownPrecio.Location = new Point(16, 47);
            numericUpDownPrecio.Name = "numericUpDownPrecio";
            numericUpDownPrecio.Size = new Size(240, 39);
            numericUpDownPrecio.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(4, 0);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 29);
            label1.TabIndex = 2;
            label1.Text = "Precio";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNombreSala);
            panel2.Location = new Point(254, 207);
            panel2.Margin = new Padding(6);
            panel2.Name = "panel2";
            panel2.Size = new Size(399, 102);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(4, 0);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(146, 29);
            label2.TabIndex = 2;
            label2.Text = "Nueva Sala";
            // 
            // txtNombreSala
            // 
            txtNombreSala.BackColor = Color.FromArgb(61, 60, 60);
            txtNombreSala.ForeColor = SystemColors.Window;
            txtNombreSala.Location = new Point(6, 47);
            txtNombreSala.Margin = new Padding(6);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(385, 39);
            txtNombreSala.TabIndex = 0;
            // 
            // FormSalas
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(958, 907);
            Controls.Add(panel1);
            Margin = new Padding(6);
            Name = "FormSalas";
            Text = "FormSalas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownPrecio).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnGuardarSala;
        private Panel panel1;
        private TextBox txtNombreSala;
        private Panel panel2;
        private Label label2;
        private Panel panel3;
        private Label label1;
        private NumericUpDown numCapacidad;
        private Button btnCancelar;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private NumericUpDown numericUpDownPrecio;
        private Panel panel5;
        private ComboBox cbDisponible;
        private Label label5;
    }
}