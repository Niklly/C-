// screen sound - nome do app de musica que sera a primeira atividade
string mensagemDeBoasVindas = "Boas vindas ao screen sound!";
//List<string> listaDasBandas = new List<string> {"U2","The Beatles","Calypso"};     //aqui eu adiciono o nome de todas as bandas que digitei

Dictionary<string,List<int>> bandasRegistradas = new Dictionary<string,List<int>>(); //eu criei um dicionario com nome das bandas e os valores de notas
bandasRegistradas.Add("Linkin Park", new List<int> {10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"
░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirOpcoesDoMenu() 
{
    ExibirLogo();   
    Console.WriteLine("\nDigite 1 para registrar uma banda: ");
    Console.WriteLine("Digite 2 para mostrar todas as bandas: ");
    Console.WriteLine("Digite 3 para avaliar uma banda: ");
    Console.WriteLine("Digite 4 para exibir a média de uma banda: ");
    Console.WriteLine("Digite -1 para sair: ");

    Console.WriteLine("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine()!;
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica) 
    {
        case 1: RegistrarBanda();
            break;
        case 2: MostrarBandasRegistradas();
            break;
        case 3: AvaliarUmaBanda();
            break;
        case 4:MediaDeUmaBanda();
            break;
        case -1:
            Console.WriteLine("Tchau tchau )");
            break;
        default: Console.WriteLine("Opção inválida. ");
            break;
    }
    
void RegistrarBanda()
    {
        Console.Clear();
        ExibirTituloDaOpcao("-Registro das bandas-");
        Console.Write("Digite o nome da banda que deseja registrar: ");
        string nomeDaBanda = Console.ReadLine()!;
        bandasRegistradas.Add(nomeDaBanda, new List<int>());
        Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso. ");
        Thread.Sleep(4000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }   


void MostrarBandasRegistradas()
    {
        Console.Clear();
        ExibirTituloDaOpcao("Exibindo todas as bandas registradas");
        
        foreach (string banda in bandasRegistradas.Keys) //a -variavel banda- vai representar cada elemento dentro da listadebanda
        {
            Console.WriteLine($"Banda: {banda}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal: ");
        Console.ReadKey(); //qualquer tecla que for digitada irá voltar ao menu principal
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}


void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeDeLetras = titulo.Length; //vamos criar uma -variavel tipo int- para contar a quanti de caracteres que possui no titulo
    string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*'); //queremos pegar a quant de caracteres a serem inseridos a esquerda e qual será o caractere
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void AvaliarUmaBanda()
{
    //digitar qual banda quer avaliar
    //pesquisar se a banda existe no dicionario >> atribuir uma nota 
    //senão, volta ao menu principal

    Console.Clear();
    ExibirTituloDaOpcao("Avaliar Banda");
    Console.Write("Digite o nome da banda que deseja avaliar: "); //vamos pegar o valor que ela digitou
    string nomeDaBanda = Console.ReadLine()!;
    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        Console.Write($"Qual a nota que a banda {nomeDaBanda} merece: ");
        int nota = int.Parse(Console.ReadLine()!); //a pessoa vai digitar uma nota e esse valor vamos atribuir a uma variavel
        bandasRegistradas[nomeDaBanda].Add(nota);
        Console.WriteLine($"\nA nota {nota} foi registrada com sucesso para a banda {nomeDaBanda}");
        Thread.Sleep(2000);
        Console.Clear();
        ExibirOpcoesDoMenu();

    }else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void MediaDeUmaBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média da banda");
    Console.Write("Digite o nome da banda que deseje saber a média: ");
    string nomeDaBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeDaBanda))
    {
        List<int> notasDaBanda = bandasRegistradas[nomeDaBanda]; //vamos pegar uma lista com todas as notas daquela banda que existe e colocamos em uma variavel chamada notas da banda
        Console.WriteLine($"A média da banda {nomeDaBanda} é {notasDaBanda.Average()}"); //aqui já vamos exibir a média das notas através desse comando -average
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();

    }
    else
    {
        Console.WriteLine($"\nA banda {nomeDaBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }

}
ExibirOpcoesDoMenu();