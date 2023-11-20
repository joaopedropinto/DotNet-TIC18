static void main()
{
  while (true)
  {

    Console.WriteLine($"\n===== Sistema de Gerenciamento de Tarefas =====\n");
    Console.WriteLine($"1 - Cadastrar tarefa");
    Console.WriteLine($"2 - Listar tarefas");
    Console.WriteLine($"3 - Marcar tarefa como concluída");
    Console.WriteLine($"4 - Listar tarefas pendentes");
    Console.WriteLine($"5 - Listar tarefas concluídas");
    Console.WriteLine($"6 - Excluir tarefa");
    Console.WriteLine($"7 - Pesquisar tarefa");
    Console.WriteLine($"8 - Exibir estatísticas");
    Console.WriteLine($"0 - Sair");

    Console.Write("Escolha uma opção: ");

    int opcao = int.Parse(Console.ReadLine());

    switch (opcao)
    {
      case 1:
        break;
      case 2:
        break;
      case 3:
        break;
      case 4:
        break;
      case 5:
        break;
      case 6:
        break;
      case 7:
        break;
      case 8:
        break;
      case 0:
        Console.WriteLine($"Saindo...");
        return;
      default:
        Console.WriteLine($"Opcao invalida, tente novamente");
        break;

    }
  }