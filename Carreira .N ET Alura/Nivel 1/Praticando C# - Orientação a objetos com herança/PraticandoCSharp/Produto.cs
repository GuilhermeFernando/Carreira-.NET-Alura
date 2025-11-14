namespace PraticandoCSharp;
abstract class Produto
{
    public string Nome { get;  }
    public string Descricao { get; }
    public decimal Preco { get; set; }
    public string imagem { get; private set; }

    public Produto(string nome, string descricao, decimal preco, string imagem)
    {        
        this.Nome = nome;
        this.Descricao = descricao;
        this.Preco = preco;
        this.imagem = imagem;
    }

    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco * (1 - desconto / 100);

    }

    public string Imagem
    {
        get
        {
            return imagem;
        }
        set
        {
            if(value.Length > 0)
            {
                this.imagem = value;
            }
        }
    }

}