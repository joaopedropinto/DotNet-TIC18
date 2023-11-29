namespace Semana4.Avaliacao_Individual;

public class Pessoa
{
  public Pessoa(string nome, string cpf, DateTime data_Nascimento){
    Nome = nome;
    Cpf = cpf;
    Data_Nascimento = data_Nascimento;
  }
  public string Nome { get; private set; }
  public DateTime Data_Nascimento { get; private set; }
  private string _cpf;
  public string Cpf
  {
    get { return _cpf; }

    private set
    {
      if (cpfsCadastrados.Contains(value))
      {
        throw new Exception("Cpf ja cadastrado");
      }
      else if (value.Length != 11)
      {
        throw new Exception("Cpf deve ter 11 digitos");
      }
      else
      {
        cpfsCadastrados.Add(value);
        _cpf = value;
      }
    }
  }
  
  public int Idade => DateTime.Now.Year - Data_Nascimento.Year;
  private static List<string> cpfsCadastrados = new List<string>();

}