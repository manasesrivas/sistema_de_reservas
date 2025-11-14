using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.ClasesDao;
using System.Security.Cryptography;

namespace sistema_de_reservas.formularios.Recursos
{

    /*
     * 
     * TIPOS DE RECURSOS
     * equipamiento
     * inmoviliario
     * alimentos y bebidas
     * ambientacion
     * digital o tecnologico
     */
    public partial class FormRecursos : Form
    {
        private int _id;
        public FormRecursos(int id = 0)
        {
            InitializeComponent();
            _id = id;
 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(
                textBoxNombreRecurso.Text == "" || comboBoxTipo.SelectedIndex == -1 || 
                numericUpDownCosto.Value == 0 ||
                numericUpDownCantidadDisponible.Value == 0
                )
            {
                MessageBox.Show("Porfavor No dejes campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            RecursoDao recursoDao = new RecursoDao();
            Recurso recurso;
            if(_id>0)
            {
                recurso = new Recurso(){
                    IdRecurso = _id,
                    Nombre = textBoxNombreRecurso.Text,
                    Tipo = comboBoxTipo.Text,
                    Costo = numericUpDownCosto.Value,
                    Cantidad = Convert.ToInt32(numericUpDownCantidadDisponible.Value),
                };

                try
                {
                    if (recursoDao.Update(recurso))
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
            recurso = new Recurso(){
                Nombre = textBoxNombreRecurso.Text.Trim(),
                Tipo = comboBoxTipo.Text.Trim(),
                Costo = numericUpDownCosto.Value,
                Cantidad = Convert.ToInt16(numericUpDownCantidadDisponible.Value)
            };

            try
            {
                var id = recursoDao.Insert(recurso);

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

        private void formActualizarPropietario_Load(object sender, EventArgs e)
        {
            
        }

        private void FormRecursos_Load(object sender, EventArgs e)
        {
            if (_id == 0) return;
            var recursoDao = new RecursoDao();
            var p = recursoDao.GetById(_id);
            if (p == null)
            {
                MessageBox.Show("Propietario no encontrado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            textBoxNombreRecurso.Text = p.Nombre;
            comboBoxTipo.Text = p.Tipo;
            numericUpDownCosto.Value = p.Costo;
            numericUpDownCantidadDisponible.Value = p.Cantidad;
        }
    }
}
