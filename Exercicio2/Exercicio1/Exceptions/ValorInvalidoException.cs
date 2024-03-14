namespace Exercicio1.Exceptions;

public class ValorInvalidoException : Exception
{
    public ValorInvalidoException(double valor) : 
        base($"Impossível realizar transação com o valor R${valor.ToString("F2")}, pois não pode ser menor ou igual a 0.") { }
}