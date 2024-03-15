using Exercicio4.Interfaces;

namespace Exercicio4;

public class Entrega : IServico
{
    public Entrega() {}
    
    public void Executar()
    {
        Console.WriteLine("Entrega executada.");
    }
}