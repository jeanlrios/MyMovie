﻿namespace MyMovie.Filmes;

public class Filme
{
    public Filme(string titulo, int duracao, List<Artista> elenco)
    {
        Titulo = titulo;
        Duracao = duracao;
        if( elenco == null ) {
            Elenco = new List<Artista>();
        } else
        {
            Elenco = elenco;
        }
    }

    public string Titulo { get; }
    public int Duracao { get; }
    public List<Artista> Elenco { get; }
    private List<Filme> todosFilmes = new List<Filme>();

    public void MostrarElenco()
    {
        if( Elenco.Count == 0 ) {
            Console.WriteLine("Elenco vazio.");
        } else
        {
            Console.WriteLine("Elenco:");
            foreach (Artista artista in Elenco)
            {
                Console.WriteLine($"{artista.Nome}");
            }
        }
    }

    public void AdicionarFilmes(Filme filme)
    {
        todosFilmes.Add(filme);
    }

}