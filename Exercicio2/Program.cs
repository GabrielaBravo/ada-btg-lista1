using System.Globalization;

internal class Program
{
    static void Main(string[] args)
    {
        string logo = ($"-----------------------------------------{Environment.NewLine}-------- Calculadora de Salario ---------{Environment.NewLine}-----------------------------------------");
        Console.WriteLine(logo);

        const int cargaHorariaMensal = 160;

        Console.WriteLine("Por favor, Digite o nome do(a) funcionário(a):");
        string nomeFuncionario = Console.ReadLine();
        Console.WriteLine("Qual o seu salário por hora?");
        double salarioPorHora = double.Parse(Console.ReadLine());
        Console.WriteLine("Quantas horas inteiras o funcionário trabalhou esse mês?");
        int horasTrabalhadas = int.Parse(Console.ReadLine());

        Console.Clear();

        double horaExtra = horasTrabalhadas > cargaHorariaMensal ? ((horasTrabalhadas - cargaHorariaMensal) * 1.5) * salarioPorHora : 0;
        double salarioBase = cargaHorariaMensal * salarioPorHora;
        double salarioTotal = salarioBase + horaExtra;

        Console.WriteLine(logo);
        Console.WriteLine($"O salário Total de {nomeFuncionario} é {FormatCurrency(salarioTotal)}.");

        if (horasTrabalhadas > cargaHorariaMensal)
        {
            Console.WriteLine($"Salário Base é: {FormatCurrency(salarioBase)}.");
            Console.WriteLine($"Valor de hora extra: {FormatCurrency(horaExtra)}");
        }
        else if (horasTrabalhadas < cargaHorariaMensal)
        {
            int bancoDeHoras = horasTrabalhadas - cargaHorariaMensal;
            Console.WriteLine($"Seu banco de horas é: {bancoDeHoras}.");
        }

        Console.ReadKey();
    }

    static string FormatCurrency(double value)
    {
        CultureInfo culture = new CultureInfo("pt-BR");
        return value.ToString("C", culture);
    }
}
