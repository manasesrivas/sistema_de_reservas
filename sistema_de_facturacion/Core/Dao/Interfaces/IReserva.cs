using sistema_de_reservas.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.Interfaces
{
    internal interface IReserva
    {
        int Insert(Reserva paCliente);
        bool Update(Reserva paCliente);
        bool Delete(int idCliente);
        Reserva GetById(int idCliente);
        List<Reserva> GetAll(string filtro = "");
    }
}
