namespace ScreenSound.Desafio;
public class ContaBancaria
{
    public string Titular { get; set; }
    public int NumeroIndicador { get; set; }
    public double Saldo { get; set; }
    public string Senha { get; set; }

    public void GetDetalhesConta()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Número Indicador: {NumeroIndicador}");
        Console.WriteLine($"Saldo: R$ {Saldo}");
    }
}
