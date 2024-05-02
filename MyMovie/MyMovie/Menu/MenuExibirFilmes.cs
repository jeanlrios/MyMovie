using MyMovie.Filmes;

namespace MyMovie.Menu
{
    internal class MenuExibirFilmes : Menu
    {
        public override void Executar(List<Filme> listaMelhoresFilmes)
        {
            base.Executar(listaMelhoresFilmes);
            ExibirTitulo("Todos os filmes registrados");
            foreach (Filme filme in listaMelhoresFilmes)
            {
                Console.WriteLine($"Filme: {filme.Titulo}\nDuração: {filme.Duracao} min");
                filme.MostrarElenco();
                Console.WriteLine();
            }
            Console.WriteLine();
            VoltarMenu();          
        }
    }
}
