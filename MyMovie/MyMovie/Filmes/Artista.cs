namespace MyMovie.Filmes;

public class Artista
{
    private List<Filme> filmesAtuados = new List<Filme>();
    public Artista(string nome)
    {
        Nome = nome;    
    }
    public string Nome { get; }
    public List<Filme> FilmesAtuados => filmesAtuados;
    public void AdicionarFilme(Filme filme)
    {
        filmesAtuados.Add(filme);
    }
}