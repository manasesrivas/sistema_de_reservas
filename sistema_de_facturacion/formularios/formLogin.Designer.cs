namespace sistema_de_reservas
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            textBoxPassword = new TextBox();
            panel2 = new Panel();
            textBoxCorreo = new TextBox();
            label2 = new Label();
            buttonIniciarSesion = new Button();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(33, 33, 33);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(buttonIniciarSesion);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(33, 45);
            panel1.Margin = new Padding(2, 1, 2, 1);
            panel1.Name = "panel1";
            panel1.Size = new Size(405, 473);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBoxPassword);
            panel3.Location = new Point(39, 321);
            panel3.Margin = new Padding(2, 1, 2, 1);
            panel3.Name = "panel3";
            panel3.Size = new Size(323, 43);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(8, 3);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(80, 15);
            label3.TabIndex = 7;
            label3.Text = "Contraseña";
            label3.Click += label3_Click;
            // 
            // textBoxPassword
            // 
            textBoxPassword.BackColor = Color.FromArgb(61, 60, 60);
            textBoxPassword.BorderStyle = BorderStyle.None;
            textBoxPassword.Font = new Font("Segoe UI", 13.875F);
            textBoxPassword.ForeColor = SystemColors.Control;
            textBoxPassword.Location = new Point(8, 18);
            textBoxPassword.Margin = new Padding(2, 1, 2, 1);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(311, 25);
            textBoxPassword.TabIndex = 6;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(39, 248);
            panel2.Margin = new Padding(2, 1, 2, 1);
            panel2.Name = "panel2";
            panel2.Size = new Size(323, 43);
            panel2.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.FromArgb(61, 60, 60);
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 13.875F);
            textBoxCorreo.ForeColor = SystemColors.Control;
            textBoxCorreo.Location = new Point(6, 18);
            textBoxCorreo.Margin = new Padding(2, 1, 2, 1);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(311, 25);
            textBoxCorreo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(8, 2);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            label2.Click += label2_Click;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.FromArgb(156, 108, 254);
            buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            buttonIniciarSesion.FlatStyle = FlatStyle.Flat;
            buttonIniciarSesion.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIniciarSesion.ForeColor = Color.White;
            buttonIniciarSesion.Location = new Point(39, 394);
            buttonIniciarSesion.Margin = new Padding(2, 1, 2, 1);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(323, 37);
            buttonIniciarSesion.TabIndex = 7;
            buttonIniciarSesion.Text = "Iniciar Sesion";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(116, 71);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(162, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(76, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(247, 48);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(549, 536);
            Controls.Add(panel1);
            Margin = new Padding(2, 1, 2, 1);
            Name = "FormLogin";
            Padding = new Padding(2, 11, 2, 1);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
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
        private TextBox textBoxCorreo;
        private Label label2;
        private PictureBox pictureBox1;
        private Button buttonIniciarSesion;
        private Panel panel2;
        private Panel panel3;
        private Label label3;
        private TextBox textBoxPassword;
    }
}
