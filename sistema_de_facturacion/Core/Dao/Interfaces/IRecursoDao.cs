using sistema_de_reservas.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.Interfaces
{
    internal interface IRecursoDao
    {
        int Insert(Recurso PaRecurso);
        bool Update(Recurso paRecurso);
        bool Delete(int idRecurso);
        Recurso GetById(int idRecurso);
        List<Recurso> GetAll(string filtro = "");
    }
}
