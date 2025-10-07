class GerenciadorDeTarefas
{
    static void Main()
    {

        List<string> tarefas = new List<string>();
        int opc;

        do
        {

            Console.Clear();
            Console.WriteLine("GERENCIADOR DE TAREFAS");
            Console.WriteLine("**********************************");
            Console.WriteLine($"Total das Tarefas: {tarefas.Count}");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("(1) - Adicionar Tarefa");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("(2) - Listar Tarefas");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("(3) - Remover Tarefa");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.WriteLine("(4) - SAIR");
            Console.WriteLine("--------------------------------------------------------------------------------------------------");
            Console.Write("Escolha uma opção: ");


            while (!int.TryParse(Console.ReadLine(), out opc) || opc < 1 || opc > 4)
            {
                Console.WriteLine("Errou, somente de 1 a 4.");
                Console.Write("Escolha uma opção: ");
            }


            switch (opc)
            {
                case 1:
                    AdicionarTarefa(tarefas);
                    break;
                case 2:
                    ListTarefa(tarefas);
                    break;
                case 3:
                    RemoverTarefa(tarefas);
                    break;
                case 4:
                    Console.WriteLine("Saindo...");
                    break;
            }
            Console.WriteLine("Pressione o botao A para prosseguir:");
            ConsoleKeyInfo teclado = Console.ReadKey();

            if (teclado.Key == ConsoleKey.A || teclado.Key == ConsoleKey.A)
            {
                Console.WriteLine("OK!, pode continuar");
            }
            else
            {
                Console.WriteLine("Errou a tecla!");
            }

        } while (opc != 4);
    }


    static void AdicionarTarefa(List<string> tarefas)
    {
        Console.Clear();
        Console.Write("Digite o nome da tarefa: ");
        string tarefa = Console.ReadLine();


        if (tarefas.Contains(tarefa))
        {
            Console.WriteLine(" Já existente!");
        }
        else
        {
            tarefas.Add(tarefa);
            Console.WriteLine("Tarefa adicionada!");
        }
    }


    static void ListTarefa(List<string> tarefas)
    {
        Console.Clear();
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhuma tarefa cadastrada.");
        }
        else
        {
            Console.WriteLine("Tarefas cadastradas:");
            for (int i = 0; i < tarefas.Count; i++)
            {
                Console.WriteLine($"{i + 1} - {tarefas[i]}");
            }
        }
    }


    static void RemoverTarefa(List<string> tarefas)
    {
        Console.Clear();
        if (tarefas.Count == 0)
        {
            Console.WriteLine("Nenhum tarefa achado.");
            return;
        }

        ListTarefa(tarefas);
        Console.Write("Mi fale oq vc deseja remover: ");
        int numeroTarefa;


        while (!int.TryParse(Console.ReadLine(), out numeroTarefa) || numeroTarefa < 1 || numeroTarefa > tarefas.Count)
        {
            Console.WriteLine("Número inválido. Escolha um número entre 1 e " + tarefas.Count);
            Console.Write("Digite o número da tarefa que deseja remover: ");
        }


        tarefas.RemoveAt(numeroTarefa - 1);
        Console.WriteLine("Tarefa removida com sucesso!");
    }
}