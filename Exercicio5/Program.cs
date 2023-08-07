internal class Program
{
    private static void Main(string[] args)
    {
        int[] quantidadeCombustivel = new int[4];
        int quantidadeCliente = 0;
        string logo = ($"-----------------------------------------{Environment.NewLine}-------- Posto ADA | BTG ----------------{Environment.NewLine}-------- Tipos de Combustiveis ----------{Environment.NewLine}-------- 1. Alcool ----------------------{Environment.NewLine}-------- 2. Gasolina --------------------{Environment.NewLine}-------- 3. Diesel ----------------------{Environment.NewLine}-------- 4. Sair ------------------------{Environment.NewLine}-----------------------------------------{Environment.NewLine}");
        Console.WriteLine(logo);

        int codigoCombustivel = 0;

        while (codigoCombustivel != 4)
        {
            Console.WriteLine("Digite o código do combustível por cliente, conforme os dados acima:");
            codigoCombustivel = int.Parse(Console.ReadLine());

            if (codigoCombustivel >= 1 && codigoCombustivel <= 3)
            {
                quantidadeCliente++;
                quantidadeCombustivel[codigoCombustivel - 1]++;
            }
            else if (codigoCombustivel != 4)
            {
                Console.Write("Código inválido! ");
            }
        }

        Console.Clear();
        Console.WriteLine(logo);
        Console.WriteLine("MUITO OBRIGADO!");
        Console.WriteLine($"Quantidade de clientes que abasteceram com:");
        Console.WriteLine($"Álcool: {quantidadeCombustivel[0]}");
        Console.WriteLine($"Gasolina: {quantidadeCombustivel[1]}");
        Console.WriteLine($"Diesel: {quantidadeCombustivel[2]}");
        Console.ReadKey();
    }
}
