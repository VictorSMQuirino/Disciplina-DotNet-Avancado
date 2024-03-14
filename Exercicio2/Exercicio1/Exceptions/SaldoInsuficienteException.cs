namespace Exercicio1.Exceptions;

public class SaldoInsuficienteException : Exception
{
    public SaldoInsuficienteException(double valor, double saldo) : 
        base($"Impossível sacar R${valor.ToString("F2")}, pois o saldo atual é de R${saldo.ToString("F2")}") { }
}