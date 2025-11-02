namespace SisReservas.Formularios
{
    partial class frmDashboardAdmin
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.Sesion = new System.Windows.Forms.TabPage();
            this.lblAdmin = new System.Windows.Forms.Label();
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.Salas = new System.Windows.Forms.TabPage();
            this.dgvSalas = new System.Windows.Forms.DataGridView();
            this.Recursos = new System.Windows.Forms.TabPage();
            this.dgvRecursos = new System.Windows.Forms.DataGridView();
            this.Reservas = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuscarReserva = new System.Windows.Forms.Button();
            this.cbEstadoReserva = new System.Windows.Forms.ComboBox();
            this.btnCambiarEstado = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvReservas = new System.Windows.Forms.DataGridView();
            this.Usuarios = new System.Windows.Forms.TabPage();
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.Clientes = new System.Windows.Forms.TabPage();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtBuscarReserva = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.Sesion.SuspendLayout();
            this.Salas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).BeginInit();
            this.Recursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).BeginInit();
            this.Reservas.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).BeginInit();
            this.Usuarios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.Clientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.Sesion);
            this.TabControl.Controls.Add(this.Salas);
            this.TabControl.Controls.Add(this.Recursos);
            this.TabControl.Controls.Add(this.Reservas);
            this.TabControl.Controls.Add(this.Usuarios);
            this.TabControl.Controls.Add(this.Clientes);
            this.TabControl.Location = new System.Drawing.Point(4, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(759, 340);
            this.TabControl.TabIndex = 1;
            // 
            // Sesion
            // 
            this.Sesion.Controls.Add(this.lblAdmin);
            this.Sesion.Controls.Add(this.btnRegistrarUsuario);
            this.Sesion.Location = new System.Drawing.Point(4, 22);
            this.Sesion.Name = "Sesion";
            this.Sesion.Padding = new System.Windows.Forms.Padding(3);
            this.Sesion.Size = new System.Drawing.Size(751, 314);
            this.Sesion.TabIndex = 0;
            this.Sesion.Text = "Sesion";
            this.Sesion.UseVisualStyleBackColor = true;
            // 
            // lblAdmin
            // 
            this.lblAdmin.AutoSize = true;
            this.lblAdmin.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdmin.Location = new System.Drawing.Point(20, 19);
            this.lblAdmin.Name = "lblAdmin";
            this.lblAdmin.Size = new System.Drawing.Size(179, 23);
            this.lblAdmin.TabIndex = 1;
            this.lblAdmin.Text = "Administrador";
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(259, 142);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarUsuario.TabIndex = 0;
            this.btnRegistrarUsuario.Text = "button1";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = true;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click_1);
            // 
            // Salas
            // 
            this.Salas.Controls.Add(this.dgvSalas);
            this.Salas.Location = new System.Drawing.Point(4, 22);
            this.Salas.Name = "Salas";
            this.Salas.Padding = new System.Windows.Forms.Padding(3);
            this.Salas.Size = new System.Drawing.Size(751, 314);
            this.Salas.TabIndex = 1;
            this.Salas.Text = "Salas";
            this.Salas.UseVisualStyleBackColor = true;
            // 
            // dgvSalas
            // 
            this.dgvSalas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalas.Location = new System.Drawing.Point(6, 118);
            this.dgvSalas.Name = "dgvSalas";
            this.dgvSalas.Size = new System.Drawing.Size(298, 190);
            this.dgvSalas.TabIndex = 0;
            // 
            // Recursos
            // 
            this.Recursos.Controls.Add(this.dgvRecursos);
            this.Recursos.Location = new System.Drawing.Point(4, 22);
            this.Recursos.Name = "Recursos";
            this.Recursos.Padding = new System.Windows.Forms.Padding(3);
            this.Recursos.Size = new System.Drawing.Size(751, 314);
            this.Recursos.TabIndex = 2;
            this.Recursos.Text = "Recursos";
            this.Recursos.UseVisualStyleBackColor = true;
            // 
            // dgvRecursos
            // 
            this.dgvRecursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRecursos.Location = new System.Drawing.Point(6, 100);
            this.dgvRecursos.Name = "dgvRecursos";
            this.dgvRecursos.Size = new System.Drawing.Size(389, 204);
            this.dgvRecursos.TabIndex = 1;
            // 
            // Reservas
            // 
            this.Reservas.Controls.Add(this.panel1);
            this.Reservas.Controls.Add(this.label3);
            this.Reservas.Controls.Add(this.label1);
            this.Reservas.Controls.Add(this.dgvReservas);
            this.Reservas.Location = new System.Drawing.Point(4, 22);
            this.Reservas.Name = "Reservas";
            this.Reservas.Padding = new System.Windows.Forms.Padding(3);
            this.Reservas.Size = new System.Drawing.Size(751, 314);
            this.Reservas.TabIndex = 3;
            this.Reservas.Text = "Reservas";
            this.Reservas.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.txtBuscarReserva);
            this.panel1.Controls.Add(this.btnBuscarReserva);
            this.panel1.Controls.Add(this.cbEstadoReserva);
            this.panel1.Controls.Add(this.btnCambiarEstado);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(751, 46);
            this.panel1.TabIndex = 9;
            // 
            // btnBuscarReserva
            // 
            this.btnBuscarReserva.Location = new System.Drawing.Point(178, 19);
            this.btnBuscarReserva.Name = "btnBuscarReserva";
            this.btnBuscarReserva.Size = new System.Drawing.Size(73, 20);
            this.btnBuscarReserva.TabIndex = 6;
            this.btnBuscarReserva.Text = "Buscar";
            this.btnBuscarReserva.UseVisualStyleBackColor = true;
            this.btnBuscarReserva.Click += new System.EventHandler(this.btnBuscarReserva_Click);
            // 
            // cbEstadoReserva
            // 
            this.cbEstadoReserva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstadoReserva.FormattingEnabled = true;
            this.cbEstadoReserva.Location = new System.Drawing.Point(420, 18);
            this.cbEstadoReserva.Name = "cbEstadoReserva";
            this.cbEstadoReserva.Size = new System.Drawing.Size(193, 21);
            this.cbEstadoReserva.TabIndex = 2;
            // 
            // btnCambiarEstado
            // 
            this.btnCambiarEstado.Location = new System.Drawing.Point(619, 18);
            this.btnCambiarEstado.Name = "btnCambiarEstado";
            this.btnCambiarEstado.Size = new System.Drawing.Size(75, 21);
            this.btnCambiarEstado.TabIndex = 3;
            this.btnCambiarEstado.Text = "Actualizar";
            this.btnCambiarEstado.UseVisualStyleBackColor = true;
            this.btnCambiarEstado.Click += new System.EventHandler(this.btnCambiarEstado_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(305, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 22);
            this.label3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 22);
            this.label1.TabIndex = 4;
            this.label1.Text = "Panel de Reservas";
            // 
            // dgvReservas
            // 
            this.dgvReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservas.Location = new System.Drawing.Point(0, 164);
            this.dgvReservas.Name = "dgvReservas";
            this.dgvReservas.Size = new System.Drawing.Size(751, 150);
            this.dgvReservas.TabIndex = 1;
            // 
            // Usuarios
            // 
            this.Usuarios.Controls.Add(this.dgvUsuarios);
            this.Usuarios.Location = new System.Drawing.Point(4, 22);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(3);
            this.Usuarios.Size = new System.Drawing.Size(751, 314);
            this.Usuarios.TabIndex = 4;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.UseVisualStyleBackColor = true;
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(6, 65);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.Size = new System.Drawing.Size(480, 243);
            this.dgvUsuarios.TabIndex = 3;
            // 
            // Clientes
            // 
            this.Clientes.Controls.Add(this.dgvClientes);
            this.Clientes.Location = new System.Drawing.Point(4, 22);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(3);
            this.Clientes.Size = new System.Drawing.Size(751, 314);
            this.Clientes.TabIndex = 5;
            this.Clientes.Text = "Clientes";
            this.Clientes.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(6, 53);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.Size = new System.Drawing.Size(428, 242);
            this.dgvClientes.TabIndex = 0;
            // 
            // txtBuscarReserva
            // 
            this.txtBuscarReserva.Location = new System.Drawing.Point(10, 19);
            this.txtBuscarReserva.Name = "txtBuscarReserva";
            this.txtBuscarReserva.Size = new System.Drawing.Size(162, 20);
            this.txtBuscarReserva.TabIndex = 7;
            // 
            // frmDashboardAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(749, 338);
            this.Controls.Add(this.TabControl);
            this.Name = "frmDashboardAdmin";
            this.Text = "frmDashboardAdmin";
            this.TabControl.ResumeLayout(false);
            this.Sesion.ResumeLayout(false);
            this.Sesion.PerformLayout();
            this.Salas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalas)).EndInit();
            this.Recursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRecursos)).EndInit();
            this.Reservas.ResumeLayout(false);
            this.Reservas.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservas)).EndInit();
            this.Usuarios.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.Clientes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage Salas;
        private System.Windows.Forms.TabPage Recursos;
        private System.Windows.Forms.TabPage Sesion;
        private System.Windows.Forms.TabPage Reservas;
        private System.Windows.Forms.TabPage Usuarios;
        private System.Windows.Forms.DataGridView dgvRecursos;
        private System.Windows.Forms.DataGridView dgvReservas;
        private System.Windows.Forms.DataGridView dgvSalas;
        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Label lblAdmin;
        private System.Windows.Forms.Button btnRegistrarUsuario;
        private System.Windows.Forms.TabPage Clientes;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCambiarEstado;
        private System.Windows.Forms.ComboBox cbEstadoReserva;
        private System.Windows.Forms.Button btnBuscarReserva;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBuscarReserva;
    }
}