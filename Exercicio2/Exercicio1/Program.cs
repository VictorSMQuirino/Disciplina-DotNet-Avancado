using Exercicio1.Entities;

var conta1 = new ContaBancaria(250.0);
var conta2 = new ContaBancaria(1500.50);

#region Saques

try
{
    conta1.Sacar(50.0);
    conta2.Sacar(475.0);
    conta1.Sacar(300.0);
    conta2.Sacar(2000.0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

#endregion

#region Depositos

try
{
    conta1.Depositar(250.0);
    conta2.Depositar(120.8);
    conta1.Depositar(50.0);
    conta2.Depositar(0.0);
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}

#endregion