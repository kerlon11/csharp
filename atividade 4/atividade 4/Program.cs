using System;

class Program
{
    static void MostrarMenu()
    {
        Console.WriteLine("*********");
        Console.WriteLine("MENU FUNÇÕES DO DIA A DIA");
        Console.WriteLine("*********");
        Console.WriteLine("1 - Saudação");
        Console.WriteLine("2 - Somar dois números");
        Console.WriteLine("3 - Verificar par ou ímpar");
        Console.WriteLine("0 - Sair");
        Console.Write("Escolha uma opção: ");
    }

    static void Saudacao(string nome)
    {
        Console.WriteLine("ola {nome} Seja bem-vindo");
    }

    static double Somar(double a, double b)
    {
        return a + b;
    }

    static void VerificarParOuImpar(int numero)
    {
        if (numero % 2 == 0)
            Console.WriteLine($"{numero} é par.");
        else
            Console.WriteLine($"{numero} é ímpar.");
    }

    static void Main()
    {
        int opcao;

        do
        {
            MostrarMenu();
            opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    Console.Write("Digite seu nome: ");
                    string nome = Console.ReadLine();
                    Saudacao(nome);
                    break;

                case 2:
                    Console.Write("Digite o primeiro número: ");
                    double x = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo número: ");
                    double y = double.Parse(Console.ReadLine());
                    double resultado = Somar(x, y);
                    Console.WriteLine($"Resultado da soma: {resultado}");
                    break;

                case 3:
                    Console.Write("Digite um número inteiro: ");
                    int num = int.Parse(Console.ReadLine());
                    VerificarParOuImpar(num);
                    break;

                case 0:
                    Console.WriteLine("Encerrando.....");
                    break;

                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

        } while (opcao != 0);
    }
}