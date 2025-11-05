using PraticandoCsharp.Desafios;
using System;

Livro livro = new Livro();
livro.Titulo = "Dom Casmurro";
livro.Autor = "Machado de Assis";

Console.WriteLine($"Titulo: {livro.Titulo}");
Console.WriteLine($"Autor: {livro.Autor}");
Console.WriteLine("---------------------------------------------------------");

Passagem passagem = new Passagem("João Silva", "Rio de Janeiro");
Console.WriteLine($"Passageiro: {passagem.Passageiro}");
Console.WriteLine($"Destino: {passagem.Destino}");
Console.WriteLine("---------------------------------------------------------");

ContaBancaria conta = new ContaBancaria(12345, 1000.0);
conta.Depositar(500.0);
Console.WriteLine($"Número da Conta: {conta.NumeroConta}");
Console.WriteLine($"Saldo Atual: {conta.Saldo}");
Console.WriteLine("---------------------------------------------------------");

Funcionario funcionario = new Funcionario("Maria Souza", "Analista");
Console.WriteLine($"Nome: {funcionario.Nome}");
Console.WriteLine($"Cargo: {funcionario.Cargo}");
funcionario.Promover("Gerente");
Console.WriteLine($"Novo Cargo: {funcionario.Cargo}");
Console.WriteLine("---------------------------------------------------------");

Retangulo retangulo = new Retangulo(5.0, 8.0);
Console.WriteLine($"Largura: {retangulo.Largura}");
Console.WriteLine($"Altura: {retangulo.Altura}");
Console.WriteLine($"Área: {retangulo.CalcularArea()}");
Console.WriteLine("---------------------------------------------------------");

Filme filme = new Filme("Inception", "Christopher Nolan", 15);
Console.WriteLine($"Título: {filme.Titulo}");
Console.WriteLine($"Diretor: {filme.Diretor}");
Console.WriteLine($"Classificacao Etaria: {filme.ClassificacaoEtaria}");
filme.ExibirResultado(16);
filme.ExibirResultado(1);