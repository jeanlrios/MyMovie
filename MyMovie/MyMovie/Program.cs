using MyMovie.Filmes;
using MyMovie.Menu;
//using (HttpClient client = new HttpClient())
//{
    //try
    //{

    //}
    //catch ESTOU ESPERANDO APRENDER MAIS SOBRE API PRA COLOCAR AQUI NO PROJETO :/
    //{
        
    //}
//}

List<Filme> listaMelhoresFilmes = new List<Filme>
{
        new Filme("Um Sonho de Liberdade", 142, new List<Artista> { new Artista("Tim Robbins"), new Artista("Morgan Freeman") }),
        new Filme("O Poderoso Chefão", 175, new List<Artista> { new Artista("Marlon Brando"), new Artista("Al Pacino"), new Artista("Talia Shire") }),
        new Filme("Batman - O Cavaleiro das Trevas", 152, new List<Artista> { new Artista("Christian Bale"), new Artista("Heath Ledger"), new Artista("Maggie Gyleenhaal") }),
        new Filme("Senhor dos Anéis - O Retorno do Rei", 201, new List<Artista> { new Artista("Elijah Wood"), new Artista("Ian McKellen"), new Artista("Viggo Mortensen") }),
        new Filme("Green Book - O Guia", 130, new List<Artista> { new Artista("Viggo Mortensen"), new Artista("Mahershala Ali") })
};
void Opcoes()
{
    Console.WriteLine("Bem vindo ao MyMovie\n");
    Console.WriteLine("Escolha uma das opções abaixo:");
    Console.WriteLine("Opção 1: Exibir todos os filmes");
    Console.WriteLine("Opção 2: Adicionar um filme");
    Console.WriteLine("Opção 3: Adicionar elenco a um filme");
    Console.WriteLine("Opção 4: Sair do sistema\n");
    Console.Write("Informe a opção que deseja acessar: ");
    int OpcaoEscolhida = int.Parse(Console.ReadLine()!);
    switch (OpcaoEscolhida)
    {
        case 1: 
            MenuExibirFilmes menu1 = new MenuExibirFilmes();
            menu1.Executar(listaMelhoresFilmes);
            Opcoes();
            break;
        case 2: 
            MenuAddFilmes menu2 = new MenuAddFilmes();
            menu2.Executar(listaMelhoresFilmes);
            Opcoes();
            break;
        case 3:
            MenuAddElenco menu3 = new MenuAddElenco();
            menu3.Executar(listaMelhoresFilmes);
            Opcoes();
            break;
        case 4:
            MenuSair menu4 = new MenuSair();
            menu4.Executar(listaMelhoresFilmes);
            break;
        default:
            Console.WriteLine("Opção invalida!");
            break;
    }
}

Opcoes();