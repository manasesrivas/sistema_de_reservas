using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistema_de_reservas.Core.Clases
{
    internal class Reserva
    {
        private int idReserva;
        private string nombreCliente;
        private string nombreSala;
        private DateTime fechaReservado;

        private int salaId;
        private int clienteId;
        private string estado;

        public int IdReserva { get => idReserva; set => idReserva = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string NombreSala { get => nombreSala; set => nombreSala = value;}
        public DateTime FechaReservado { get => fechaReservado; set => fechaReservado = value;}
        public string Estado { get => estado; set => estado = value; }
        public int ClienteId { get => clienteId; set => clienteId = value; }
        public int SalaId { get => salaId; set => salaId = value; }
    }
}
