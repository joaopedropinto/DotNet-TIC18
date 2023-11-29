namespace Semana4.Avaliacao_Individual;

public class Medico
{
  public Medico(string nome, string cpf, DateTime data_Nascimento, string crm)
  {
    Nome = nome;
    Cpf = cpf;
    Data_Nascimento = data_Nascimento;
    Crm = crm;
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
  public string Crm { get; private set; }
}