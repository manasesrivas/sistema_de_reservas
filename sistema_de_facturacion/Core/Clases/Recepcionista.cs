using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Clases
{
    internal class Recepcionista
    {
        private int id_recepcionista;
        private string nombre;
        private string correo;
        private string dui;
        private string telefono;
        private string password;

        public int IdRecepcionista { get => id_recepcionista; set => id_recepcionista = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Dui { get => dui; set => dui = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Password { get => password; set => password = value; }
    }
}
