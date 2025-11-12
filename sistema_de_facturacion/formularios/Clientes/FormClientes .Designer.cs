namespace sistema_de_reservas.formularios.Clientes
{
    partial class FormClientes
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
            button1 = new Button();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label6 = new Label();
            panel4 = new Panel();
            maskedTextBox1 = new MaskedTextBox();
            label2 = new Label();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            maskedTextBoxTelefono = new MaskedTextBox();
            label4 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(54, 52);
            panel1.Name = "panel1";
            panel1.Size = new Size(1522, 831);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
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
            button1.Location = new Point(246, 579);
            button1.Name = "button1";
            button1.Size = new Size(215, 101);
            button1.TabIndex = 11;
            button1.Text = "Guardar";
            button1.TextAlign = ContentAlignment.MiddleRight;
            button1.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(61, 60, 60);
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(759, 611);
            panel5.Name = "panel5";
            panel5.Size = new Size(600, 92);
            panel5.TabIndex = 10;
            panel5.Paint += panel5_Paint;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(61, 60, 60);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Cursor = Cursors.IBeam;
            textBox3.Font = new Font("Segoe UI", 13.875F);
            textBox3.ForeColor = Color.White;
            textBox3.Location = new Point(17, 41);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(550, 50);
            textBox3.TabIndex = 4;
            textBox3.TextChanged += textBox3_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = SystemColors.Control;
            label6.Location = new Point(17, 8);
            label6.Name = "label6";
            label6.Size = new Size(92, 32);
            label6.TabIndex = 3;
            label6.Text = "Correo";
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(61, 60, 60);
            panel4.Controls.Add(maskedTextBox1);
            panel4.Controls.Add(label2);
            panel4.Location = new Point(759, 273);
            panel4.Name = "panel4";
            panel4.Size = new Size(595, 92);
            panel4.TabIndex = 9;
            panel4.Paint += panel4_Paint;
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.BackColor = Color.FromArgb(61, 60, 60);
            maskedTextBox1.BorderStyle = BorderStyle.None;
            maskedTextBox1.Font = new Font("Segoe UI", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            maskedTextBox1.ForeColor = Color.White;
            maskedTextBox1.Location = new Point(20, 40);
            maskedTextBox1.Mask = "00000000-0";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(550, 50);
            maskedTextBox1.TabIndex = 4;
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(17, 6);
            label2.Name = "label2";
            label2.Size = new Size(57, 32);
            label2.TabIndex = 3;
            label2.Text = "DUI";
            label2.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(759, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 92);
            panel3.TabIndex = 8;
            panel3.Paint += panel3_Paint;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(61, 60, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 13.875F);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(25, 36);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(550, 50);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(17, 5);
            label1.Name = "label1";
            label1.Size = new Size(108, 32);
            label1.TabIndex = 2;
            label1.Text = "Nombre";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(maskedTextBoxTelefono);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(759, 437);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 92);
            panel2.TabIndex = 8;
            // 
            // maskedTextBoxTelefono
            // 
            maskedTextBoxTelefono.BackColor = Color.FromArgb(61, 60, 60);
            maskedTextBoxTelefono.BorderStyle = BorderStyle.None;
            maskedTextBoxTelefono.Font = new Font("Segoe UI", 13.875F);
            maskedTextBoxTelefono.ForeColor = Color.White;
            maskedTextBoxTelefono.Location = new Point(21, 33);
            maskedTextBoxTelefono.Mask = "0000-0000";
            maskedTextBoxTelefono.Name = "maskedTextBoxTelefono";
            maskedTextBoxTelefono.Size = new Size(502, 50);
            maskedTextBoxTelefono.TabIndex = 7;
            maskedTextBoxTelefono.MaskInputRejected += maskedTextBoxTelefono_MaskInputRejected;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.Control;
            label4.Location = new Point(15, 6);
            label4.Name = "label4";
            label4.Size = new Size(113, 32);
            label4.TabIndex = 5;
            label4.Text = "Telefono";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.man;
            pictureBox1.Location = new Point(207, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(306, 301);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormClientes
            // 
            StartPosition = FormStartPosition.CenterScreen;
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(1630, 937);
            Controls.Add(panel1);
            Name = "FormClientes";
            Text = "Agregar cliente";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private TextBox textBox1;
        private PictureBox pictureBox1;
        private MaskedTextBox maskedTextBoxTelefono;
        private Label label4;
        private Label label2;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox3;
        private Label label6;
        private MaskedTextBox maskedTextBox1;
        private Button button1;
    }
}