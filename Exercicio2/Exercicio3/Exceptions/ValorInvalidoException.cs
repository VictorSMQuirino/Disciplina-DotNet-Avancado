namespace Exercicio3.Exceptions;

public class ValorInvalidoException : Exception
{
    public ValorInvalidoException() : base("Valor inválido. Digite um número de 1 a 3.") { }
}