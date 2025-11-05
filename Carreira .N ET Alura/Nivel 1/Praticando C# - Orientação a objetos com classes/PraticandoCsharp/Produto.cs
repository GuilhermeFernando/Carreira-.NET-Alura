namespace PraticandoCsharp;

public class Produto
{
    public string Nome { get; set; }
    public string Descricao { get; set; }
    public int Estoque { get; set; }
    public decimal  Preco { get; set; }
    public bool  Disponivel()
    {
        return Estoque >0;
    }

    public void AlterarPrecoDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto);
    }
}
