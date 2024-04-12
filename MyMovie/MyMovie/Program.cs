using MyMovie.Filmes;

List<Filme> listaMelhoresFilmes = new List<Filme> {
        new Filme("Um Sonho de Liberdade", 142, new List<Artista> {new Artista("Tim Robbins"), new Artista("Morgan Freeman") }),
        new Filme("O Poderoso Chefão", 175, new List<Artista> { new Artista("Marlon Brando"), new Artista("Al Pacino"), new Artista("Talia Shire") }),
        new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista> { new Artista("Christian Bale"), new Artista("Heath Ledger"), new Artista("Maggie Gyleenhaal") }),
        new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista> { new Artista("Elijah Wood"), new Artista("Ian McKellen"), new Artista("Viggo Mortensen") }),
        new Filme("Green Book - O Guia", 130, new List<Artista> { new Artista("Viggo Mortensen"), new Artista("Mahershala Ali") }),
};
void ExibirTitulo(string titulo)
{
    int totalLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(totalLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}
void Opcoes()
{
    Console.WriteLine("Bem vindo ao MyMovie\n");
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("Opção 1: Exibir todos os filmes");
    Console.WriteLine("Opção 2: Adicionar um filme");
    Console.WriteLine("Opção 3: Adicionar elenco a um filme\n");
    Console.Write("Informe a opção que deseja acessar: ");
    int OpcaoEscolhida = int.Parse(Console.ReadLine());
    switch (OpcaoEscolhida)
    {
        case 1: ExibirFilmes();
            break;
        case 2: AddFilmes();
            break;
        case 3: AddElenco();
            break;
    }
}

void ExibirFilmes()
{
    Console.Clear();
    Console.WriteLine("Carregando...");
    Thread.Sleep(700);
    Console.Clear();
    ExibirTitulo("Todos os filmes cadastrados");
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

void AddFilmes()
{
    Console.Clear();
    Console.WriteLine("Carregando...");
    Thread.Sleep(700);
    Console.Clear();
    ExibirTitulo("Adicionar um novo filme");
    Console.Write("Nome do filme: ");
    string nomeFilme = Console.ReadLine()!;
    Console.Write("Duração do filme (minutos): ");
    int duracaoFilme = int.Parse(Console.ReadLine()!);
    Console.Write("Informe um ator do filme: ");
    string atorFilme = Console.ReadLine()!;
    Filme novoFilme = new Filme(nomeFilme, duracaoFilme, new List<Artista> { new Artista(atorFilme) });
    listaMelhoresFilmes.Add(novoFilme);
    Console.WriteLine($"\nFilme {nomeFilme} foi cadastrado com sucesso!\n");
    Console.WriteLine("Para voltar para o menu digite qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    Opcoes();
}

void AddElenco()
{
    Console.Clear();
    Console.WriteLine("Carregando...");
    Thread.Sleep(700);
    Console.Clear();
    ExibirTitulo("Adicionar elenco a um filme");
    Console.WriteLine("Em breve...\n");
    Console.WriteLine("Para voltar para o menu digite qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    Opcoes();
}


Opcoes();