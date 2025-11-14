using PraticandoCSharp;

ProdutoFisico item1 = new ProdutoFisico("Teclado", "Modelo compacto e silencioso, " +
    "perfeito para produtividade diária.",
    80.00m, "Imagem", 10);
Console.WriteLine(@$"Dados do item 2:
    Nome: {item1.Nome};
    Descrição: {item1.Descricao};
    Preço: {item1.Preco};
    Link: {item1.Estoque};
");

ProdutoDigital item2 = new ProdutoDigital("Curso", "OO em C#",
    100.00m, "Imagem ilustrativa", "Link");

Console.WriteLine(@$"Dados do item 2:
    Nome: {item2.Nome};
    Descrição: {item2.Descricao};
    Preço: {item2.Preco};
    Link: {item2.LinkDownload};
");


Produto item3 = new Produto("Caneca", "Caneca personalizada", 30.00m, "Imagem da caneca");