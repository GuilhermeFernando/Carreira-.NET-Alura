namespace ScreenSound.Desafio;
public class Carro
{
    public string Marca { get; set; }
    public string Modelo { get; set; }
    public string Cor { get; set; }
    public int QuantidadePortas { get; set; }
    public int PotenciaMotor { get; set; }
    public string AnoFabricacao { get; set; }
    public int Velocidade { get; set; }

    public string DescricaoDetahada => $"{Marca} {Modelo} {Cor} {QuantidadePortas} portas {PotenciaMotor} HP {AnoFabricacao}";
    public void exibirInformacoes()
    {
        Console.WriteLine($"Informações do carro: {this.Marca} {this.Modelo}, {this.QuantidadePortas} portas, {this.AnoFabricacao}");
    }

    public void acelerar()
    {
        Console.WriteLine("Acelerando...");
        if (Velocidade < 100)
        {
            Velocidade = Velocidade + 5;
        }
    }

    public void frear()
    {
        Console.WriteLine("Freando...");
        if (Velocidade > 0)
        {
            Velocidade = Velocidade - 5;
        }
    }

    public void buzinar()
    {
        Console.WriteLine("Bi Bi");
    }

}
