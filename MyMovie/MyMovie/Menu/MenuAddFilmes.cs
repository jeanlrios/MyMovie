using MyMovie.Filmes;

namespace MyMovie.Menu
{
    internal class MenuAddFilmes : Menu
    {
        public override void Executar(List<Filme> listaMelhoresFilmes)
        {
            base.Executar(listaMelhoresFilmes);
            ExibirTitulo("Adicionar um novo filme ao sistema");
            Console.Write("Nome do filme: ");
            string nomeFilme = Console.ReadLine()!;
            Console.Write("Duração do filme (minutos): ");
            int duracaoFilme = int.Parse(Console.ReadLine()!);
            Console.Write("Informe um ator do filme: ");
            string atorFilme = Console.ReadLine()!;
            Console.WriteLine($"\nAtor/atriz {atorFilme} adicionado ao filme {nomeFilme}\n");
            Filme novoFilme = new(nomeFilme, duracaoFilme, [new(atorFilme)]);
            listaMelhoresFilmes.Add(novoFilme);
            Console.WriteLine($"\nFilme {nomeFilme} foi cadastrado com sucesso!");
            VoltarMenu();
        }
    }
}
