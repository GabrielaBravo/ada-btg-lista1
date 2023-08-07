internal class Program
{
    private static void Main(string[] args)
    {
        const int tamanhoVetor = 100;
        int[] vetorNumerosInteiros = new int[tamanhoVetor];
        Random random = new Random();

        for (int i = 0; i < tamanhoVetor; i++)
        {
            vetorNumerosInteiros[i] = random.Next(1, 1000);
        }

        int maiorValor = vetorNumerosInteiros.Max();
        int posicaoMaiorValor = Array.IndexOf(vetorNumerosInteiros, maiorValor);

        int menorValor = vetorNumerosInteiros.Min();
        int posicaoMenorValor = Array.IndexOf(vetorNumerosInteiros, menorValor);

        Console.WriteLine($"Vetor de 100 números aleatórios:{Environment.NewLine}");
        Console.WriteLine(string.Join(",", vetorNumerosInteiros));

        Console.WriteLine($"{Environment.NewLine}Maior valor: {maiorValor}, posição: {posicaoMaiorValor}");
        Console.WriteLine($"Menor valor: {menorValor}, posição: {posicaoMenorValor}");

        Console.ReadKey();
    }
}
