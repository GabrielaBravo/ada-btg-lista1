internal class Program
{
    private static void Main(string[] args)
    {
        int quantidadeAtual, quantidadeMaxima, quantidadeMinima;

        string logo = ($"------------------------------------------{Environment.NewLine}---------- Controle de Estoque -----------{Environment.NewLine}------------------------------------------");
        Console.WriteLine(logo);

        do
        {
            Console.Write("Digite a quantidade atual em estoque: ");
        } while (!int.TryParse(Console.ReadLine(), out quantidadeAtual) || quantidadeAtual < 0);

        do
        {
            Console.Write($"{Environment.NewLine}Digite a quantidade máxima em estoque: ");
        } while (!int.TryParse(Console.ReadLine(), out quantidadeMaxima) || quantidadeMaxima < 0);

        do
        {
            Console.Write($"{Environment.NewLine}Digite a quantidade mínima em estoque: ");
        } while (!int.TryParse(Console.ReadLine(), out quantidadeMinima) || quantidadeMinima < 0);

        int quantidadeMedia = (quantidadeMaxima + quantidadeMinima) / 2;

        if (quantidadeAtual >= quantidadeMedia)
        {
            Console.WriteLine($"{Environment.NewLine}Não efetuar compra");
        }
        else
        {
            Console.WriteLine($"{Environment.NewLine}Efetuar compra");
        }

        Console.WriteLine($"{Environment.NewLine}Consulta finalizada.");
        Console.ReadKey();
    }
}

