using Microsoft.Data.SqlClient;
using sistema_de_rerservas.Core.Lib;
using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.ClasesDao
{
    internal class ClienteDao : Cnn, IClienteDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idCliente)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Clientes WHERE Id_cliente = @id_cliente;", Con);
                command.Parameters.Add("@id_cliente", SqlDbType.Int).Value = idCliente;
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ApplicationException("No se puede eliminar. " + ex.Message);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public List<Cliente> GetAll(string filtro = "")
        {
            var lista = new List<Cliente>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"SELECT Id_usuario, Nombre, Correo, Dui, Telefono FROM Usuarios";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql = sql.Replace("/**where**/", "WHERE Nombre LIKE @r  OR Apellido LIKE @f OR DUI @f");
                }
                else
                {
                    sql = sql.Replace("/**where**/", string.Empty);
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", System.Data.SqlDbType.NVarChar, 120).Value = "%{filtro}%";
                }

                rd = command.ExecuteReader();

                while (rd.Read())
                {
                    lista.Add(Map(rd));
                }
            }
            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }
            return lista;
        }

        private static Cliente Map(SqlDataReader rd)
        {
            return new Cliente
            {
                IdCliente = rd.GetInt32(0),
                Nombre = rd.GetString(1),
                Correo = rd.GetString(2),
                Dui = rd.GetString(3),
                Telefono = rd.GetString(4)
            };

        }
        public Cliente GetById(int idCliente)
        {
            throw new NotImplementedException();
        }

        public int Insert(Cliente paCliente)
        {
            throw new NotImplementedException();
        }

        public bool Update(Cliente paCliente)
        {
            throw new NotImplementedException();
        }
    }
}
