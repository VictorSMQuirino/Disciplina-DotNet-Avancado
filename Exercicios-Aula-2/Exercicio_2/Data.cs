namespace Exercicio2;
public class Data
{
    private int dia, mes, ano, hora, minuto, segundo;
    private bool temHoras = false;
    public static readonly int FORMATO_12H = 12;
    public static readonly int FORMATO_24H = 24;

    public Data(int dia, int mes, int ano)
    {
        this.dia = dia;
        this.mes = mes;
        this.ano = ano;    
    }

    public Data(int dia, int mes, int ano, int hora, int minuto, int segundo) : this(dia, mes, ano)
    {
        if(hora >= 0 && hora < 24) this.hora = hora;

        this.minuto = minuto;
        this.segundo = segundo;
        temHoras = true;
    }

    public int Dia { get { return dia; } }

    public int Mes { get { return mes; } }

    public int Ano { get { return ano; } }

    public int Hora { get { return hora; } }

    public int Minuto { get { return minuto; } }

    public int Segundo { get { return segundo; } }

    public void imprimir(int formato)
    {
        if(formato == 12)
        {
            Console.Write($"{dia}/{mes}/{ano} ");

            if(temHoras)
            {
                var horasAmenos = hora < 13 ? 0 : 12;
                Console.Write($"{hora - horasAmenos}:{minuto}:{segundo}");
                if(hora < 13) Console.WriteLine(" AM");
                else Console.WriteLine(" PM");
                return;
            }

        }
        
        if(temHoras)
        {
            Console.WriteLine($"{dia}/{mes}/{ano} {hora}:{minuto}:{segundo}");
            return;
        }
        Console.WriteLine($"{dia}/{mes}/{ano}");        
    }
}
