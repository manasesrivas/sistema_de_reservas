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
                string sql = @"SELECT Id_cliente, Nombre, Correo, Dui, Telefono FROM Clientes";

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    sql += " WHERE Nombre LIKE @f OR Correo LIKE @f OR Dui LIKE @f OR Telefono LIKE @f";
                }

                command = new SqlCommand(sql, Con);

                if (!string.IsNullOrWhiteSpace(filtro))
                {
                    command.Parameters.Add("@f", SqlDbType.NVarChar, 100).Value = $"%{filtro}%";
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


        public Cliente? GetById(int idCliente)
        {
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
            SELECT Id_cliente, Nombre, Correo, Dui, Telefono
            FROM Clientes
            WHERE Id_cliente = @id;", Con);

                command.Parameters.Add("@id", SqlDbType.Int).Value = idCliente;
                rd = command.ExecuteReader(CommandBehavior.SingleRow);

                if (!rd.Read())
                {
                    return null;
                }

                return Map(rd);
            }
            finally
            {
                rd?.Close();
                command?.Dispose();
                CloseDb();
            }
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



        public int Insert(Cliente paCliente)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
            INSERT INTO Clientes (Nombre, Correo, Dui, Telefono)
            OUTPUT INSERTED.Id_cliente
            VALUES (@nombre, @correo, @dui, @telefono);", Con);

                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paCliente.Nombre;
                command.Parameters.Add("@correo", SqlDbType.NVarChar, 100).Value = paCliente.Correo;
                command.Parameters.Add("@dui", SqlDbType.NVarChar, 20).Value = paCliente.Dui;
                command.Parameters.Add("@telefono", SqlDbType.NVarChar, 20).Value = paCliente.Telefono;

                return (int)command.ExecuteScalar();
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }


        public bool Update(Cliente paCliente)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
            UPDATE Clientes
            SET Nombre = @nombre,
                Correo = @correo,
                Dui = @dui,
                Telefono = @telefono
            WHERE Id_cliente = @id;", Con);

                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paCliente.Nombre;
                command.Parameters.Add("@correo", SqlDbType.NVarChar, 100).Value = paCliente.Correo;
                command.Parameters.Add("@dui", SqlDbType.NVarChar, 20).Value = paCliente.Dui;
                command.Parameters.Add("@telefono", SqlDbType.NVarChar, 20).Value = paCliente.Telefono;
                command.Parameters.Add("@id", SqlDbType.Int).Value = paCliente.IdCliente;

                return command.ExecuteNonQuery() == 1;
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }


      
    }
}
