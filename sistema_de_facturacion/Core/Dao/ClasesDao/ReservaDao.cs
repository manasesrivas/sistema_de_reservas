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
    internal class ReservaDao : Cnn, IReserva
    {
        SqlConnection Con = null;
        SqlCommand command = null;
        public bool Delete(int idCliente)
        {
            throw new NotImplementedException();
        }
        public List<Reserva> GetAll(string filtro = "")
        {
            var lista = new List<Reserva>();
            SqlDataReader rd = null;

            try
            {
                Con = OpenDb();
                string sql = @"SELECT 
                                    r.Id_reserva,
                                    c.Nombre AS NombreCliente,
                                    s.Nombre AS NombreSala,
                                    r.FechaReservado AS FechaReservado
                                FROM Reservas r
                                INNER JOIN Clientes c ON r.ClienteId = c.Id_cliente
                                INNER JOIN Salas s ON r.SalaId = s.Id_sala;
";

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

        private static Reserva Map(SqlDataReader rd)
        {
            return new Reserva
            {
                IdReserva = rd.GetInt32(0),
                NombreCliente = rd.GetString(1),
                NombreSala = rd.GetString(2),
                FechaReservado = rd.GetDateTime(3)
            };

        }
        

        public Reserva GetById(int idCliente)
        {
            throw new NotImplementedException();
        }

        public int Insert(Reserva paReserva)
        {
            try
            {
                Con = OpenDb();
                command = new SqlCommand(@"
            INSERT INTO Reservas (salaId, clienteId, FechaReservado, Estado)
            OUTPUT INSERTED.Id_reserva
            VALUES (@salaid, @clienteid, @fechareservado, @estado);", Con);

                command.Parameters.Add("@salaid", SqlDbType.NVarChar, 100).Value = paReserva.SalaId;
                command.Parameters.Add("@clienteid", SqlDbType.NVarChar, 100).Value = paReserva.ClienteId;
                command.Parameters.Add("@fechareservado", SqlDbType.NVarChar, 20).Value = paReserva.FechaReservado;
                command.Parameters.Add("@estado", SqlDbType.NVarChar, 20).Value = paReserva.Estado;

                return (int)command.ExecuteScalar();
            }
            finally
            {
                command?.Dispose();
                CloseDb();
            }
        }

        public bool Update(Reserva paCliente)
        {
            throw new NotImplementedException();
        }
    }
}
