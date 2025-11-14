using Microsoft.Data.SqlClient;
using sistema_de_reservas.Servicios;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sistema_de_reservas.formularios.Clientes;
using sistema_de_reservas.formularios.Salas;
using sistema_de_reservas.formularios.Recepcionistas;
using sistema_de_reservas.formularios.Reservaciones;
using sistema_de_reservas.formularios.Recursos;
using sistema_de_reservas.Core.Dao.ClasesDao;
using sistema_de_reservas.Core.Clases;
using System.Configuration;

namespace sistema_de_reservas.formularios
{
    public partial class FormDashboardAdmin : Form
    {
        private int idUser;
        private SalasDao salasDao;
        private RecursoDao recursoDao;
        private RecepcionistaDao recepcionistaDao;
        private ClienteDao clienteDao;
        public FormDashboardAdmin(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;

            //cargarNombreUsuario();
            cargarSalas();
            cargarRecursos();
            cargarClientes();
            cargarUsuarios();
            //cargarReservas();

        }

        private void cargarNombreUsuario()
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["SqlConn"].ConnectionString))
            {
                string query = "SELECT Nombre FROM Usuario WHERE Id_usuarios = @id";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@id", idUser);
                con.Open();
                object resultado = cmd.ExecuteScalar();

                if (resultado != null)
                {
                    string nombre = resultado.ToString();
                    labelNombreUsuario.Text = $"Bienvenido: {nombre}";
                }
                else
                {
                    labelNombreUsuario.Text = "Panel de Administrador: (sin nombre)";
                }
            }
        }

        private void cargarClientes()
        {
            configurationGridClientes();
            clienteDao = new ClienteDao();
            dataGridViewClientes.DataSource = clienteDao.GetAll();
            dataGridViewClientes.ClearSelection();
            dataGridViewClientes.CurrentCell = null;
        }



        private void cargarUsuarios()
        {
            configurationGridRecepcionistas();
            recepcionistaDao = new RecepcionistaDao();
            dataGridViewRecepcionistas.DataSource = recepcionistaDao.GetAll();
            dataGridViewRecepcionistas.ClearSelection();
            dataGridViewRecepcionistas.CurrentCell = null;
        }


        private void cargarReservas()
        {
            dataGridViewReservas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewReservas.MultiSelect = false;
            dataGridViewReservas.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewReservas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 108, 254);
            dataGridViewReservas.DefaultCellStyle.SelectionForeColor = Color.White;
            using (SqlConnection con = new SqlConnection(Conexion.cadena))
            {
                string query = @"SELECT r.Id, c.Nombre AS Cliente, s.Nombre AS Sala, 
                                        r.FechaInicio, r.FechaFin, r.Tipo, r.Estado
                                 FROM Reservas r
                                 JOIN Cliente c ON r.ClienteId = c.Id_cliente
                                 JOIN Salas s ON r.SalaId = s.Id_salas";
                SqlDataAdapter da = new SqlDataAdapter(query, con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridViewReservas.DataSource = dt;
            }
        }
        private void cargarRecursos()
        {
            configurationGridRecursos();
            recursoDao = new RecursoDao();
            dataGridViewRecursos.DataSource = recursoDao.GetAll();
            dataGridViewRecursos.ClearSelection();
            dataGridViewRecursos.CurrentCell = null;
        }

        private void cargarSalas()
        {
            configurationGridSalas();
            salasDao = new SalasDao();
            dataGridViewSalas.DataSource = salasDao.GetAll();
            dataGridViewSalas.ClearSelection();
            dataGridViewSalas.CurrentCell = null;
        }

        private void configurationGridClientes()
        {
            dataGridViewClientes.AutoGenerateColumns = false;
            dataGridViewClientes.Columns.Clear();
            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });


            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CorreoCol",
                HeaderText = "Correo",
                DataPropertyName = "Correo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });

            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DuiCol",
                HeaderText = "DUI",
                DataPropertyName = "Dui",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });

            dataGridViewClientes.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "TelefonoCol",
                HeaderText = "Teléfono",
                DataPropertyName = "Telefono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
        }



        private void configurationGridSalas()
        {
            dataGridViewSalas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewSalas.MultiSelect = false;
            dataGridViewSalas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 108, 254);
            dataGridViewSalas.DefaultCellStyle.ForeColor = Color.White;
            dataGridViewSalas.DefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Regular);
            dataGridViewSalas.AutoGenerateColumns = false;
            dataGridViewSalas.Columns.Clear();


            dataGridViewSalas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewSalas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CapacidadCol",
                HeaderText = "Capacidad",
                DataPropertyName = "Capacidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewSalas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "DiponibleCol",
                HeaderText = "Disponible",
                DataPropertyName = "Disponible",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }



        private void button1_Click(object sender, EventArgs e)
        {
            FormClientes form = new FormClientes();
            form.ShowDialog();
            cargarClientes();
        }


        private void button12_Click(object sender, EventArgs e)
        {
            FormReservaciones form = new FormReservaciones();
            form.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            FormRecursos form = new FormRecursos();
            form.ShowDialog();
            cargarRecursos();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            FormRecepcionistas form = new FormRecepcionistas();
            form.ShowDialog();
            cargarUsuarios();
        }

        private void configurationGridRecepcionistas()
        {
            dataGridViewRecepcionistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecepcionistas.MultiSelect = false;
            dataGridViewRecepcionistas.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 108, 254);
            dataGridViewRecepcionistas.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewRecepcionistas.AutoGenerateColumns = false;
            dataGridViewRecepcionistas.Columns.Clear();

            dataGridViewRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCol",
                HeaderText = "Id",
                DataPropertyName = "IdRecepcionista",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CostoCol",
                HeaderText = "Correo",
                DataPropertyName = "Correo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecepcionistas.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadCol",
                HeaderText = "Telefono",
                DataPropertyName = "Telefono",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }
        private void configurationGridRecursos()
        {
            dataGridViewRecursos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewRecursos.MultiSelect = false;
            dataGridViewRecursos.DefaultCellStyle.SelectionBackColor = Color.FromArgb(156, 108, 254);
            dataGridViewRecursos.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridViewRecursos.AutoGenerateColumns = false;
            dataGridViewRecursos.Columns.Clear();

            dataGridViewRecursos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "IdCol",
                HeaderText = "Id",
                DataPropertyName = "IdRecurso",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecursos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "NombreCol",
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecursos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CostoCol",
                HeaderText = "Costo",
                DataPropertyName = "Costo",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridViewRecursos.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CantidadCol",
                HeaderText = "Cantidad",
                DataPropertyName = "Cantidad",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
        }

        private int? GetIdSeleccionadoCliente()
        {
            if (dataGridViewClientes.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dataGridViewClientes.CurrentRow.DataBoundItem is Cliente cliente)
            {
                return cliente.IdCliente;
            }

            return null;
        }


        private int? GetIdSeleccionadoRecurso()
        {
            if (dataGridViewRecursos.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dataGridViewRecursos.CurrentRow.DataBoundItem is Recurso propietario)
            {
                return propietario.IdRecurso;
            }

            return null;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoRecurso();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            FormRecursos form = new FormRecursos(id.Value);

            form.ShowDialog();
            cargarRecursos();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoRecurso();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var respuesta = MessageBox.Show(
                "Quieres eliminar este registro?", "confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            try
            {
                if (recursoDao.Delete(id.Value))
                {
                    cargarRecursos();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro",
                        "aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("error inesperado", "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoRecepcionista();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            FormRecepcionistas form = new FormRecepcionistas(id.Value);

            form.ShowDialog();
            cargarUsuarios();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoCliente();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            FormClientes form = new FormClientes(id.Value);
            form.ShowDialog();
            cargarClientes();
        }


        private int? GetIdSeleccionadoSalas()
        {
            if (dataGridViewSalas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dataGridViewSalas.CurrentRow.DataBoundItem is Sala salas)
            {
                return salas.IdSalas;
            }

            return null;
        }



        private int? GetIdSeleccionadoRecepcionista()
        {
            if (dataGridViewRecepcionistas.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dataGridViewRecepcionistas.CurrentRow.DataBoundItem is Recepcionista recepcionista)
            {
                return recepcionista.IdRecepcionista;
            }

            return null;

        }

        private void button13_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoRecepcionista();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var respuesta = MessageBox.Show(
                "Quieres eliminar este registro?", "confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            try
            {
                if (recepcionistaDao.Delete(id.Value))
                {
                    cargarUsuarios();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro",
                        "aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("error inesperado" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewRecepcionistas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        private void button4_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoSalas();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var respuesta = MessageBox.Show(
                "Quieres eliminar este registro?", "confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            try
            {
                if (salasDao.Delete(id.Value))
                {
                    cargarSalas();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro",
                        "aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("error inesperado" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionadoSalas();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }

            FormSalas form = new FormSalas(id.Value);
            form.ShowDialog();
            cargarSalas();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            FormSalas form = new FormSalas();
            form.ShowDialog();
            cargarSalas();
        }

        private void button3_Click(object sender, EventArgs e)
        {
             var id = GetIdSeleccionadoCliente();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
            var respuesta = MessageBox.Show(
                "Quieres eliminar este registro?", "confirmar",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question
            );

            if (respuesta == DialogResult.No) return;

            try
            {
                if (clienteDao.Delete(id.Value))
                {
                    cargarClientes();
                }
                else
                {
                    MessageBox.Show(
                        "No se pudo eliminar el registro",
                        "aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            catch (Exception ex)
            {
                MessageBox.Show("error inesperado" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }

}
