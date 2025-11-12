using Microsoft.Data.SqlClient;
using sistema_de_rerservas.Core.Lib;
using sistema_de_reservas.Core.Clases;
using sistema_de_reservas.Core.Dao.Interfaces;
using System.Data;

namespace sistema_de_reservas.Core.Dao.ClasesDao
{
    internal class RecursoDao: Cnn, IRecursoDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idRecurso)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Recursos WHERE Id_recursos = @id_recurso;", Con);
                command.Parameters.Add("@id_recurso", SqlDbType.Int).Value = idRecurso;
                return command.ExecuteNonQuery() == 1;
            }
            catch (SqlException ex) when (ex.Number == 547)
            {
                throw new ApplicationException("No se puede eliminar el recurso. "+ex.Message);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public List<Recurso> GetAll(string filtro = "")
        {
            var lista = new List<Recurso>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"SELECT Id_recursos, Nombre, Tipo, Costo, Cantidad FROM Recursos";

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

        private static Recurso Map(SqlDataReader rd)
        {
            return new Recurso
            {
                IdRecurso = rd.GetInt32(0),
                Nombre = rd.GetString(1),
                Tipo = rd.GetString(2),
                Costo = rd.GetDecimal(3),
                Cantidad = rd.GetInt32(4)
            };

        }

        public Recurso? GetById(int idRecurso)
        {
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    SELECT Id_Recursos, Nombre, Tipo, Costo , Cantidad
                    FROM Recursos
                    WHERE Id_Recursos = @idRecurso;", Con);

                command.Parameters.Add("@idRecurso", SqlDbType.Int).Value = idRecurso;
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

        public int Insert(Recurso paRecurso)
        {
            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    INSERT INTO Recursos (Nombre, Tipo, Costo, Cantidad)
                    OUTPUT INSERTED.Id_recursos
                    VALUES (@nombre, @tipo, @costo, @cantidad);
                    SELECT SCOPE_IDENTITY();", Con);

                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paRecurso.Nombre;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = paRecurso.Tipo;
                command.Parameters.Add("@costo", SqlDbType.Decimal, 10).Value = paRecurso.Costo;
                command.Parameters.Add("@cantidad", SqlDbType.Decimal, 10).Value = paRecurso.Cantidad;

                var id = command.ExecuteScalar();
                return Convert.ToInt32(id);

            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("El DUI ya existe, verifica la informacion. ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public bool Update(Recurso paRecurso)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
                    UPDATE Recursos
                    SET Nombre = @nombre,
                        Tipo = @tipo,
                        Costo = @costo,
                        Cantidad = @cantidad
                    WHERE Id_recursos = @id_recurso;", Con);
                command.Parameters.Add("@id_recurso", SqlDbType.Int).Value = paRecurso.IdRecurso;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paRecurso.Nombre;
                command.Parameters.Add("@tipo", SqlDbType.NVarChar, 100).Value = paRecurso.Tipo;
                command.Parameters.Add("@costo", SqlDbType.Decimal, 10).Value = paRecurso.Costo;
                command.Parameters.Add("@cantidad", SqlDbType.Decimal, 10).Value = paRecurso.Cantidad;

                var filasAfectadas = command.ExecuteNonQuery();
                return filasAfectadas == 1;
            }
            catch (SqlException ex) when (ex.Number == 2627 || ex.Number == 2601)
            {
                throw new ApplicationException("El DUI ya existe, verifica la informacion. ", ex);
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }

        }

    }
}

