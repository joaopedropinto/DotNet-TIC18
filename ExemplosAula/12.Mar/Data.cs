using System.Xml.Serialization;

namespace Exercicio;
public class Data
{
    private readonly int dia;
    private readonly int mes;
    private readonly int ano;
    private readonly int hora;
    private readonly int minuto;
    private readonly int segundo;

    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;
    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }

    public int Dia => dia;
    public int Mes => mes;
    public int Ano => ano;
    public int Hora => hora;
    public int Minuto => minuto;
    public int Segundo => segundo;
    public void imprimir(int formato)
    {
        if (formato == FORMATO_12H || formato == FORMATO_24H)
        {
            string dataString = $"{dia}/{mes}/{ano}";
            if (hora != 0 || minuto != 0 || segundo != 0)
            {
                string horaString;
                if (formato == FORMATO_12H)
                {
                    horaString = hora < 12 ? "AM" : "PM";
                    int hora12h = hora == 0 || hora == 12 ? 12 : hora % 12;
                    horaString = $"{hora12h}:{minuto}:{segundo} {horaString}";
                }
                else
                {
                    horaString = $"{hora}:{minuto}:{segundo}";
                }
                Console.WriteLine($"{dataString} {horaString}");
            }
            else
            {
                Console.WriteLine(dataString);
            }
        }
        else
        {
            Console.WriteLine("Formato de hora inválido.");
        }
    }
}

