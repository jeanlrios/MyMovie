using MyMovie.Filmes;

void Opcoes()
{
    Console.WriteLine("Bem vindo ao MyMovie\n");
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("Opção 1: Ver o top 5 de filmes mais avaliados");
    Console.WriteLine("Opção 2: Exibir todos os filmes");
    Console.WriteLine("Opção 3: Adicionar um filme");
    Console.WriteLine("Opção 4: Adicionar elenco a um filme\n");
    Console.Write("Informe a opção que deseja acessar: ");
    int OpcaoEscolhida = int.Parse(Console.ReadLine());
    switch (OpcaoEscolhida)
    {
        case 1: VerTop5();
            break;
    }
}

void VerTop5()
{
    Console.Clear();
    List<Filme> listaMelhoresFilmes = new List<Filme> {
        new Filme("Um Sonho de Liberdade", 142, new List<Artista> {new Artista("Tim Robbins"), new Artista("Morgan Freeman") }),
        new Filme("O Poderoso Chefão", 175, new List<Artista> { new Artista("Marlon Brando"), new Artista("Al Pacino"), new Artista("Talia Shire") }),
        new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista> { new Artista("Christian Bale"), new Artista("Heath Ledger"), new Artista("Maggie Gyleenhaal") }),
        new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista> { new Artista("Elijah Wood"), new Artista("Ian McKellen"), new Artista("Viggo Mortensen") }),
        new Filme("Green Book - O Guia", 130, new List<Artista> { new Artista("Viggo Mortensen"), new Artista("Mahershala Ali") }),
    };
    foreach (Filme filme in listaMelhoresFilmes)
    {
        Console.WriteLine($"Filme: {filme.Titulo}\nDuração: {filme.Duracao} min");
        filme.MostrarElenco();
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Para voltar para o menu digite qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    Opcoes();
}


Opcoes();