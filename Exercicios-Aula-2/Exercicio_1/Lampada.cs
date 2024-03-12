namespace Exercicio1;
public class Lampada
{
    private bool ligada;

    public Lampada(bool estado) => ligada = estado;

    public void Ligar()
    {
        ligada = true;
    }

    public void Desligar()
    {
        ligada = false;
    }

    public void Imprimir()
    {
        if(ligada)
        {
            Console.WriteLine("Lâmpada ligada");
            return;
        } 
        
        Console.WriteLine("Lâmpada desligada");
    }
}
