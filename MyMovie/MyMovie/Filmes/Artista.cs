namespace MyMovie.Filmes;

public class Artista
{
    public Artista(string nome)
    {
        Nome = nome;       
    }
    public string Nome { get; }
    public List<Filme> FilmesAtuados { get; set; }
    public void AdicionarFilme(Filme filme)
    {
        FilmesAtuados.Add(filme);
    }
}