using System;

namespace UrnaEletronica
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int votosMSDN = 0;
            int votosTechNet = 0;
            int votosSpoke = 0;
            int votosBranco = 0;
            int votosNulo = 0;
            int totalVotos = 0;

            string continuarVotacao = "sim";

          
            Console.WriteLine("====================================");
            Console.WriteLine("Data e Hora: " + DateTime.Now);
            Console.WriteLine("Bem-vindo à Urna Eletrônica!");
            Console.WriteLine("====================================");

            
            while (continuarVotacao.ToLower() == "sim")
            {
                Console.WriteLine("\nEscolha sua opção de voto:");
                Console.WriteLine("1 - MSDN Brasil");
                Console.WriteLine("2 - TechNet Brasil");
                Console.WriteLine("3 - The Spoke .Net");
                Console.WriteLine("4 - Voto em branco");
                Console.WriteLine("5 - Voto nulo");
                Console.Write("Digite sua opção: ");

                string entrada = Console.ReadLine();
                int opcaoVoto;

                
                if (int.TryParse(entrada, out opcaoVoto))
                {
                    switch (opcaoVoto)
                    {
                        case 1:
                            votosMSDN++;
                            break;
                        case 2:
                            votosTechNet++;
                            break;
                        case 3:
                            votosSpoke++;
                            break;
                        case 4:
                            votosBranco++;
                            break;
                        case 5:
                            votosNulo++;
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Voto não registrado.");
                            continue;
                    }

                    totalVotos++;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número de 1 a 5.");
                    continue;
                }

                
                Console.Write("\nDeseja continuar votando? (sim/não): ");
                continuarVotacao = Console.ReadLine().ToLower();
            }

         
            Console.WriteLine("\n ===== Resultado Final da Votação =====");
            Console.WriteLine($"MSDN Brasil: {votosMSDN} votos");
            Console.WriteLine($"TechNet Brasil: {votosTechNet} votos");
            Console.WriteLine($"The Spoke .Net: {votosSpoke} votos");
            Console.WriteLine($"Votos em branco: {votosBranco}");
            Console.WriteLine($"Votos nulos: {votosNulo}");
            Console.WriteLine($"Total de votos registrados: {totalVotos}");
            Console.WriteLine("====================================");
        }
    }
}