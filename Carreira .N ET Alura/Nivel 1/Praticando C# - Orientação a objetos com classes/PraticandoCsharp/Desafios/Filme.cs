namespace PraticandoCsharp.Desafios;
public class Filme
{
    public string Titulo { get; set; }
    public string Diretor { get; set; }
    public int ClassificacaoEtaria { get; set; }
    public Filme(string titulo, string diretor, int classificacaoEtaria)
    {
        Titulo = titulo;
        Diretor = diretor;
        ClassificacaoEtaria = classificacaoEtaria;
    }
    public bool PodeAssistir(int idade)
    {
        return idade >= ClassificacaoEtaria;
    }

    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos pode assistir ao filme " + Titulo + ".");
        }
        else
        {
            Console.WriteLine("Usuário com " + idadeUsuario + " anos não pode assistir ao filme " + Titulo + ".");
        }
    }
}
