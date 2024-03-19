using Exercicio_2;
using Exercicio_2.enums;

#region Criação da lista

var listaItensMercado = new List<ItemMercado>
{
    new ItemMercado
    {
        Nome = "Arroz",
        Tipo = Tipo.Comida,
        Preco = 3.90
    },
    new ItemMercado
    {
        Nome = "Azeite",
        Tipo = Tipo.Comida,
        Preco = 2.50
    },
    new ItemMercado
    {
        Nome = "Macarrão",
        Tipo = Tipo.Comida,
        Preco = 3.90
    },
    new ItemMercado
    {
        Nome = "Cerveja",
        Tipo = Tipo.Bebida,
        Preco = 22.90
    },
    new ItemMercado
    {
        Nome = "Refrigerante",
        Tipo = Tipo.Bebida,
        Preco = 5.50
    },
    new ItemMercado
    {
        Nome = "Shampoo",
        Tipo = Tipo.Higiene,
        Preco = 7.0
    },
    new ItemMercado
    {
        Nome = "Sabonete",
        Tipo = Tipo.Higiene,
        Preco = 2.40
    },
    new ItemMercado
    {
        Nome = "Cotonete",
        Tipo = Tipo.Higiene,
        Preco = 5.70
    },
    new ItemMercado
    {
        Nome = "Sabão em pó",
        Tipo = Tipo.Limpeza,
        Preco = 8.20
    },
    new ItemMercado
    {
        Nome = "Detergente",
        Tipo = Tipo.Limpeza,
        Preco = 2.60
    },
    new ItemMercado
    {
        Nome = "Amaciante",
        Tipo = Tipo.Limpeza,
        Preco = 6.40
    }
};

#endregion

#region Expressões LINQ

var listaItensHigienteOrdenadosDecrescentePorPreco = listaItensMercado
    .Where(item => item.Tipo == Tipo.Higiene)
    .OrderByDescending(item => item.Preco).ToList();

Console.WriteLine("Lista de itens de higiene ordenada pelo preço de forma decrescente:");
listaItensHigienteOrdenadosDecrescentePorPreco
    .ForEach(item => Console.WriteLine($"{item.Nome} - R${item.Preco:F2} "));

var listaItensComPrecoMaiorOuIgualA5OrdenadosCrescentePorPreco = listaItensMercado
    .Where(item => item.Preco >= 5)
    .OrderBy(item => item.Preco).ToList();

Console.WriteLine("\nLista de itens com preço maior ou igual a 5 ordenados por preço");
listaItensComPrecoMaiorOuIgualA5OrdenadosCrescentePorPreco
    .ForEach(item => Console.WriteLine($"{item.Nome} - R${item.Preco:F2}"));

var listaItensTipoBebidaOuComidaOrdenadosAlfabetica = listaItensMercado
    .Where(item => item.Tipo is Tipo.Bebida or Tipo.Comida)
    .OrderBy(item => item.Nome).ToList();

Console.WriteLine("\nLista de itens do tipo Bebida ou Comida ordenados por nome de forma alfabética");
listaItensTipoBebidaOuComidaOrdenadosAlfabetica
    .ForEach(item => Console.WriteLine($"{item.Nome} - {item.Tipo.ToString()}"));

Console.WriteLine("\nQuantidade de itens por tipo:");
var quantidadeComida = listaItensMercado.Count(item => item.Tipo == Tipo.Comida);
var quantidadeBebida = listaItensMercado.Count(item => item.Tipo == Tipo.Bebida);
var quantidadeHigiene = listaItensMercado.Count(item => item.Tipo == Tipo.Higiene);
var quantidadeLimpeza = listaItensMercado.Count(item => item.Tipo == Tipo.Limpeza);

Console.WriteLine($"Comida = {quantidadeComida} itens.");
Console.WriteLine($"Bebida = {quantidadeBebida} itens");
Console.WriteLine($"Higiene = {quantidadeHigiene} itens");
Console.WriteLine($"Limpeza = {quantidadeLimpeza} itens");

Console.WriteLine("\nInformações sobre cada tipo de item:");
var tipos = new List<string>{"Comida", "Bebida", "Higiene", "Limpeza" };
foreach (var tipo in tipos)
{
    Console.WriteLine($"\n{tipo}:");
    Console.WriteLine($"Preço máximo = R${listaItensMercado.Where(item => item.Tipo.ToString() == tipo).Max(item => item.Preco):F2}");
    Console.WriteLine($"Preço mínimo = R${listaItensMercado.Where(item => item.Tipo.ToString() == tipo).Min(item => item.Preco):F2}");
    Console.WriteLine($"Média de preço = R${listaItensMercado.Where(item => item.Tipo.ToString() == tipo).Average(item => item.Preco):F2}");
}

#endregion