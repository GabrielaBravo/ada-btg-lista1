internal class Program
{
    private static void Main(string[] args)
    {
        string logo = ($"-----------------------------------------{Environment.NewLine}-------- Calculadora de Imposto ---------{Environment.NewLine}-----------------------------------------");
        Console.WriteLine(logo);

        double valorItem;

        while (true)
        {
            Console.WriteLine("Por Favor, digite o valor do item para calcular o valor final (ou 'sair' para sair): ");
            string valor = Console.ReadLine();

            if (valor.ToLower() == "sair")
            {
                break;
            }

            if (double.TryParse(valor, out valorItem) && valorItem > 0)
            {
                if (valorItem > 1200 && valorItem <= 2500)
                {
                    var valorFinal = valorItem * 1.1;
                    Console.WriteLine($"O valor final é R${valorFinal:F2}");
                }
                else if (valorItem > 2500 && valorItem <= 5000)
                {
                    var valorFinal = valorItem * 1.15;
                    Console.WriteLine($"O valor final é R${valorFinal:F2}");
                }
                else if (valorItem > 5000)
                {
                    var valorFinal = valorItem * 1.2;
                    Console.WriteLine($"O valor final é R${valorFinal:F2}");
                }
                else
                {
                    Console.WriteLine($"O valor final é R${valorItem:F2}");
                }
            }
            else
            {
                Console.WriteLine("Valor inválido. Digite um número positivo.");
            }

            Console.WriteLine($"{Environment.NewLine}Pressione qualquer tecla para continuar...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(logo);
        }

        Console.WriteLine($"{Environment.NewLine}OK! Você saiu da calculadora.");
        Console.ReadKey();
    }
}
