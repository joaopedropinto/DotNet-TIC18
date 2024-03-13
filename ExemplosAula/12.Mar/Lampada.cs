namespace Exercicio;
public class Lampada
{
    private bool ligada = true;

    public void Ligar()
    {
        this.ligada = true;
    }
    public void Desligar()
    {
        this.ligada = false;
    }

    public void Imprimir()
    {
        if (this.ligada)
        {
            Console.WriteLine($"A lampada está ligada!");
        }
        else
        {
            Console.WriteLine($"A lampada está desligada!");

        }
    }
}
