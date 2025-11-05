
namespace PraticandoCsharp.Desafios;
public class Retangulo
{
    public double Largura { get; set; }
    public double Altura { get; set; }
    public Retangulo(double largura, double altura)
    {
        Largura = largura;
        Altura = altura;
    }
    public double CalcularArea()
    {
        return Largura * Altura;
    }
}
