using Exercicio3.Enums;
using Exercicio3.Exceptions;

Console.WriteLine("Digite o número correspondente à opção de exercício:");
Console.WriteLine("1 - Academia");
Console.WriteLine("2 - Luta");
Console.WriteLine("3 - Corrida");
Console.Write("Opção: ");

try
{
    var option = int.Parse(Console.ReadLine());

    if (option is <= 0 or >= 4)
    {
        throw new ValorInvalidoException();
    }

    Console.WriteLine($"Exercício escolhido: {Enum.GetName(typeof(Exercicio), option)}");
}
catch (FormatException e)
{
    Console.WriteLine("Formato da entrada inválido. Você deve digitar um número.");
}
catch (ValorInvalidoException e)
{
    Console.WriteLine(e.Message);
}
finally
{
    Console.WriteLine("Programa finalizado.");
}
