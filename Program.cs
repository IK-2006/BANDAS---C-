// Screen Sound
string mensagemBoasVindas = "Boas vindas ao Screen Sound!";

Dictionary<string, List<int>> bandas = new Dictionary<string, List<int>>();
bandas.Add("Pierce the Veil" , new List<int> { 7, 6, 8});
bandas.Add("Beatles", new List<int> { 9, 8, 6});


void ExibirLogo()
{
    Console.WriteLine(@"
█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
"); 
    Console.WriteLine(mensagemBoasVindas);
}

void ExibirOpcoesMenu()
{
    ExibirLogo();
    Console.WriteLine("\nEscolha uma das opções abaixo:");
    Console.WriteLine("1 - Registrar uma banda");
    Console.WriteLine("2 - Mostrar todas as bandas");
    Console.WriteLine("3 - Avaliar uma banda");
    Console.WriteLine("4 - Mostrar média de avaliações de uma banda");
    Console.WriteLine("0 - Sair");

    Console.Write("\nDigite a opção desejada: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoConvertida = int.Parse(opcaoEscolhida);
    
    switch (opcaoConvertida)
    {
        case 1: RegistrarBandas();
            break;
        case 2: ; ListarBandas();
            break;
        case 3: AvaliarBanda();
            break;
        case 4: MediaBanda();
            break;
        case 0: Console.WriteLine("Você escolheu a opção " + opcaoConvertida + ". Até mais!");
            break;
        default: Console.WriteLine("Opção inválida! Tente novamente.");
            break;
    }


}

void ExibirTituloOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos);
}




void RegistrarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Registro de Bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeBanda = Console.ReadLine()!;
    bandas.Add(nomeBanda, new List<int>());
    Console.WriteLine($"A banda {nomeBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    Console.Clear();
    ExibirOpcoesMenu();
}

void BandasRegistradas()
{
     foreach (string banda in bandas.Keys)
    {
        Console.WriteLine($"- {banda}");
    };
}

void ListarBandas()
{
    Console.Clear();
    ExibirTituloOpcao("Bandas Registradas");
    Console.WriteLine("As bandas registradas são:\n");
    BandasRegistradas();
    Console.WriteLine("\nPressione qualquer tecla para voltar ao menu.");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Avaliar Bandas");
    BandasRegistradas();
    Console.Write("\nDigite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(nomeBanda))
    {
        Console.Write($"Qual a sua avaliação para a banda {nomeBanda} (de 0 a 10)? ");
        int nota = int.Parse(Console.ReadLine()!);
        bandas[nomeBanda].Add(nota);
        Console.WriteLine($"\nA banda {nomeBanda} foi avaliada com a nota {nota} com sucesso!");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    {
        Console.WriteLine($"\nA banda {nomeBanda} não foi encontrada.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
}

void MediaBanda()
{
    Console.Clear();
    ExibirTituloOpcao("Média de Avaliações");
    BandasRegistradas();
    Console.WriteLine("\nDigite o nome da banda que deseja ver a média de avaliações: ");
    string NomeBanda = Console.ReadLine()!;
    if (bandas.ContainsKey(NomeBanda))
    {
        List<int> notas = bandas[NomeBanda];
        double media = notas.Average();
        Console.WriteLine($"\nA média de avaliações da banda {NomeBanda} é {media}");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesMenu();
    }
    else
    { 
        Console.WriteLine($"\nA banda {NomeBanda} não foi encontrada.");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesMenu();
    }

}
;
ExibirLogo();

ExibirOpcoesMenu();


