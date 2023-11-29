namespace Semana4.Avaliacao_Individual;

public class Paciente : Pessoa
{
  public Paciente(string nome, DateTime data_Nascimento, string cpf, string sexo, string sintomas)
  {
    Nome = nome;
    Data_Nascimento = data_Nascimento;
    Cpf = cpf;
    Sexo = sexo;
    Sintomas = sintomas;
  }
  
  public string Sexo { get; private set; }
  public string Sintomas { get; private set; }
  private static List<string> cpfsCadastrados = new List<string>();
}