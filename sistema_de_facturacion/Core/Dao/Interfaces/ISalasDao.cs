using sistema_de_reservas.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.Interfaces
{
    internal interface ISalasDao
    {
        int Insert(Sala paSala);
        bool Update(Sala paSala);
        bool Delete(int idSalas);
        Sala GetById(int idSalas);
        List<Sala> GetAll(string filtro = "");
    }
}
