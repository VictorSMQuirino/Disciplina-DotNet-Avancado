using Exercicio1.Exceptions;

namespace Exercicio1.Entities;

public class ContaBancaria
{
    private double saldo;

    public ContaBancaria(double saldo) => this.saldo = saldo;

    public void Sacar(double valor)
    {
        if (valor <= 0) throw new ValorInvalidoException(valor);
        if (saldo < valor) throw new SaldoInsuficienteException(valor, saldo);
        saldo -= valor;
        Console.WriteLine($"Saque realizado com sucesso! Saldo atual: R${saldo.ToString("F2")}");
    }

    public void Depositar(double valor)
    {
        if (valor <= 0) throw new ValorInvalidoException(valor);
        saldo += valor;
        Console.WriteLine($"Depósito realizado com sucesso. Saldo atual: R${saldo.ToString("F2")}");
    }
}
