using System;

class ContadorPersonalizado
{
    static void Main()
    {
        Console.WriteLine("======================");
        Console.WriteLine("Contador Personalizado");
        Console.WriteLine("======================");


        Console.Write("Digite o número inicial: ");
        int inicio = int.Parse(Console.ReadLine());

        Console.Write("Digite o número final: ");
        int fim = int.Parse(Console.ReadLine());

        Console.WriteLine("Números pares entre {0} e {1}:", inicio, fim);


        if (inicio <= fim)
        {
            for (int i = inicio; i <= fim; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        else
        {
            for (int i = inicio; i >= fim; i--)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        Console.WriteLine("Fim");
    }
}