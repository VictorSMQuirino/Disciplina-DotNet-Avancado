using Exercicio_2.enums;

namespace Exercicio_2;

public class ItemMercado
{
    public string Nome { get; set; } = default!;
    public Tipo Tipo { get; set; }
    public double Preco { get; set; }
}