using sistema_de_reservas.Core.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Dao.Interfaces
{
    internal interface IClienteDao
    {
        int Insert(Cliente paCliente);
        bool Update(Cliente paCliente);
        bool Delete(int idCliente);
        Cliente GetById(int idCliente);
        List<Cliente> GetAll(string filtro = "");
    }
}
