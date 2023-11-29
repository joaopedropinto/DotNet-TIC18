namespace Semana4.Avaliacao_Individual;

public class App
{
  List<Medico> medicos = new List<Medico>();
  List<Paciente> pacientes = new List<Paciente>();
  public void Main()
  {
    Console.WriteLine("Hello World!");

  }

  private void RelatorioMedicoEntreIdades()
  {
    try
    {
      Console.WriteLine($"Digite as idades limitantes para o relatório: ");
      int idade1 = int.Parse(Console.ReadLine());
      int idade2 = int.Parse(Console.ReadLine());
      var medicosFiltrados = medicos.where(p => p.Idade >= idade1 && p.Idade <= idade2);

      Console.WriteLine($"Relatório de médicos com idades entre {idade1} e {idade2}");

      foreach (var medico in medicosFiltrados)
      {
        Console.WriteLine($"Nome: {medico.Nome} - CRM: {medico.Crm}");
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
      Console.WriteLine($"Digite as idades limitantes para o relatório: ");
      int idade1 = int.Parse(Console.ReadLine());
      int idade2 = int.Parse(Console.ReadLine());
      var pacientesFiltrados = medicos.where(p => p.Idade >= idade1 && p.Idade <= idade2);

      Console.WriteLine($"Relatório de pacientes com idades entre {idade1} e {idade2}");

      foreach (var paciente in pacientesFiltrados)
      {
        Console.WriteLine($"Nome: {paciente.Nome} - CPF: {paciente.Cpf} - Sintomas: {paciente.Sintomas}");
      }
    }
    catch (Exception ex)
    {
      Console.WriteLine($"Error: {ex.Message}");
    }
  }
}