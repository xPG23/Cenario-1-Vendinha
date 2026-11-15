using Vendinha.Application.Services;
using Vendinha.Infrastructure.Context;
using Vendinha.Infrastructure.Repository.PostgreSQL;
using Vendinha.Presentation.Desk.Screens;

namespace Vendinha.Presentation.Desk
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var context = new VendinhaDbContext();

            var clienteRepository = new ClienteRepository(context);
            var dividaRepository = new DividaRepository(context);

            var clienteService = new ClienteService(clienteRepository);

            var dividasService = new DividasService(
                clienteRepository,
                dividaRepository
            );

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            System.Windows.Forms.Application.Run(new TelaInicial(clienteService, dividasService));
        }
    }
}