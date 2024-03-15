using Exercício5;

var ponto1 = new Ponto<int>
{
    X = 15,
    Y = 18,
    Z = 54
};

var ponto2 = new Ponto<int>
{
    X = 66,
    Y = 50,
    Z = 54
};

var ponto3 = new Ponto<int>
{
    X = 32,
    Y = 37,
    Z = 20
};

var triangulo1 = new Triangulo<int>
{
    P1 = ponto1,
    P2 = ponto2,
    P3 = ponto3
};

var triangulo2 = new Triangulo<double>()
{
    P1 = new Ponto<double>
    {
        X = 10.0,
        Y = 34.52,
        Z = 2.0
    },
    P2 = new Ponto<double>
    {
        X = 67.8,
        Y = 93.2,
        Z = 30.1
    },
    P3 = new Ponto<double>
    {
        X = 59.1,
        Y = 43.9,
        Z = 28.7
    }
};

var triangulo3 = new Triangulo<char>
{
    P1 = new Ponto<char>
    {
        X = 'A',
        Y = 'B',
        Z = 'C'
    },
    P2 = new Ponto<char>
    {
        X = 'X',
        Y = 'Y',
        Z = 'Z'
    },
    P3 = new Ponto<char>
    {
        X = 'Q',
        Y = 'Y',
        Z = 'Z'
    }
};

Console.WriteLine(triangulo1);
Console.WriteLine(triangulo2);
Console.WriteLine(triangulo3);