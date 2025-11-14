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
            label4 = new Label();
            panel4 = new Panel();
            label3 = new Label();
            numCapacidad = new NumericUpDown();
            btnCancelar = new Button();
            panel3 = new Panel();
            label1 = new Label();
            cbDisponible = new ComboBox();
            panel2 = new Panel();
            label2 = new Label();
            txtNombreSala = new TextBox();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).BeginInit();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // btnGuardarSala
            // 
            btnGuardarSala.Location = new Point(291, 309);
            btnGuardarSala.Name = "btnGuardarSala";
            btnGuardarSala.Size = new Size(107, 34);
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
            panel1.Controls.Add(label4);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(btnCancelar);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(btnGuardarSala);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(493, 406);
            panel1.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Courier New", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(108, 13);
            label4.Name = "label4";
            label4.Size = new Size(269, 40);
            label4.TabIndex = 7;
            label4.Text = "AGREGAR SALA";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(61, 60, 60);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numCapacidad);
            panel4.Location = new Point(259, 167);
            panel4.Name = "panel4";
            panel4.Size = new Size(215, 48);
            panel4.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(2, 0);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 2;
            label3.Text = "Capacidad";
            // 
            // numCapacidad
            // 
            numCapacidad.BackColor = Color.FromArgb(61, 60, 60);
            numCapacidad.ForeColor = SystemColors.Window;
            numCapacidad.Location = new Point(3, 22);
            numCapacidad.Name = "numCapacidad";
            numCapacidad.Size = new Size(209, 23);
            numCapacidad.TabIndex = 5;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(82, 309);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(107, 34);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextAlign = ContentAlignment.MiddleRight;
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(cbDisponible);
            panel3.Location = new Point(17, 167);
            panel3.Name = "panel3";
            panel3.Size = new Size(215, 48);
            panel3.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(2, 0);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 2;
            label1.Text = "Disponible";
            // 
            // cbDisponible
            // 
            cbDisponible.BackColor = Color.FromArgb(61, 60, 60);
            cbDisponible.DropDownStyle = ComboBoxStyle.DropDownList;
            cbDisponible.ForeColor = SystemColors.Window;
            cbDisponible.FormattingEnabled = true;
            cbDisponible.Items.AddRange(new object[] { "Sí", "No" });
            cbDisponible.Location = new Point(3, 22);
            cbDisponible.Name = "cbDisponible";
            cbDisponible.Size = new Size(209, 23);
            cbDisponible.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(txtNombreSala);
            panel2.Location = new Point(137, 97);
            panel2.Name = "panel2";
            panel2.Size = new Size(215, 48);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(2, 0);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 15);
            label2.TabIndex = 2;
            label2.Text = "Nueva Sala";
            // 
            // txtNombreSala
            // 
            txtNombreSala.BackColor = Color.FromArgb(61, 60, 60);
            txtNombreSala.ForeColor = SystemColors.Window;
            txtNombreSala.Location = new Point(3, 22);
            txtNombreSala.Name = "txtNombreSala";
            txtNombreSala.Size = new Size(209, 23);
            txtNombreSala.TabIndex = 0;
            // 
            // FormSalas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(516, 425);
            Controls.Add(panel1);
            Name = "FormSalas";
            Text = "FormSalas";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numCapacidad).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
        private ComboBox cbDisponible;
        private Panel panel3;
        private Label label1;
        private NumericUpDown numCapacidad;
        private Button btnCancelar;
        private Panel panel4;
        private Label label3;
        private Label label4;
    }
}