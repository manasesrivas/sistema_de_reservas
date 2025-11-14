using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Clases
{
    internal class Recurso
    {
        private int idRecurso;
        private string nombre;
        private string tipo;
        private decimal costo;
        private int cantidad;

        public int IdRecurso { get => idRecurso; set => idRecurso = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public decimal Costo { get => costo; set => costo = value; }
        public int Cantidad {  get => cantidad; set => cantidad = value; }

        public static implicit operator Recurso(Recepcionista v)
        {
            throw new NotImplementedException();
        }
    }
}
