namespace Semana4.Avaliacao_Individual;

public class Paciente : Pessoa
{
  public Paciente(string nome, string cpf, DateTime data_Nascimento, string sexo, string sintomas) : base(nome, cpf, data_Nascimento)
  {
    Sexo = sexo;
    Sintomas = sintomas;
  }

  public string Sexo { get; private set; }
  public string Sintomas { get; private set; }
}