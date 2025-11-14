namespace ScreenSound.Menus;

public class MenuAvaliarAlbum : Menu
{
    public override void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        base.Executar(bandasRegistradas);
        ExibirTituloDaOpcao("Avaliar álbum");
        Console.Write("Digite o nome do álbum que deseja avaliar: ");
        string nomeDoAlbum = Console.ReadLine()!;
        Album? albumEncontrado = null;
        foreach (var banda in bandasRegistradas.Values)
        {
            albumEncontrado = banda.Albuns.FirstOrDefault(a => a.Nome.Equals(nomeDoAlbum, StringComparison.OrdinalIgnoreCase));
            if (albumEncontrado != null)
                break;
        }
        if (albumEncontrado != null)
        {
            Console.Write($"Qual a nota que o álbum {nomeDoAlbum} merece: ");
            Avaliacao nota = Avaliacao.Parse(Console.ReadLine()!);
            albumEncontrado.AdicionarNota(nota);
            Console.WriteLine($"\nA nota {nota.Nota} foi registrada com sucesso para o álbum {nomeDoAlbum}");
            Thread.Sleep(2000);
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO álbum {nomeDoAlbum} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
