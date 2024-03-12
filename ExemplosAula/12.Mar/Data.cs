using System.Xml.Serialization;

namespace Exercicio;
public class Data
{
    private int dia{get;}
    private int mes{get;}
    private int ano{get;}
    private int hora{get;}
    private int minuto{get;}
    private int segundo{get;}

    public const int FORMATO_12H = 12;
    public const int FORMATO_24H = 24;
    public Data(int dia, int mes, int ano){
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;
    }
    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo):this(dia, mes, ano){
        this.hora = hora;
        this.minuto = minuto;
        this.segundo = segundo;
    }
    public void imprimir(int formato){
        if(formato == 12){
            if(this.hora >= 0 && this.hora <= 12){
                Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo} AM");
            }else if(this.hora > 12 && this.hora <= 23){
                Console.WriteLine($"{dia}/{mes}/{ano} {hora-12}:{minuto}:{segundo} PM");
            }
        }else if(formato == 24){
            Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}");       
        }
    }
}
