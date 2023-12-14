using Semana4.Aula.Exercicio_veiculo;

var veiculo = new Veiculo
{
  Ano = "2020",
  Modelo = "Gol",
  Cor = "Preto"
};

Console.WriteLine($"Veiculo: {veiculo.Ano} - {veiculo.Modelo} - {veiculo.Cor}");
Console.WriteLine($"Idade: {veiculo.IdadeVeiculo}");

