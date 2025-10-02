using System;
using System.Globalization;

class CalculadoraSimples
{
    static void Main()
    {
        int totalOperacoes = 0;
        int totalErros = 0;
        string continuar;

        Console.Clear();
        Console.WriteLine("Bem-vindo à Calculadora Simples!");
        Console.WriteLine("Data e hora atuais: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

        do
        {
            Console.WriteLine("\nEscolha uma operação:");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Multiplicação");
            Console.WriteLine("4 - Divisão");
            Console.WriteLine("5 - Módulo");
            Console.WriteLine("6 - Sair");

            Console.Write("Digite sua opção (1 a 6 ou por extenso): ");
            string entrada = Console.ReadLine();
            int opcao = ConverterOpcao(entrada);

            if (opcao < 1 || opcao > 6)
            {
                Console.WriteLine(" Opção inválida!");
                totalErros++;
                continuar = PerguntarSeContinua();
                continue;
            }

            if (opcao == 6)
                break;

            string nomeOperacao = opcao switch
            {
                1 => "Soma",
                2 => "Subtração",
                3 => "Multiplicação",
                4 => "Divisão",
                5 => "Módulo",
                _ => "Desconhecida"
            };

            Console.WriteLine($"Você escolheu: {nomeOperacao}");

            Console.Write("Digite o primeiro número: ");
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double num1))
            {
                Console.WriteLine("❌ Entrada inválida para o primeiro número!");
                totalErros++;
                continuar = PerguntarSeContinua();
                continue;
            }

            Console.Write("Digite o segundo número: ");
            if (!double.TryParse(Console.ReadLine(), NumberStyles.Float, CultureInfo.InvariantCulture, out double num2))
            {
                Console.WriteLine("❌ Entrada inválida para o segundo número!");
                totalErros++;
                continuar = PerguntarSeContinua();
                continue;
            }

            double resultado = 0;
            bool operacaoValida = true;

            switch (opcao)
            {
                case 1:
                    resultado = num1 + num2;
                    break;
                case 2:
                    resultado = num1 - num2;
                    break;
                case 3:
                    resultado = num1 * num2;
                    break;
                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine(" Divisão por zero não é permitida.");
                        totalErros++;
                        operacaoValida = false;
                    }
                    else
                    {
                        resultado = num1 / num2;
                    }
                    break;
                case 5:
                    if (num2 == 0)
                    {
                        Console.WriteLine(" Módulo por zero não é permitido.");
                        totalErros++;
                        operacaoValida = false;
                    }
                    else
                    {
                        resultado = num1 % num2;
                    }
                    break;
            }

            if (operacaoValida)
            {
                Console.WriteLine($" Resultado: {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
                totalOperacoes++;
            }

            continuar = PerguntarSeContinua();

        } while (continuar == "sim");

        Console.WriteLine("\n RESUMO FINAL");
        Console.WriteLine($"Total de operações válidas: {totalOperacoes}");
        Console.WriteLine($"Total de erros encontrados: {totalErros}");
        Console.WriteLine("Obrigado por usar a Calculadora!");

        Console.WriteLine("\nPressione qualquer tecla para sair...");
        Console.ReadKey();
    }

    static string PerguntarSeContinua()
    {
        Console.Write("\nDeseja continuar calculando? (sim/não): ");
        return Console.ReadLine().Trim().ToLower();
    }

    static int ConverterOpcao(string entrada)
    {
        entrada = entrada.Trim().ToLower();

        return entrada switch
        {
            "1" or "um" or "primeiro" => 1,
            "2" or "dois" or "segundo" => 2,
            "3" or "três" or "tres" or "terceiro" => 3,
            "4" or "quatro" or "quarto" => 4,
            "5" or "cinco" or "quinto" => 5,
            "6" or "seis" or "sair" => 6,
            _ => 0
        };
    }
}
