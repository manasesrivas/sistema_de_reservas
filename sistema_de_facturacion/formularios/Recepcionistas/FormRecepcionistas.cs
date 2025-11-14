using sistema_de_facturacion.servicios;
using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.ClasesDao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_de_reservas.formularios.Recepcionistas
{
    public partial class FormRecepcionistas : Form
    {
        private int _id;
        public FormRecepcionistas(int id = 0)
        {
            InitializeComponent();
            _id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (
                textBoxNombre.Text == "" || textBoxCorreo.Text == "" ||
                textBoxPassword1.Text == "" || textBoxPassword1.Text == "" ||
                maskedTextBoxDui.Text == "" || maskedTextBoxTelefono.Text == ""
                )
            {
                MessageBox.Show("Porfavor No dejes campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecepcionistaDao recepcionistaDao = new RecepcionistaDao();
            Recepcionista recepcionista;

            if (
                textBoxPassword1.Text != textBoxPassword2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string hash = seguridad.HashPassword(textBoxPassword1.Text);

            if (_id > 0)
            {
                recepcionista = new Recepcionista()
                {
                    IdRecepcionista = _id,
                    Nombre = textBoxNombre.Text.Trim(),
                    Correo = textBoxCorreo.Text.Trim(),
                    Password = hash,
                    Dui = maskedTextBoxDui.Text,
                    Telefono = maskedTextBoxTelefono.Text
                };


                try
                {
                    if (recepcionistaDao.Update(recepcionista))
                    {
                        DialogResult = DialogResult.OK;
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo actualizar el registro", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (ApplicationException ex)
                {
                    MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                return;
            }

            recepcionista = new Recepcionista()
            {
                Nombre = textBoxNombre.Text.Trim(),
                Correo = textBoxCorreo.Text.Trim(),
                Password = hash,
                Dui = maskedTextBoxDui.Text,
                Telefono = maskedTextBoxTelefono.Text
            };

            try
            {
                var id = recepcionistaDao.Insert(recepcionista);

                if (id > 0)
                {
                    MessageBox.Show(
                        "Recurso ingresado con exito",
                        "Exito",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show(
                        "Recurso ingresado sin exito",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(
                    ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ocurrio un error inesperado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void FormRecepcionistas_Load(object sender, EventArgs e)
        {
            if (_id == 0) return;
            var recepcionistaDao = new RecepcionistaDao();
            var p = recepcionistaDao.GetById(_id);
            if (p == null)
            {
                MessageBox.Show("registro no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxNombre.Text = p.Nombre;
            textBoxCorreo.Text = p.Correo;
            maskedTextBoxTelefono.Text = p.Telefono;
            maskedTextBoxDui.Text = p.Dui;
        }
    }
}
