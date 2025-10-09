using System;

class Program
{
    static void Main()
    {
        int opcao;
        double a, b;

        while (true)
        {
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("0 - Sair");
            Console.Write("Escolha uma opção: ");
            opcao = int.Parse(Console.ReadLine());

            if (opcao == 0)
                break;

            if (opcao < 1 || opcao > 4)
            {
                Console.WriteLine("Opção inválida");
                continue;
            }

            Console.Write("Digite o primeiro número:");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo número:");
            b = double.Parse(Console.ReadLine());

            if (opcao == 1)
                Console.WriteLine("Resultado: " + (a + b));
            else if (opcao == 2)
                Console.WriteLine("Resultado: " + (a - b));
            else if (opcao == 3)
                Console.WriteLine("Resultado: " + (a * b));
            else if (opcao == 4)
            {
                if (b == 0)
                    Console.WriteLine("ERRO: divisão por zero!");
                else
                    Console.WriteLine("Resultado: " + (a / b));
            }
        }

        Console.WriteLine("saindo.");
    }
}