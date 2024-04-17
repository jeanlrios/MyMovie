using MyMovie.Filmes;

namespace MyMovie.Menu
{
    internal class MenuAddElenco : Menu
    {
        public override void Executar(List<Filme> listaMelhoresFilmes)
        {
            base.Executar(listaMelhoresFilmes);
            ExibirTitulo("Adicionar elenco ao filme");
            Console.Write("Digite o nome do ator/atriz que deseja adicionar: ");
            string nomeAtor = Console.ReadLine()!;
            Artista novoAtor = new(nomeAtor);
            Console.Write($"Qual filme o ator/atriz {nomeAtor} será inserido: ");
            string nomeFilme = Console.ReadLine()!;
            Console.WriteLine("Em breve...\n");
            // Precisa completar o codigo
            Console.WriteLine("Para voltar para o menu digite qualquer tecla");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
