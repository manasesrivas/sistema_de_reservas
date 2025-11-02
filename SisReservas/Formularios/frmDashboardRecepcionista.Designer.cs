namespace SisReservas.Formularios
{
    partial class frmDashboardRecepcionista
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboardRecepcionista));
            this.dgvTodasReservas = new System.Windows.Forms.DataGridView();
            this.btnActualizarEstado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblRecepcionista = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasReservas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvTodasReservas
            // 
            this.dgvTodasReservas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTodasReservas.Location = new System.Drawing.Point(36, 76);
            this.dgvTodasReservas.Name = "dgvTodasReservas";
            this.dgvTodasReservas.Size = new System.Drawing.Size(268, 233);
            this.dgvTodasReservas.TabIndex = 0;
            // 
            // btnActualizarEstado
            // 
            this.btnActualizarEstado.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizarEstado.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizarEstado.Image")));
            this.btnActualizarEstado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizarEstado.Location = new System.Drawing.Point(385, 274);
            this.btnActualizarEstado.Name = "btnActualizarEstado";
            this.btnActualizarEstado.Size = new System.Drawing.Size(226, 35);
            this.btnActualizarEstado.TabIndex = 1;
            this.btnActualizarEstado.Text = "Actualizar Estado";
            this.btnActualizarEstado.UseVisualStyleBackColor = true;
            this.btnActualizarEstado.Click += new System.EventHandler(this.btnActualizarEstado_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(474, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(162, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // lblRecepcionista
            // 
            this.lblRecepcionista.AutoSize = true;
            this.lblRecepcionista.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecepcionista.Location = new System.Drawing.Point(500, 93);
            this.lblRecepcionista.Name = "lblRecepcionista";
            this.lblRecepcionista.Size = new System.Drawing.Size(111, 16);
            this.lblRecepcionista.TabIndex = 4;
            this.lblRecepcionista.Text = "Recepcionista";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dgvTodasReservas);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(329, 338);
            this.panel1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(77, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lista Reservas";
            // 
            // frmDashboardRecepcionista
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(634, 338);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRecepcionista);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnActualizarEstado);
            this.Name = "frmDashboardRecepcionista";
            this.Text = "frmDashboardRecepcionista";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTodasReservas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTodasReservas;
        private System.Windows.Forms.Button btnActualizarEstado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblRecepcionista;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}