namespace sistema_de_reservas.formularios.Recursos
{
    partial class FormRecursos
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
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            numericUpDownCantidadDisponible = new NumericUpDown();
            button1 = new Button();
            panel3 = new Panel();
            label4 = new Label();
            label3 = new Label();
            numericUpDownCosto = new NumericUpDown();
            label1 = new Label();
            comboBoxTipo = new ComboBox();
            panel2 = new Panel();
            textBoxNombreRecurso = new TextBox();
            label2 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadDisponible).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBoxTipo);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(54, 38);
            panel1.Name = "panel1";
            panel1.Size = new Size(767, 742);
            panel1.TabIndex = 0;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(61, 60, 60);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(numericUpDownCantidadDisponible);
            panel4.Location = new Point(48, 604);
            panel4.Name = "panel4";
            panel4.Size = new Size(361, 103);
            panel4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Control;
            label5.Location = new Point(15, 38);
            label5.Name = "label5";
            label5.Size = new Size(0, 42);
            label5.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(15, 5);
            label6.Name = "label6";
            label6.Size = new Size(247, 29);
            label6.TabIndex = 1;
            label6.Text = "Cantidad disponible";
            // 
            // numericUpDownCantidadDisponible
            // 
            numericUpDownCantidadDisponible.BackColor = Color.FromArgb(61, 60, 60);
            numericUpDownCantidadDisponible.BorderStyle = BorderStyle.None;
            numericUpDownCantidadDisponible.Font = new Font("Segoe UI", 13.875F);
            numericUpDownCantidadDisponible.ForeColor = Color.White;
            numericUpDownCantidadDisponible.Location = new Point(21, 35);
            numericUpDownCantidadDisponible.Name = "numericUpDownCantidadDisponible";
            numericUpDownCantidadDisponible.Size = new Size(286, 53);
            numericUpDownCantidadDisponible.TabIndex = 12;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 108, 254);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Image = Properties.Resources.save;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.Location = new Point(503, 606);
            button1.Name = "button1";
            button1.Size = new Size(215, 101);
            button1.TabIndex = 12;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(numericUpDownCosto);
            panel3.Location = new Point(48, 463);
            panel3.Name = "panel3";
            panel3.Size = new Size(361, 103);
            panel3.TabIndex = 10;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(15, 38);
            label4.Name = "label4";
            label4.Size = new Size(40, 42);
            label4.TabIndex = 13;
            label4.Text = "$";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 5);
            label3.Name = "label3";
            label3.Size = new Size(246, 29);
            label3.TabIndex = 1;
            label3.Text = "Nombre del recurso";
            // 
            // numericUpDownCosto
            // 
            numericUpDownCosto.BackColor = Color.FromArgb(61, 60, 60);
            numericUpDownCosto.BorderStyle = BorderStyle.None;
            numericUpDownCosto.Font = new Font("Segoe UI", 13.875F);
            numericUpDownCosto.ForeColor = Color.White;
            numericUpDownCosto.Location = new Point(56, 34);
            numericUpDownCosto.Name = "numericUpDownCosto";
            numericUpDownCosto.Size = new Size(286, 53);
            numericUpDownCosto.TabIndex = 12;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(48, 317);
            label1.Name = "label1";
            label1.Size = new Size(199, 29);
            label1.TabIndex = 11;
            label1.Text = "Tipo de recurso";
            // 
            // comboBoxTipo
            // 
            comboBoxTipo.Font = new Font("Segoe UI", 13.875F);
            comboBoxTipo.FormattingEnabled = true;
            comboBoxTipo.Items.AddRange(new object[] { "equipamiento", "inmoviliario", "alimentos y bebidas", "ambientacion", "digital o tecnologico" });
            comboBoxTipo.Location = new Point(48, 358);
            comboBoxTipo.Name = "comboBoxTipo";
            comboBoxTipo.Size = new Size(600, 58);
            comboBoxTipo.TabIndex = 10;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(textBoxNombreRecurso);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(48, 121);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 92);
            panel2.TabIndex = 9;
            // 
            // textBoxNombreRecurso
            // 
            textBoxNombreRecurso.BackColor = Color.FromArgb(61, 60, 60);
            textBoxNombreRecurso.BorderStyle = BorderStyle.None;
            textBoxNombreRecurso.Font = new Font("Segoe UI", 13.875F);
            textBoxNombreRecurso.ForeColor = SystemColors.Control;
            textBoxNombreRecurso.Location = new Point(11, 38);
            textBoxNombreRecurso.Name = "textBoxNombreRecurso";
            textBoxNombreRecurso.Size = new Size(578, 50);
            textBoxNombreRecurso.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 5);
            label2.Name = "label2";
            label2.Size = new Size(246, 29);
            label2.TabIndex = 1;
            label2.Text = "Nombre del recurso";
            // 
            // FormRecursos
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(856, 814);
            Controls.Add(panel1);
            Name = "FormRecursos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "formulario recursos";
            Load += FormRecursos_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCantidadDisponible).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCosto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxNombreRecurso;
        private Label label2;
        private NumericUpDown numericUpDownCosto;
        private Label label1;
        private ComboBox comboBoxTipo;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private Button button1;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private NumericUpDown numericUpDownCantidadDisponible;
    }
}