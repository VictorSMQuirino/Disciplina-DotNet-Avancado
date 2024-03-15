using Exercicio4.Interfaces;

namespace Exercicio4;

public class ServicoFabrica<T> where T : IServico, new() 
{
    public static T NovaInstancia()
    {
        return new T();
    }
}