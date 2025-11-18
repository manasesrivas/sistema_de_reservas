using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Clases
{
    internal class Sala
    {
        private int idSalas;

        private string nombre;

        private int capacidad;

        private int disponible;

        private decimal precio;

        public int IdSalas { get => idSalas; set => idSalas = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public int Capacidad { get => capacidad; set => capacidad = value; }
        public int Disponible { get => disponible; set => disponible = value; }
        public decimal Precio { get => precio; set => precio = value; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
