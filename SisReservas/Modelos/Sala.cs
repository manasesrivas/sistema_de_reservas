using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisReservas.Modelos
{
    public class Sala
    {
        public int Id_salas { get; set; }
        public string Nombre { get; set; }
        public int Capacidad { get; set; }
        public bool Disponible { get; set; }

        public override string ToString()
        {
            return Nombre + " - Capacidad: " + Capacidad;
        }
    }
}
