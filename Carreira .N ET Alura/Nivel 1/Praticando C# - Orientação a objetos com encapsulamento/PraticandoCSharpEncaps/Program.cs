using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Criando um objeto da classe Produto
        Produto item1 = new Produto("Produto 1", "Descrição do Produto 1", 19.99m, 10, "imagem1.jpg");

        // Acessando as propriedades do objeto
        Console.WriteLine($"Nome: {item1.Nome}");
        Console.WriteLine($"Descricao: {item1.Descricao}");
        Console.WriteLine($"Preco: {item1.Preco}");
        Console.WriteLine($"Estoque: {item1.Estoque}");
        Console.WriteLine($"Imagem: {item1.Imagem}");

        // Alterando a imagem usando a propriedade
        item1.Imagem = "nova_imagem.jpg";
        Console.WriteLine($"Nova Imagem: {item1.Imagem}");

        // Alterando o preço com desconto usando o método
        item1.AlterarPrecoComDesconto(0.1m); // 10% de desconto
        Console.WriteLine($"Preço com desconto: {item1.Preco}");
    }
}