using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisReservas.Modelos
{
    public class Cliente
    {
        public int Id_cliente { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public string Dui { get; set; }

        public override string ToString()
        {
            return Nombre + " (" + Correo + ")";
        }
    }
}

