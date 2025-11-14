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
    internal class RecepcionistaDao : Cnn, IRecepcionistaDao
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idRecepcionista)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"DELETE FROM Usuarios WHERE Id_usuario = @id_recepcionista;", Con);
                command.Parameters.Add("@id_recepcionista", SqlDbType.Int).Value = idRecepcionista;
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

        public List<Recepcionista> GetAll(string filtro = "")
        {
            var lista = new List<Recepcionista>();
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

        private static Recepcionista Map(SqlDataReader rd)
        {
            return new Recepcionista
            {
                IdRecepcionista = rd.GetInt32(0),
                Nombre = rd.GetString(1),
                Correo = rd.GetString(2),
                Dui = rd.GetString(3),
                Telefono = rd.GetString(4)
            };

        }
        public Recepcionista GetById(int idRecepcionista)
        {
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    SELECT Id_usuario, Nombre, Correo, Dui, Telefono, Password
                    FROM Usuarios
                    WHERE Id_usuario = @idRecepcionista;", Con);

                command.Parameters.Add("@idRecepcionista", SqlDbType.Int).Value = idRecepcionista;
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

        public int Insert(Recepcionista paRecepcionista)
        {
            try
            {
                Con = OpenDb();

                command = new SqlCommand(@"
                    INSERT INTO Usuarios (Nombre, Correo, Dui, Telefono, Password, Rol)
                    OUTPUT INSERTED.Id_usuario
                    VALUES (@nombre, @Correo, @Dui, @telefono, @password, @rol);
                    SELECT SCOPE_IDENTITY();", Con);

                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = paRecepcionista.IdRecepcionista;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paRecepcionista.Nombre;
                command.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = paRecepcionista.Correo;
                command.Parameters.Add("@dui", SqlDbType.VarChar, 20).Value = paRecepcionista.Dui;
                command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = paRecepcionista.Telefono;
                command.Parameters.Add("@password", SqlDbType.NVarChar, 100).Value = paRecepcionista.Password;
                command.Parameters.Add("@rol", SqlDbType.VarChar).Value = "Recepcionista";

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

        public bool Update(Recepcionista paRecepcionista)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
                    UPDATE Usuarios
                    SET Nombre = @nombre,
                        Correo = @correo,
                        Dui = @dui,
                        Telefono = @telefono,
                        Password = @password,
                        Rol = @rol
                    WHERE Id_usuario = @id_usuario;", Con);

                command.Parameters.Add("@id_usuario", SqlDbType.Int).Value = paRecepcionista.IdRecepcionista;
                command.Parameters.Add("@nombre", SqlDbType.NVarChar, 100).Value = paRecepcionista.Nombre;
                command.Parameters.Add("@correo", SqlDbType.VarChar, 100).Value = paRecepcionista.Correo;
                command.Parameters.Add("@dui", SqlDbType.VarChar, 20).Value = paRecepcionista.Dui;
                command.Parameters.Add("@telefono", SqlDbType.VarChar, 10).Value = paRecepcionista.Telefono;
                command.Parameters.Add("@password", SqlDbType.NVarChar, 200).Value = paRecepcionista.Password;
                command.Parameters.Add("@rol", SqlDbType.VarChar).Value = "Recepcionista";

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
