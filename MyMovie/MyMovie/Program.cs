using MyMovie.Filmes;

List<Filme> listaMelhoresFilmes = [
        new("Um Sonho de Liberdade", 142, [new("Tim Robbins"), new("Morgan Freeman")]),
        new("O Poderoso Chefão", 175, [new("Marlon Brando"), new("Al Pacino"), new("Talia Shire")]),
        new ("Batman - O Cavaleiro das Trevas", 152, [new("Christian Bale"), new("Heath Ledger"), new("Maggie Gyleenhaal")]),
        new("Senhor dos Anéis - O Retorno do Rei", 201, [new("Elijah Wood"), new("Ian McKellen"), new("Viggo Mortensen")]),
        new("Green Book - O Guia", 130, [new("Viggo Mortensen"), new("Mahershala Ali")]),
];
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
    Filme novoFilme = new(nomeFilme, duracaoFilme, [new(atorFilme)]);
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
    Console.Write("Digite o nome do ator/atriz que deseja adicionar: ");
    string nomeAtor = Console.ReadLine()!;
    Artista novoAtor = new(nomeAtor);
    Console.Write($"Qual filme o ator/atriz {nomeAtor} será inserido: ");
    string filme = Console.ReadLine()!;
    Console.WriteLine("Em breve...\n");
    Console.WriteLine("Para voltar para o menu digite qualquer tecla");
    Console.ReadKey();
    Console.Clear();
    Opcoes();
}


Opcoes();