using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SisReservas.Modelos
{
    public class Reserva
    {
        public int Id { get; set; }
        public int SalaId { get; set; }
        public int ClienteId { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaFin { get; set; }
        public string Tipo { get; set; }
        public string Estado { get; set; }

        public override string ToString()
        {
            return Tipo + " del " + FechaInicio.ToShortDateString() + " al " + FechaFin.ToShortDateString();
        }
    }
}

