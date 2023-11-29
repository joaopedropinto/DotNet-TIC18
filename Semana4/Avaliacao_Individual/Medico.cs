namespace Semana4.Avaliacao_Individual;

public class Medico : Pessoa
{
  public Medico(string nome, string cpf, DateTime data_Nascimento, string crm) : base(nome, cpf, data_Nascimento)
  {
    Crm = crm;
  }
  private string _crm;
  public string Crm
  {
    get { return _crm; }
    private set
    {
      if (crmsCadastrados.Contains(value))
      {
        throw new Exception("Crm ja cadastrado");
      }
      else
      {
        crmsCadastrados.Add(value);
        _crm = value;
      }
    }
  }
  private static List<string> crmsCadastrados = new List<string>();

}