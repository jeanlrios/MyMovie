using MyMovie.Filmes;

namespace MyMovie.Menu
{
    internal class Menu
    {
        public void ExibirTitulo(string titulo)
        {
            int totalLetras = titulo.Length;
            string asteriscos = string.Empty.PadLeft(totalLetras, '*');
            Console.WriteLine(asteriscos);
            Console.WriteLine(titulo);
            Console.WriteLine(asteriscos + "\n");
        }
        public virtual void Executar(List<Filme> listaMelhoresFilmes)
        {
            Console.Clear();
        }

        public void VoltarMenu()
        {
            Console.Write("\nPara voltar para o menu digite qualquer tecla");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
