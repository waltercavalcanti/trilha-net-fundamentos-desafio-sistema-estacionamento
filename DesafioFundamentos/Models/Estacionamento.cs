namespace DesafioFundamentos.Models;

public class Estacionamento
{
    private decimal precoInicial = 0;
    private decimal precoPorHora = 0;
    private List<Veiculo> veiculos = new List<Veiculo>();

    public Estacionamento(decimal precoInicial, decimal precoPorHora)
    {
        this.precoInicial = precoInicial;
        this.precoPorHora = precoPorHora;
    }

    public void AdicionarVeiculo()
    {
        // TODO: Pedir para o usuário digitar uma placa (ReadLine) e adicionar na lista "veiculos"
        Console.Write("Digite a placa do veículo para estacionar: ");

        string placa = Console.ReadLine();

        // Verifica se o veículo já está estacionado
        if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
        {
            Console.WriteLine("Desculpe, esse veículo já está estacionado.");
        }
        else
        {
            Veiculo veiculo = new Veiculo();
            veiculo.Placa = placa;

            veiculos.Add(veiculo);

            Console.WriteLine($"O veículo {placa} foi estacionado com sucesso!");
        }
    }

    public void RemoverVeiculo()
    {
        Console.Write("Digite a placa do veículo para remover: ");

        // Pedir para o usuário digitar a placa e armazenar na variável placa
        string placa = Console.ReadLine();

        // Verifica se o veículo existe
        if (veiculos.Any(x => x.Placa.ToUpper() == placa.ToUpper()))
        {
            Console.Write("Digite a quantidade de horas que o veículo permaneceu estacionado: ");

            // TODO: Pedir para o usuário digitar a quantidade de horas que o veículo permaneceu estacionado,
            // TODO: Realizar o seguinte cálculo: "precoInicial + precoPorHora * horas" para a variável valorTotal                
            int horas = Convert.ToInt32(Console.ReadLine());
            decimal valorTotal = precoInicial + (precoPorHora * horas);

            // TODO: Remover a placa digitada da lista de veículos
            veiculos.Remove(veiculos.FirstOrDefault(x => x.Placa.ToUpper() == placa.ToUpper()));

            Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
        }
        else
        {
            Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
        }
    }

    public void ListarVeiculos()
    {
        // Verifica se há veículos no estacionamento
        if (veiculos.Any())
        {
            Console.WriteLine("Os veículos estacionados são:");

            foreach (var veiculo in veiculos)
            {
                Console.WriteLine($"Placa: {veiculo.Placa}");
            }
        }
        else
        {
            Console.WriteLine("Não há veículos estacionados.");
        }
    }
}