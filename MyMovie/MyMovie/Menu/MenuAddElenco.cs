using MyMovie.Filmes;

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
            Console.Write("Digite o nome do ator/atriz que deseja adicionar: ");
            string nomeAtor = Console.ReadLine()!;
            Artista novoAtor = new Artista(nomeAtor);

            Console.WriteLine("Em breve...\n");
            // Precisa completar o codigo
            {
                Console.WriteLine($"O filme {nomeDoFilme} não está cadastrado.\n");
            Console.WriteLine("Para voltar para o menu digite qualquer tecla");
            Console.ReadKey();
            Console.Clear();
        }        
        Console.WriteLine("Para voltar para o menu digite qualquer tecla");
        Console.ReadKey();
        Console.Clear();
    }
}
}