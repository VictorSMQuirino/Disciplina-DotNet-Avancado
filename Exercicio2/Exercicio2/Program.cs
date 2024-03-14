object o = null;

try
{
    o.ToString();

}
catch (NullReferenceException e)
{
    Console.WriteLine("Seu objeto tem um referencia nula. Instancie seu objeto primeiro.");
}
