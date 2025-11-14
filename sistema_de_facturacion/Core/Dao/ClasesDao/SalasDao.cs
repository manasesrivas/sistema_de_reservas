using Microsoft.Data.SqlClient;
using sistema_de_rerservas.Core.Lib;
using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace sistema_de_reservas.Core.Dao.ClasesDao
{
    internal class SalasDao : Cnn, ISalasDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idSala)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Salas WHERE Id_salas = @id_salas;", Con);
                command.Parameters.Add("@id_salas", SqlDbType.Int).Value = idSala;
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

        public Sala? GetById(int idSalas)
        {
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    SELECT Id_Salas, Nombre, Capacidad, Disponible
                    FROM Salas
                    WHERE Id_Salas = @idSalas;", Con);

                command.Parameters.Add("@idSalas", SqlDbType.Int).Value = idSalas;
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


       


        public bool Update(Sala paSala)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
                    UPDATE Salas
                    SET Nombre = @nombre,
                        Capacidad = @capacidad,
                        Disponible = @disponible                  
                    WHERE Id_salas = @id_salas;", Con);
                command.Parameters.Add("@id_salas", SqlDbType.Int).Value = paSala.IdSalas;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paSala.Nombre;
                command.Parameters.Add("@capacidad", SqlDbType.NVarChar, 100).Value = paSala.Capacidad;
                command.Parameters.Add("@disponible", SqlDbType.Decimal, 10).Value = paSala.Disponible;
           
                var filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("Ya existe, verifica la informacion. ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }

        }

        public List<Sala> GetAll(string filtro = "")
        {
            var lista = new List<Sala>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"SELECT Id_Salas, Nombre, Capacidad, Disponible FROM Salas";

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

        private static Sala Map(SqlDataReader rd)
        {
            return new Sala
            {
                IdSalas = rd.GetInt32(0),
                Nombre = rd.GetString(1),
                Capacidad = rd.GetInt32(2),
                Disponible = rd.GetBoolean(3) ? 1 : 0
            };
        }



        public int Insert(Sala paSala)
        {
            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
            INSERT INTO Salas (Nombre, Capacidad, Disponible)
            OUTPUT INSERTED.Id_Salas
            VALUES (@nombre, @capacidad, @disponible);", Con);

                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paSala.Nombre;
                command.Parameters.Add("@capacidad", SqlDbType.Int).Value = paSala.Capacidad;
                command.Parameters.Add("@disponible", SqlDbType.Bit).Value = paSala.Disponible;

                var id = command.ExecuteScalar();
                return Convert.ToInt32(id);
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("Ya existe, verifica la información.", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

    }
}
