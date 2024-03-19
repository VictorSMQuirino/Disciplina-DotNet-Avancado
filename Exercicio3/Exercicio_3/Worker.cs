namespace Exercicio_3;

public class Worker
{
    private int numeroInstancia;

    public Worker(int numeroInstancia)
    {
        this.numeroInstancia = numeroInstancia;
    }
    
    public void Work()
    {
        Console.WriteLine($"O trabalho da instância {numeroInstancia} foi inicializado.");
        
        Thread.Sleep(2000);
        
        Console.WriteLine($"O trabalho da instância {numeroInstancia} está sendo execitado.");
        
        Thread.Sleep(2000);
        
        Console.WriteLine($"O trabalho da instância {numeroInstancia} foi finalizado.");
    }
}