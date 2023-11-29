namespace Semana4.Avaliacao_Individual;

public class App
{
  List<Medico> medicos = new List<Medico>();
  List<Paciente> pacientes = new List<Paciente>();
  public void Main()
  {
    Medico medico1 = new Medico("Dr. Fulano", "12345678901", new DateTime(2000, 1, 1), "CRM12345");
    Medico medico2 = new Medico("Dra. Ciclana", "11111111111", new DateTime(1990, 5, 10), "CRM67890");

    Paciente paciente1 = new Paciente("Fulana", "22222222222", new DateTime(1990, 1, 1), "Feminino", "Dor de cabeça, Tosse");
    Paciente paciente2 = new Paciente("Beltrano", "33333333333", new DateTime(1980, 3, 15), "Masculino", "Dor no corpo, Febre, Tosse");

    medicos.Add(medico1);
    medicos.Add(medico2);
    pacientes.Add(paciente1);
    pacientes.Add(paciente2);

    // RelatorioMedicoEntreIdades();
    // RelatorioPacienteEntreIdades();
    //RelatorioPacientePorSexo();
    //RelatorioPacienteOrdemAlfabetica();
    //RelatorioPacientePorSintoma();
    RelatorioAniversariantesMes();

  }

  private void RelatorioMedicoEntreIdades()
  {
    try
    {
      Console.WriteLine($"Digite a idade mínima limitante para o relatório: ");
      int idade1 = int.Parse(Console.ReadLine());
      Console.WriteLine($"Digite a idade máxima limitante para o relatório: ");
      int idade2 = int.Parse(Console.ReadLine());

      var medicosFiltrados = medicos.Where(p => p.Idade >= idade1 && p.Idade <= idade2).ToList();

      if (medicosFiltrados.Any())
        Console.WriteLine($"Relatório de médicos com idades entre {idade1} e {idade2}");

      foreach (var medico in medicosFiltrados)
      {
        Console.WriteLine($"Nome: {medico.Nome} - Idade: {medico.Idade} - CRM: {medico.Crm}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
  private void RelatorioPacienteEntreIdades()
  {
    try
    {
      Console.WriteLine($"Digite a idade mínima limitante para o relatório: ");
      int idade1 = int.Parse(Console.ReadLine());
      Console.WriteLine($"Digite a idade máxima limitante para o relatório: ");
      int idade2 = int.Parse(Console.ReadLine());

      var pacientesFiltrados = pacientes.Where(p => p.Idade >= idade1 && p.Idade <= idade2).ToList();

      Console.WriteLine($"Relatório de pacientes com idades entre {idade1} e {idade2}:");

      foreach (var paciente in pacientesFiltrados)
      {
        Console.WriteLine($"Nome: {paciente.Nome} - CPF: {paciente.Cpf} - Idade: {paciente.Idade} - Sexo: {paciente.Sexo} - Sintomas: {paciente.Sintomas}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  private void RelatorioPacientePorSexo()
  {
    try
    {
      Console.Write("Informe o sexo para o relatório de pacientes (Masculino/Feminino): ");
      string sexoUsuario = Console.ReadLine();

      var pacientesFiltrados = pacientes.Where(p => p.Sexo == sexoUsuario).ToList();

      Console.WriteLine($"\nRelatório de pacientes com sexo {sexoUsuario}:");

      foreach (var paciente in pacientesFiltrados)
      {
        Console.WriteLine($"Nome: {paciente.Nome} - CPF: {paciente.Cpf} - Idade: {paciente.Idade} - Sintomas: {paciente.Sintomas}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  private void RelatorioPacienteOrdemAlfabetica()
  {
    try
    {
      var pacientesFiltrados = pacientes.OrderBy(p => p.Nome).ToList();
      Console.WriteLine("\nPacientes em ordem alfabética:");
      foreach (var paciente in pacientesFiltrados)
      {
        Console.WriteLine($"Nome: {paciente.Nome} - CPF: {paciente.Cpf} - Idade: {paciente.Idade} - Sintomas: {paciente.Sintomas}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  private void RelatorioPacientePorSintoma()
  {
    try
    {
      Console.WriteLine($"\nInforme o sintoma a ser procurado: ");
      string sintomaProcurado = Console.ReadLine();

      var pacientesFiltrados = pacientes.Where(p => p.Sintomas.Contains(sintomaProcurado)).ToList();

      Console.WriteLine($"\nPacientes cujos sintomas contenham '{sintomaProcurado}':");
      foreach (var paciente in pacientesFiltrados)
      {
        Console.WriteLine($"Nome: {paciente.Nome} - CPF: {paciente.Cpf} - Idade: {paciente.Idade} - Sexo: {paciente.Sexo} - Sintomas: {paciente.Sintomas}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }

  private void RelatorioAniversariantesMes()
  {
    try
    {
      Console.WriteLine($"=== Relatório de aniversariantes do mês === ");
      Console.WriteLine($"Informe o mes desejado: ");
      int mes = int.Parse(Console.ReadLine());
      var medicosAniversariantes = medicos.Where(m => m.Data_Nascimento.Month == mes)
                                       .OrderBy(m => m.Data_Nascimento.Day);

      var pacientesAniversariantes = pacientes.Where(p => p.Data_Nascimento.Month == mes)
                                             .OrderBy(p => p.Data_Nascimento.Day);

      Console.WriteLine($"\nAniversariantes do mês {mes}:");

      foreach (var medico in medicosAniversariantes)
      {
        Console.WriteLine($"Nome: {medico.Nome} (Médico) - Data de aniversário: {medico.Data_Nascimento.Day}/{mes}");
      }

      foreach (var paciente in pacientesAniversariantes)
      {
        Console.WriteLine($"Nome: {paciente.Nome} (Paciente) - Data de aniversário: {paciente.Data_Nascimento.Day}/{mes}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}
