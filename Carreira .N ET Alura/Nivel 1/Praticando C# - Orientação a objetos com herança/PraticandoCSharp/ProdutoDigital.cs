namespace PraticandoCSharp;
internal class ProdutoDigital : Produto
{
    private string linkDownload;
    private DateTime DataCompra;

    public ProdutoDigital(string nome, string descricao, decimal preco, string imagem, string linkDowlaod) : base(nome, descricao, preco, imagem)
    {
        this.LinkDownload = linkDowlaod;
    }
    public string LinkDownload
    {
        get { return linkDownload; }
        set
        {
            if (value.Length > 0)
            {
                linkDownload = value;
            }
        }
    }

    public bool EstaExpirado()
    {
        return DateTime.Now > DataCompra.AddYears(2);
    }
}
