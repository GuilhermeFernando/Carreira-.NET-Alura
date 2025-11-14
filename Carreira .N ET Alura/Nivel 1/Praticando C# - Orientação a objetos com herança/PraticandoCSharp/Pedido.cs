namespace PraticandoCSharp;
internal class Pedido
{
    public bool Pago;
    public int Id { get; }
    public string Cliente { get; set; }
    public DateTime Data { get; }
    public decimal ValorTotal { get;}

    public Pedido(int id, string cliente, decimal valorTotal)
    {
       this.Id = id;
       this.Data = DateTime.Now;
       this.ValorTotal = valorTotal;
       this.Pago = false;
       this.Cliente = cliente;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Pedido #{Id} - Cliente {Cliente}");
        Console.WriteLine($"Valor total: R$ {ValorTotal}");
        Console.WriteLine($"Status: {(ExtaExpirado() ? "Expirado" : "Valido")}");
    }

    public bool ExtaExpirado()
    {
        return !Pago && DateTime.Now > Data.AddMinutes(15);
    }

    public void Pagar()
    {
        Pago = true;
    }
}
