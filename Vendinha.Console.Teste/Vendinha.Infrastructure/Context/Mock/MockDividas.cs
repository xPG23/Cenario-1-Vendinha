using Vendinha.Domain.Models;

namespace Vendinha.Infrastructure.Context.Mock
{
    public static class MockDividas
    {
        public static List<Divida> Dividas { get; } = CriarDividas();

        private static List<Divida> CriarDividas()
        {
            var clientes = MockClientes.Clientes;

            var dividas = new List<Divida>();

            void Adicionar(int id, int clienteIndex, double valor, int diasAtras)
            {
                var divida = new Divida
                {
                    id = id,
                    Cliente = clientes[clienteIndex],
                    Valor = valor,
                    DataCriacao = DateTime.UtcNow.AddDays(-diasAtras)
                };

                dividas.Add(divida);

                // Também associa a dívida ao cliente.
                clientes[clienteIndex].Dividas.Add(divida);
            }

            // Cliente 0 - João Silva
            Adicionar(1, 0, 150.00, 60);
            Adicionar(2, 0, 320.50, 30);

            // Cliente 1 - Maria Oliveira
            Adicionar(3, 1, 89.90, 15);

            // Cliente 2 - Pedro Santos
            Adicionar(4, 2, 1200.00, 90);
            Adicionar(5, 2, 450.00, 45);

            // Cliente 3 - Ana Costa
            Adicionar(6, 3, 75.50, 10);

            // Cliente 4 - Lucas Pereira
            Adicionar(7, 4, 230.00, 20);

            // Cliente 5 - Juliana Almeida
            Adicionar(8, 5, 560.00, 120);
            Adicionar(9, 5, 180.00, 40);

            // Cliente 6 - Carlos Ferreira
            Adicionar(10, 6, 99.90, 5);

            // Cliente 7 - Beatriz Rodrigues
            Adicionar(11, 7, 340.00, 25);

            // Cliente 8 - Gabriel Martins
            Adicionar(12, 8, 890.00, 70);

            // Cliente 9 - Fernanda Lima
            Adicionar(13, 9, 150.00, 12);
            Adicionar(14, 9, 275.00, 35);

            // Cliente 10 - Rafael Gomes
            Adicionar(15, 10, 420.00, 55);

            // Cliente 11 - Camila Ribeiro
            Adicionar(16, 11, 65.00, 8);

            // Cliente 12 - Bruno Carvalho
            Adicionar(17, 12, 1500.00, 150);

            // Cliente 13 - Amanda Barbosa
            Adicionar(18, 13, 210.00, 18);

            // Cliente 14 - Felipe Rocha
            Adicionar(19, 14, 780.00, 80);

            // Cliente 15 - Larissa Mendes
            Adicionar(20, 15, 110.00, 14);

            // Algumas dívidas pagas.
            dividas[0].Pagar();
            dividas[2].Pagar();
            dividas[5].Pagar();
            dividas[9].Pagar();
            dividas[12].Pagar();
            dividas[17].Pagar();

            return dividas;
        }
    }
}
