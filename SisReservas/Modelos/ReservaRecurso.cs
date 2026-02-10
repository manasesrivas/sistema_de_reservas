using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SisReservas.Modelos
{
    public class ReservaRecurso
    {
        public int Id { get; set; }
        public int ReservaId { get; set; }
        public int RecursoId { get; set; }
    }
}

