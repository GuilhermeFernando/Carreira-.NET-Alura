public class Produto
{
    // Atributo privado
    private string imagem;

    // Propriedades autoimplementadas
    public string Nome { get; }
    public string Descricao { get; }
    public decimal Preco { get; private set; } // Somente leitura fora da classe
    public int Estoque { get; }

    // Propriedade com lógica para o get e set
    public string Imagem
    {
        get
        {
            return imagem;
        }
        set
        {
            if (value.Length > 0)
            {
                this.imagem = value;
            }
        }
    }

    // Construtor
    public Produto(string nome, string descricao, decimal preco, int estoque, string imagem)
    {
        Nome = nome;
        Descricao = descricao;
        Preco = preco;
        Estoque = estoque;
        this.Imagem = imagem; // Usando a propriedade Imagem para garantir a validação
    }

    // Método para alterar o preço com desconto (só pode ser acessado dentro da classe)
    public void AlterarPrecoComDesconto(decimal desconto)
    {
        Preco = Preco - (Preco * desconto); // Acesso direto à propriedade Preco
    }
}