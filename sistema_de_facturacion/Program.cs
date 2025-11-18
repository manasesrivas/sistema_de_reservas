using sistema_de_reservas.formularios;
using sistema_de_reservas.formularios.Reservaciones;

namespace sistema_de_reservas
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new FormDashboardAdmin(1));
        }
    }
}