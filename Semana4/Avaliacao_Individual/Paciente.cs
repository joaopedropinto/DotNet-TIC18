namespace Semana4.Avaliacao_Individual;

public class Paciente
{
  public Paciente(string nome, DateTime data_Nascimento, string cpf, string sexo, string sintomas){
    Nome = nome;
    Data_Nascimento = data_Nascimento;
    Cpf = cpf;
    Sexo = sexo;
    Sintomas = sintomas;
  }
  public string Nome { get; private set; }

  public DateTime Data_Nascimento { get; private set; }

  private string _cpf;
  public string Cpf
  {
    get { return _cpf; }

    private set
    {
      if (value.Length != 11)
      {
        throw new Exception("Cpf deve ter 11 digitos");
      }
      else
      {
        _cpf = value;
      }
    }
  }

  public string Sexo { get; private set; }
  public string Sintomas { get; private set; }

}