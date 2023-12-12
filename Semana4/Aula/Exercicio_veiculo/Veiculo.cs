namespace Semana4.Aula.Exercicio_veiculo;

public class Veiculo
{
  public string Ano { get; set; }
  public string Modelo { get; set; }
  public string Cor { get; set; }

  public string IdadeVeiculo => $"{DateTime.Now.Year - int.Parse(Ano)}";
}

