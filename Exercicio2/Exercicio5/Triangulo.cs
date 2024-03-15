namespace Exercício5;

public struct Triangulo<T>
{
    public Ponto<T> P1 { get; set; }
    public Ponto<T> P2 { get; set; }
    public Ponto<T> P3 { get; set; }

    public override string ToString()
    {
        return $"Coordenadas dos pontos do triângulo: P1({P1.X}, {P1.Y}, {P1.Z}), P2({P2.X}, {P2.Y}, {P2.Z}), P3({P3.X}, {P3.Y}, {P3.Z})";
    }
}