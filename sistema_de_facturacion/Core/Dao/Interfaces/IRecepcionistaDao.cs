using sistema_de_reservas.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.Interfaces
{
    internal interface IRecepcionistaDao
    {
        int Insert(Recepcionista paRecepcionista);
        bool Update(Recepcionista paRecepcionista);
        bool Delete(int idRecepcionista);
        Recepcionista GetById(int idRecepcionista);
        List<Recepcionista> GetAll(string filtro = "");
    }
}
