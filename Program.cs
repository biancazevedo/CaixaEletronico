//Projeto CaixaEletronico
//Grupo: Bianca Azevedo, Matheus Brayan Fellizardo


using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        string resposta;

        do
        {
            Console.Clear();
            Console.WriteLine("--- Caixa Eletrônico ---");
            Console.Write("Digite o valor a ser sacado...: ");

            string entrada = Console.ReadLine()!;
            decimal valorDecimal;

            if (!decimal.TryParse(entrada, NumberStyles.Number, new CultureInfo("pt-BR"), out valorDecimal) || valorDecimal <= 0)
            {
                Console.WriteLine("Valor inválido! Digite um número positivo.");
            }
            else if (valorDecimal % 1 != 0)
            {
                Console.WriteLine("Não são permitidos centavos. Digite um valor inteiro, como 50 ou 100.");
            }
            else
            {
                int valor = (int)valorDecimal;
                Console.WriteLine("\nO caixa deve entregar:");

                int nota;

                if (valor >= 200)
                {
                    nota = valor / 200;
                    Console.WriteLine($"{nota} nota(s) de R$200,00");
                    valor %= 200;
                }
                if (valor >= 100)
                {
                    nota = valor / 100;
                    Console.WriteLine($"{nota} nota(s) de R$100,00");
                    valor %= 100;
                }
                if (valor >= 50)
                {
                    nota = valor / 50;
                    Console.WriteLine($"{nota} nota(s) de R$50,00");
                    valor %= 50;
                }
                if (valor >= 20)
                {
                    nota = valor / 20;
                    Console.WriteLine($"{nota} nota(s) de R$20,00");
                    valor %= 20;
                }
                if (valor >= 10)
                {
                    nota = valor / 10;
                    Console.WriteLine($"{nota} nota(s) de R$10,00");
                    valor %= 10;
                }
                if (valor >= 5)
                {
                    nota = valor / 5;
                    Console.WriteLine($"{nota} nota(s) de R$5,00");
                    valor %= 5;
                }
                if (valor >= 2)
                {
                    nota = valor / 2;
                    Console.WriteLine($"{nota} nota(s) de R$2,00");
                    valor %= 2;
                }
                if (valor >= 1)
                {
                    nota = valor / 1;
                    Console.WriteLine($"{nota} nota(s) de R$1,00");
                }
            }

            Console.Write("\nDeseja realizar outro saque? (s/n): ");
            resposta = Console.ReadLine()!.ToLower();

        } while (resposta == "s");

        Console.WriteLine("Encerrando o programa...");
    }
}


