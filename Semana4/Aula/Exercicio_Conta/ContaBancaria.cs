namespace Semana4.Aula.Exercicio_Conta;

public class ContaBancaria
{
  private double _saldo;

  public double Saldo
  {
    get { return _saldo;}
    set
    {
      if(value < 0){
        throw new ArgumentException("Saldo não pode ser negativo");
      }else{
        _saldo = value;
      }
    }
  }
}