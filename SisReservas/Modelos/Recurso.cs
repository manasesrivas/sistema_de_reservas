using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisReservas.Modelos
{
    public class Recurso
    {
        public int Id_recursos { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public decimal Costo { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({Tipo}) - ${Costo}";
        }
    }
}
