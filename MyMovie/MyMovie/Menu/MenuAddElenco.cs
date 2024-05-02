using MyMovie.Filmes;
using System.ComponentModel.Design;

namespace MyMovie.Menu;

internal class MenuAddElenco : Menu
{
    public override void Executar(List<Filme> listaMelhoresFilmes)
    {
        base.Executar(listaMelhoresFilmes);
        ExibirTitulo("Adicionar elenco ao filme");
        Console.Write("Digite o nome do filme que deseja adicionar elenco: ");
        string nomeDoFilme = Console.ReadLine()!;
        if (listaMelhoresFilmes.Any(a => a.Titulo.Equals(nomeDoFilme)))
        {
            Filme filme1 = listaMelhoresFilmes.First(f => f.Titulo.Equals(nomeDoFilme));
            Console.Write("Digite o nome do ator/atriz que deseja adicionar: ");
            string nomeAtor = Console.ReadLine()!;
            Artista novoAtor = new Artista(nomeAtor);
            filme1.AdicionarAtor(novoAtor);
            Console.WriteLine($"O ator/atriz {novoAtor} foi adicionado ao filme {filme1.Titulo}");
        } else
        {
            Console.WriteLine($"O filme {nomeDoFilme} não está cadastrado.\n");
            VoltarMenu();
        }
        VoltarMenu();
    }
}
