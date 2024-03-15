using Exercicio4.Interfaces;

namespace Exercicio4;

public class Venda : IServico
{
    public void Executar()
    {
        Console.WriteLine("Venda executada");
    }
}