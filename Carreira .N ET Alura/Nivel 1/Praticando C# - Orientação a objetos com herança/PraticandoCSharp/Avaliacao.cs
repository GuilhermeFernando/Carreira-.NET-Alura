namespace PraticandoCSharp;
internal class Avaliacao
{
    public int Nota { get; set; }
    public string Comentario { get; set; }
    public Avaliacao(int nota, string comentario)
    {
        this.Nota = nota;
        this.Comentario = comentario;
    }
}
