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
            buttonIniciarSesion = new Button();
            pictureBox1 = new PictureBox();
            textBoxCorreo = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            label3 = new Label();
            textBoxPassword = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
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
            panel1.Location = new Point(62, 96);
            panel1.Name = "panel1";
            panel1.Size = new Size(752, 1010);
            panel1.TabIndex = 0;
            // 
            // buttonIniciarSesion
            // 
            buttonIniciarSesion.BackColor = Color.FromArgb(156, 108, 254);
            buttonIniciarSesion.FlatAppearance.BorderSize = 0;
            buttonIniciarSesion.FlatStyle = FlatStyle.Flat;
            buttonIniciarSesion.Font = new Font("Segoe UI Semibold", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonIniciarSesion.ForeColor = Color.White;
            buttonIniciarSesion.Location = new Point(72, 841);
            buttonIniciarSesion.Name = "buttonIniciarSesion";
            buttonIniciarSesion.Size = new Size(600, 79);
            buttonIniciarSesion.TabIndex = 7;
            buttonIniciarSesion.Text = "Iniciar Sesion";
            buttonIniciarSesion.UseVisualStyleBackColor = false;
            buttonIniciarSesion.Click += buttonIniciarSesion_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.user;
            pictureBox1.Location = new Point(215, 151);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(301, 275);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.BackColor = Color.FromArgb(61, 60, 60);
            textBoxCorreo.BorderStyle = BorderStyle.None;
            textBoxCorreo.Font = new Font("Segoe UI", 13.875F);
            textBoxCorreo.ForeColor = SystemColors.Control;
            textBoxCorreo.Location = new Point(11, 38);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(578, 50);
            textBoxCorreo.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(15, 5);
            label2.Name = "label2";
            label2.Size = new Size(94, 29);
            label2.TabIndex = 1;
            label2.Text = "Correo";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(141, 15);
            label1.Name = "label1";
            label1.Size = new Size(497, 97);
            label1.TabIndex = 0;
            label1.Text = "Iniciar Sesion";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(textBoxCorreo);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(72, 529);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 92);
            panel2.TabIndex = 8;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(textBoxPassword);
            panel3.Location = new Point(72, 684);
            panel3.Name = "panel3";
            panel3.Size = new Size(600, 92);
            panel3.TabIndex = 9;
            panel3.Paint += panel3_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.Control;
            label3.Location = new Point(15, 6);
            label3.Name = "label3";
            label3.Size = new Size(146, 29);
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
            textBoxPassword.Location = new Point(15, 39);
            textBoxPassword.Name = "textBoxPassword";
            textBoxPassword.PasswordChar = '*';
            textBoxPassword.Size = new Size(578, 50);
            textBoxPassword.TabIndex = 6;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(877, 1154);
            Controls.Add(panel1);
            Name = "FormLogin";
            Padding = new Padding(3, 24, 3, 3);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar sesion";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
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
