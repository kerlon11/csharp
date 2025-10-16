using System;

namespace CalculadoraCompleta
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculadora calc = new Calculadora();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine(" CALCULADORA EM C#");
                Console.WriteLine("1 - Soma");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Multiplicação");
                Console.WriteLine("4 - Divisão");
                Console.WriteLine("5 - Potenciação");
                Console.WriteLine("0 - Sair");
                Console.Write("\nEscolha uma opção: ");
                string opcao = Console.ReadLine();

                if (opcao == "0")
                {
                    continuar = false;
                    Console.WriteLine("Obrigado por usar a calculadora!");
                    break;
                }

                try
                {
                    Console.Write("\nDigite o primeiro número: ");
                    double num1 = Convert.ToDouble(Console.ReadLine());

                    Console.Write("Digite o segundo número: ");
                    double num2 = Convert.ToDouble(Console.ReadLine());

                    double resultado = 0;

                    switch (opcao)
                    {
                        case "1":
                            resultado = calc.Somar(num1, num2);
                            Console.WriteLine($"\nResultado: {resultado}");
                            break;

                        case "2":
                            resultado = calc.Subtrair(num1, num2);
                            Console.WriteLine($"\nResultado: {resultado}");
                            break;

                        case "3":
                            resultado = calc.Multiplicar(num1, num2);
                            Console.WriteLine($"\nResultado: {resultado}");
                            break;

                        case "4":
                            resultado = calc.Dividir(num1, num2);
                            Console.WriteLine($"\nResultado: {resultado}");
                            break;

                        case "5":
                            resultado = calc.Potenciar(num1, num2);
                            Console.WriteLine($"\nResultado: {resultado}");
                            break;

                        default:
                            Console.WriteLine("\nOpção inválida! Tente novamente.");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"\nErro: {ex.Message}");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    public class Calculadora
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            if (b == 0)
                throw new Exception("Não é possível dividir por zero.");
            return a / b;
        }

        public double Potenciar(double baseNum, double expoente)
        {
            if (expoente == 0)
                return 1;

            double resultado = 1;


            if (expoente > 0)
            {
                for (int i = 0; i < (int)expoente; i++)
                {
                    resultado *= baseNum;
                }
            }
            else
            {
                for (int i = 0; i < (int)(-expoente); i++)
                {
                    resultado *= baseNum;
                }
                resultado = 1 / resultado;
            }

            return resultado;
        }
    }
}