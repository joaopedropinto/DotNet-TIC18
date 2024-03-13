using Exercicio;

#region Exercicio1
Console.WriteLine($"Exercicio 1");
Lampada p1 = new Lampada();
Console.WriteLine($"Lampada criada!");

p1.Imprimir();
Console.WriteLine($"Desligando a lampada!");
p1.Desligar();
p1.Imprimir();
Console.WriteLine($"Ligando a lampada!");
p1.Ligar();
p1.Imprimir();
#endregion

#region Exercicio2
Console.WriteLine($"\n");
Console.WriteLine($"Exercicio 2");
Data d1 = new Data(10, 03, 2000, 10, 30, 10);
d1.imprimir(Data.FORMATO_12H);
d1.imprimir(Data.FORMATO_24H);
Data d2 = new Data(15, 06, 2000, 23, 15, 20);
d2.imprimir(Data.FORMATO_12H);
d2.imprimir(Data.FORMATO_24H);
Data d3 = new Data(5, 10, 2005);
d3.imprimir(Data.FORMATO_12H);
d3.imprimir(Data.FORMATO_24H);
#endregion