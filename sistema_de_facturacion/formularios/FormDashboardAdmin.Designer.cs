namespace sistema_de_reservas.formularios
{
    partial class FormDashboardAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDashboardAdmin));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            labelNombreUsuario = new Label();
            tabPage2 = new TabPage();
            button19 = new Button();
            panel4 = new Panel();
            textBox4 = new TextBox();
            buttonEliminarSala = new Button();
            buttonEditarSala = new Button();
            buttonAgregarSala = new Button();
            dataGridViewSalas = new DataGridView();
            tabPage3 = new TabPage();
            button18 = new Button();
            panel3 = new Panel();
            textBox3 = new TextBox();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            dataGridViewRecursos = new DataGridView();
            tabPage4 = new TabPage();
            button10 = new Button();
            button11 = new Button();
            dataGridViewReservas = new DataGridView();
            tabPage5 = new TabPage();
            button17 = new Button();
            panel2 = new Panel();
            textBox2 = new TextBox();
            button13 = new Button();
            button14 = new Button();
            button15 = new Button();
            dataGridViewRecepcionistas = new DataGridView();
            tabPage6 = new TabPage();
            button16 = new Button();
            panel1 = new Panel();
            textBox1 = new TextBox();
            button3 = new Button();
            buttonEditarCliente = new Button();
            button1 = new Button();
            dataGridViewClientes = new DataGridView();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            button12 = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalas).BeginInit();
            tabPage3.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecursos).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).BeginInit();
            tabPage5.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecepcionistas).BeginInit();
            tabPage6.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Location = new Point(50, 48);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(2597, 1288);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.FromArgb(33, 33, 33);
            tabPage1.Controls.Add(labelNombreUsuario);
            tabPage1.ForeColor = SystemColors.Control;
            tabPage1.Location = new Point(8, 46);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(2581, 1234);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Sesiones";
            // 
            // labelNombreUsuario
            // 
            labelNombreUsuario.AutoSize = true;
            labelNombreUsuario.Font = new Font("Microsoft Sans Serif", 28.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombreUsuario.Location = new Point(58, 38);
            labelNombreUsuario.Name = "labelNombreUsuario";
            labelNombreUsuario.Size = new Size(502, 85);
            labelNombreUsuario.TabIndex = 0;
            labelNombreUsuario.Text = "Administrador";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.FromArgb(33, 33, 33);
            tabPage2.Controls.Add(button19);
            tabPage2.Controls.Add(panel4);
            tabPage2.Controls.Add(buttonEliminarSala);
            tabPage2.Controls.Add(buttonEditarSala);
            tabPage2.Controls.Add(buttonAgregarSala);
            tabPage2.Controls.Add(dataGridViewSalas);
            tabPage2.Location = new Point(8, 46);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(2581, 1234);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Salas";
            // 
            // button19
            // 
            button19.BackColor = Color.FromArgb(156, 108, 254);
            button19.FlatStyle = FlatStyle.Flat;
            button19.Image = (Image)resources.GetObject("button19.Image");
            button19.Location = new Point(857, 64);
            button19.Name = "button19";
            button19.Size = new Size(111, 83);
            button19.TabIndex = 10;
            button19.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(61, 60, 60);
            panel4.Controls.Add(textBox4);
            panel4.Location = new Point(33, 64);
            panel4.Name = "panel4";
            panel4.Size = new Size(799, 83);
            panel4.TabIndex = 9;
            // 
            // textBox4
            // 
            textBox4.BackColor = Color.FromArgb(61, 60, 60);
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox4.Location = new Point(15, 12);
            textBox4.Name = "textBox4";
            textBox4.PlaceholderText = "Nombre ";
            textBox4.Size = new Size(750, 58);
            textBox4.TabIndex = 0;
            // 
            // buttonEliminarSala
            // 
            buttonEliminarSala.BackColor = Color.FromArgb(222, 16, 16);
            buttonEliminarSala.FlatStyle = FlatStyle.Flat;
            buttonEliminarSala.Image = (Image)resources.GetObject("buttonEliminarSala.Image");
            buttonEliminarSala.Location = new Point(2085, 311);
            buttonEliminarSala.Name = "buttonEliminarSala";
            buttonEliminarSala.Size = new Size(120, 100);
            buttonEliminarSala.TabIndex = 6;
            buttonEliminarSala.UseVisualStyleBackColor = false;
            buttonEliminarSala.Click += buttonEliminarSala_Click;
            // 
            // buttonEditarSala
            // 
            buttonEditarSala.BackColor = Color.FromArgb(242, 84, 63);
            buttonEditarSala.FlatStyle = FlatStyle.Flat;
            buttonEditarSala.Image = (Image)resources.GetObject("buttonEditarSala.Image");
            buttonEditarSala.Location = new Point(2247, 311);
            buttonEditarSala.Name = "buttonEditarSala";
            buttonEditarSala.Size = new Size(120, 100);
            buttonEditarSala.TabIndex = 5;
            buttonEditarSala.UseVisualStyleBackColor = false;
            buttonEditarSala.Click += buttonEditarSala_Click;
            // 
            // buttonAgregarSala
            // 
            buttonAgregarSala.BackColor = Color.FromArgb(156, 108, 254);
            buttonAgregarSala.FlatStyle = FlatStyle.Popup;
            buttonAgregarSala.Location = new Point(2396, 311);
            buttonAgregarSala.Name = "buttonAgregarSala";
            buttonAgregarSala.Padding = new Padding(20);
            buttonAgregarSala.Size = new Size(120, 100);
            buttonAgregarSala.TabIndex = 4;
            buttonAgregarSala.UseVisualStyleBackColor = false;
            buttonAgregarSala.Click += buttonAgregarSala_Click;
            // 
            // dataGridViewSalas
            // 
            dataGridViewSalas.BackgroundColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.Gray;
            dataGridViewCellStyle1.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.Padding = new Padding(10);
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewSalas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewSalas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 33, 33, 33);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewSalas.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewSalas.Location = new Point(30, 439);
            dataGridViewSalas.Name = "dataGridViewSalas";
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(33, 33, 33, 33);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewSalas.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewSalas.RowHeadersWidth = 82;
            dataGridViewSalas.Size = new Size(2531, 769);
            dataGridViewSalas.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.FromArgb(33, 33, 33);
            tabPage3.Controls.Add(button18);
            tabPage3.Controls.Add(panel3);
            tabPage3.Controls.Add(button7);
            tabPage3.Controls.Add(button8);
            tabPage3.Controls.Add(button9);
            tabPage3.Controls.Add(dataGridViewRecursos);
            tabPage3.Location = new Point(8, 46);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(2581, 1234);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Recursos";
            // 
            // button18
            // 
            button18.BackColor = Color.FromArgb(156, 108, 254);
            button18.FlatStyle = FlatStyle.Flat;
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.Location = new Point(857, 64);
            button18.Name = "button18";
            button18.Size = new Size(111, 83);
            button18.TabIndex = 10;
            button18.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(61, 60, 60);
            panel3.Controls.Add(textBox3);
            panel3.Location = new Point(33, 64);
            panel3.Name = "panel3";
            panel3.Size = new Size(799, 83);
            panel3.TabIndex = 9;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.FromArgb(61, 60, 60);
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox3.Location = new Point(15, 12);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Nombre ";
            textBox3.Size = new Size(750, 58);
            textBox3.TabIndex = 0;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(222, 16, 16);
            button7.FlatStyle = FlatStyle.Flat;
            button7.Image = Properties.Resources.eliminar;
            button7.Location = new Point(2085, 311);
            button7.Name = "button7";
            button7.Size = new Size(120, 100);
            button7.TabIndex = 6;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.BackColor = Color.FromArgb(242, 84, 63);
            button8.FlatStyle = FlatStyle.Flat;
            button8.Image = Properties.Resources.editar;
            button8.Location = new Point(2247, 311);
            button8.Name = "button8";
            button8.Size = new Size(120, 100);
            button8.TabIndex = 5;
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.BackColor = Color.FromArgb(156, 108, 254);
            button9.FlatStyle = FlatStyle.Popup;
            button9.Image = Properties.Resources.add;
            button9.Location = new Point(2396, 311);
            button9.Name = "button9";
            button9.Padding = new Padding(20);
            button9.Size = new Size(120, 100);
            button9.TabIndex = 4;
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // dataGridViewRecursos
            // 
            dataGridViewRecursos.BackgroundColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = SystemColors.Control;
            dataGridViewCellStyle4.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.Padding = new Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewRecursos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewRecursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle5.ForeColor = SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewRecursos.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewRecursos.Location = new Point(13, 450);
            dataGridViewRecursos.Name = "dataGridViewRecursos";
            dataGridViewRecursos.RowHeadersWidth = 82;
            dataGridViewRecursos.Size = new Size(2531, 769);
            dataGridViewRecursos.TabIndex = 0;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.FromArgb(33, 33, 33);
            tabPage4.Controls.Add(button10);
            tabPage4.Controls.Add(button11);
            tabPage4.Controls.Add(button12);
            tabPage4.Controls.Add(dataGridViewReservas);
            tabPage4.Location = new Point(8, 46);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(2581, 1234);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Reservas";
            // 
            // button10
            // 
            button10.BackColor = Color.FromArgb(222, 16, 16);
            button10.FlatStyle = FlatStyle.Flat;
            button10.Image = Properties.Resources.eliminar;
            button10.Location = new Point(2085, 311);
            button10.Name = "button10";
            button10.Size = new Size(120, 100);
            button10.TabIndex = 6;
            button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            button11.BackColor = Color.FromArgb(242, 84, 63);
            button11.FlatStyle = FlatStyle.Flat;
            button11.Image = Properties.Resources.editar;
            button11.Location = new Point(2247, 311);
            button11.Name = "button11";
            button11.Size = new Size(120, 100);
            button11.TabIndex = 5;
            button11.TextAlign = ContentAlignment.MiddleRight;
            button11.UseVisualStyleBackColor = false;
            // 
            // dataGridViewReservas
            // 
            dataGridViewReservas.BackgroundColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle6.BackColor = SystemColors.Control;
            dataGridViewCellStyle6.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewReservas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewReservas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle7.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle7.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dataGridViewReservas.DefaultCellStyle = dataGridViewCellStyle7;
            dataGridViewReservas.Location = new Point(0, 491);
            dataGridViewReservas.Name = "dataGridViewReservas";
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle8.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.True;
            dataGridViewReservas.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            dataGridViewReservas.RowHeadersWidth = 82;
            dataGridViewReservas.Size = new Size(2531, 769);
            dataGridViewReservas.TabIndex = 0;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.FromArgb(33, 33, 33);
            tabPage5.Controls.Add(button17);
            tabPage5.Controls.Add(panel2);
            tabPage5.Controls.Add(button13);
            tabPage5.Controls.Add(button14);
            tabPage5.Controls.Add(button15);
            tabPage5.Controls.Add(dataGridViewRecepcionistas);
            tabPage5.Location = new Point(8, 46);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(2581, 1234);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Recepcionistas";
            // 
            // button17
            // 
            button17.BackColor = Color.FromArgb(156, 108, 254);
            button17.FlatStyle = FlatStyle.Flat;
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.Location = new Point(857, 64);
            button17.Name = "button17";
            button17.Size = new Size(111, 83);
            button17.TabIndex = 8;
            button17.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(61, 60, 60);
            panel2.Controls.Add(textBox2);
            panel2.Location = new Point(33, 64);
            panel2.Name = "panel2";
            panel2.Size = new Size(799, 83);
            panel2.TabIndex = 7;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.FromArgb(61, 60, 60);
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(15, 12);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Nombre ";
            textBox2.Size = new Size(750, 58);
            textBox2.TabIndex = 0;
            // 
            // button13
            // 
            button13.BackColor = Color.FromArgb(222, 16, 16);
            button13.FlatStyle = FlatStyle.Flat;
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.Location = new Point(2085, 311);
            button13.Name = "button13";
            button13.Size = new Size(120, 100);
            button13.TabIndex = 6;
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button14
            // 
            button14.BackColor = Color.FromArgb(242, 84, 63);
            button14.FlatStyle = FlatStyle.Flat;
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.Location = new Point(2247, 311);
            button14.Name = "button14";
            button14.Size = new Size(120, 100);
            button14.TabIndex = 5;
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button15
            // 
            button15.BackColor = Color.FromArgb(156, 108, 254);
            button15.FlatStyle = FlatStyle.Popup;
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.Location = new Point(2396, 311);
            button15.Name = "button15";
            button15.Padding = new Padding(20);
            button15.Size = new Size(120, 100);
            button15.TabIndex = 4;
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // dataGridViewRecepcionistas
            // 
            dataGridViewRecepcionistas.BackgroundColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle9.BackColor = SystemColors.Control;
            dataGridViewCellStyle9.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle9.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dataGridViewRecepcionistas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewRecepcionistas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle10.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle10.ForeColor = SystemColors.Control;
            dataGridViewCellStyle10.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle10.WrapMode = DataGridViewTriState.False;
            dataGridViewRecepcionistas.DefaultCellStyle = dataGridViewCellStyle10;
            dataGridViewRecepcionistas.Location = new Point(24, 449);
            dataGridViewRecepcionistas.Name = "dataGridViewRecepcionistas";
            dataGridViewRecepcionistas.RowHeadersWidth = 82;
            dataGridViewRecepcionistas.Size = new Size(2531, 769);
            dataGridViewRecepcionistas.TabIndex = 0;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.FromArgb(33, 33, 33);
            tabPage6.Controls.Add(button16);
            tabPage6.Controls.Add(panel1);
            tabPage6.Controls.Add(button3);
            tabPage6.Controls.Add(buttonEditarCliente);
            tabPage6.Controls.Add(button1);
            tabPage6.Controls.Add(dataGridViewClientes);
            tabPage6.Location = new Point(8, 46);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(2581, 1234);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "Clientes";
            // 
            // button16
            // 
            button16.BackColor = Color.FromArgb(156, 108, 254);
            button16.FlatStyle = FlatStyle.Flat;
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.Location = new Point(857, 64);
            button16.Name = "button16";
            button16.Size = new Size(111, 83);
            button16.TabIndex = 4;
            button16.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(61, 60, 60);
            panel1.Controls.Add(textBox1);
            panel1.Location = new Point(33, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 83);
            panel1.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(61, 60, 60);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(15, 12);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Nombre ";
            textBox1.Size = new Size(750, 58);
            textBox1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(222, 16, 16);
            button3.FlatStyle = FlatStyle.Flat;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(2085, 311);
            button3.Name = "button3";
            button3.Size = new Size(120, 100);
            button3.TabIndex = 3;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonEditarCliente
            // 
            buttonEditarCliente.BackColor = Color.FromArgb(242, 84, 63);
            buttonEditarCliente.FlatStyle = FlatStyle.Flat;
            buttonEditarCliente.Image = (Image)resources.GetObject("buttonEditarCliente.Image");
            buttonEditarCliente.Location = new Point(2247, 311);
            buttonEditarCliente.Name = "buttonEditarCliente";
            buttonEditarCliente.Size = new Size(120, 100);
            buttonEditarCliente.TabIndex = 2;
            buttonEditarCliente.UseVisualStyleBackColor = false;
            buttonEditarCliente.Click += buttonEditarCliente_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(156, 108, 254);
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(2396, 311);
            button1.Name = "button1";
            button1.Padding = new Padding(20);
            button1.Size = new Size(120, 100);
            button1.TabIndex = 1;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewCellStyle11.BackColor = Color.Transparent;
            dataGridViewClientes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dataGridViewClientes.BackgroundColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = Color.Gray;
            dataGridViewCellStyle12.Font = new Font("Microsoft Sans Serif", 13.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle12.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle12.Padding = new Padding(10);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = SystemColors.ButtonShadow;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = Color.FromArgb(33, 33, 33);
            dataGridViewCellStyle13.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle13.ForeColor = SystemColors.Control;
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dataGridViewClientes.DefaultCellStyle = dataGridViewCellStyle13;
            dataGridViewClientes.Location = new Point(21, 442);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.Gray;
            dataGridViewCellStyle14.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle14.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dataGridViewClientes.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dataGridViewClientes.RowHeadersWidth = 82;
            dataGridViewClientes.Size = new Size(2531, 769);
            dataGridViewClientes.TabIndex = 0;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // button12
            // 
            button12.BackColor = Color.FromArgb(156, 108, 254);
            button12.FlatStyle = FlatStyle.Popup;
            button12.Image = Properties.Resources.date;
            button12.Location = new Point(2396, 311);
            button12.Name = "button12";
            button12.Padding = new Padding(20);
            button12.Size = new Size(120, 100);
            button12.TabIndex = 4;
            button12.Text = "x";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // FormDashboardAdmin
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(61, 60, 60);
            ClientSize = new Size(2736, 1366);
            Controls.Add(tabControl1);
            Name = "FormDashboardAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormDashboardAdmin";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewSalas).EndInit();
            tabPage3.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecursos).EndInit();
            tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewReservas).EndInit();
            tabPage5.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRecepcionistas).EndInit();
            tabPage6.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private Label labelNombreUsuario;
        private TabPage tabPage6;
        private DataGridView dataGridViewClientes;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private DataGridView dataGridViewSalas;
        private DataGridView dataGridViewRecursos;
        private DataGridView dataGridViewReservas;
        private DataGridView dataGridViewRecepcionistas;
        private Button button1;
        private Button buttonEditarCliente;
        private Button button3;
        private Button buttonEliminarSala;
        private Button buttonEditarSala;
        private Button buttonAgregarSala;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button10;
        private Button button11;
        private Button button13;
        private Button button14;
        private Button button15;
        private Panel panel1;
        private TextBox textBox1;
        private Button button16;
        private Button button17;
        private Panel panel2;
        private TextBox textBox2;
        private Button button19;
        private Panel panel4;
        private TextBox textBox4;
        private Button button18;
        private Panel panel3;
        private TextBox textBox3;
        private Button button12;
    }
}