namespace PraticandoCsharp.Desafios;

public class ContaBancaria
{
    public int NumeroConta { get; set; }
    public double  Saldo { get; set; }

    public ContaBancaria(int numeroConta, double saldo)
    {
        Saldo = saldo;
        NumeroConta = numeroConta;
    }

    public void Depositar(double valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }
}
