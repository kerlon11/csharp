using System;

namespace Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a operação que deseja realizar:");
            Console.WriteLine("1  Adição");
            Console.WriteLine("2  Subtração");
            Console.WriteLine("3  Multiplicação");
            Console.WriteLine("4  Divisão");

            int opcao = int.Parse(Console.ReadLine());

            Console.WriteLine(" primeiro número:");
            int numero1 = int.Parse(Console.ReadLine());

            Console.WriteLine(" segundo número:");
            int numero2 = int.Parse(Console.ReadLine());

            int resultado = 0;

            switch (opcao)
            {
                case 1:
                    resultado = Somar(numero1, numero2);
                    break;

                case 2:
                    resultado = Subtrair(numero1, numero2);
                    break;

                case 3:
                    resultado = Multiplicar(numero1, numero2);
                    break;

                case 4:
                    resultado = Dividir(numero1, numero2);
                    break;

                default:
                    Console.WriteLine("Opção inválida, por favor escolha uma operação válida.");
                    return;
            }

            Console.WriteLine($"O resultado é: {resultado}");
            Console.ReadLine();
        }

        public static int Somar(int a, int b)
        {
            return a + b;
        }

        public static int Subtrair(int a, int b)
        {
            return a - b;
        }

        public static int Multiplicar(int a, int b)
        {
            return a * b;
        }

        public static int Dividir(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Erro: Não é possível dividir por zero.");
                return 0;
            }
            return a / b;
        }
    }
}
