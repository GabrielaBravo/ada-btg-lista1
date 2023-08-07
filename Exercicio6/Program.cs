internal class Program
{
    private static void Main(string[] args)
    {
        string logo = ($"-----------------------------------------{Environment.NewLine}------------ Vamos Jogar? ---------------{Environment.NewLine}-----------------------------------------");
        Console.WriteLine(logo);
        Console.WriteLine("Digite um número inteiro, e este valor será a quantidade de valores inteiros que serão lidos em seguida:");
        int valorN = int.Parse(Console.ReadLine());

        int dentroIntervalo = 0;
        int foraIntervalo = 0;

        for (int i = 0; i < valorN; i++)
        {
            Console.WriteLine($"Digite o {i + 1}º valor inteiro:");
            int X = int.Parse(Console.ReadLine());

            if (X >= 10 && X <= 20)
            {
                dentroIntervalo++;
            }
            else
            {
                foraIntervalo++;
            }
        }

        Console.Clear();
        Console.WriteLine(logo);
        Console.WriteLine($"Resultado dos numeros dentro(in) e fora(out) do intervalo [10,20] :{Environment.NewLine}");
        Console.WriteLine($"{dentroIntervalo} in");
        Console.WriteLine($"{foraIntervalo} out");

        Console.ReadKey();
    }
}
