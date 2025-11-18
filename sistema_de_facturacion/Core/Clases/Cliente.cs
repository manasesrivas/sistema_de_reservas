using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Clases
{
    internal class Cliente
    {
        private int idCliente;
        private string nombre;
        private string correo;
        private string telefono;
        private string dui;

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Correo { get => correo; set => correo = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public string Dui { get => dui; set => dui = value; }

        public override string ToString()
        {
            return $"{dui} - {nombre}";
        }
    }
}
