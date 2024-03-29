﻿//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela.

Dictionary<string, List<int>> listaDeAlunos = new Dictionary<string, List<int>>();

listaDeAlunos.Add("Matheus", new List<int> { 6, 9, 5, 10 });
listaDeAlunos.Add("Maria", new List<int> { 8, 9, 10, 10 });
listaDeAlunos.Add("João Pedro", new List<int> { 6, 7, 8, 7 });
listaDeAlunos.Add("Alice", new List<int> { 5, 7, 5, 8 });

string menssagemInicial = "Olá, bem vindo ao portal de notas!";

void Apresentacao()
{
    Console.Clear();
    Console.WriteLine(@"
██████╗░░█████╗░██████╗░████████╗░█████╗░██╗░░░░░  ██████╗░███████╗  ███╗░░██╗░█████╗░████████╗░█████╗░░██████╗
██╔══██╗██╔══██╗██╔══██╗╚══██╔══╝██╔══██╗██║░░░░░  ██╔══██╗██╔════╝  ████╗░██║██╔══██╗╚══██╔══╝██╔══██╗██╔════╝
██████╔╝██║░░██║██████╔╝░░░██║░░░███████║██║░░░░░  ██║░░██║█████╗░░  ██╔██╗██║██║░░██║░░░██║░░░███████║╚█████╗░
██╔═══╝░██║░░██║██╔══██╗░░░██║░░░██╔══██║██║░░░░░  ██║░░██║██╔══╝░░  ██║╚████║██║░░██║░░░██║░░░██╔══██║░╚═══██╗
██║░░░░░╚█████╔╝██║░░██║░░░██║░░░██║░░██║███████╗  ██████╔╝███████╗  ██║░╚███║╚█████╔╝░░░██║░░░██║░░██║██████╔╝
╚═╝░░░░░░╚════╝░╚═╝░░╚═╝░░░╚═╝░░░╚═╝░░╚═╝╚══════╝  ╚═════╝░╚══════╝  ╚═╝░░╚══╝░╚════╝░░░░╚═╝░░░╚═╝░░╚═╝╚═════╝░");

    Console.WriteLine($"\n{menssagemInicial}\n");
    ExibirOpcoesDeMenu();
}

void ExibirOpcoesDeMenu()
{
    Console.WriteLine("1. Listar alunos");
    Console.WriteLine("2. Exibir notas de um aluno");
    Console.WriteLine("3. Calcular a média do aluno");
    Console.WriteLine("4. Sair");
    Console.Write("\nDigite a opção desejada: ");
    int opcaoEscolhida = int.Parse(Console.ReadLine()!);

    switch (opcaoEscolhida)
    {
        case 1: ListarAlunos();
            break;
        case 2:
            ExibirNotas();
            break;
        case 3:
            CalcularMedia();
            break;
        case 4:
            Console.WriteLine($"\nVocê escolheu sair!\nAté mais! :)");
            break;
        default:
            Console.WriteLine($"Opção escolhida não existe!");
            Console.WriteLine("Digite qualquer tecla para voltar ao menu inicial");
            Console.ReadKey();
            Apresentacao();
            break;
    }
}

void ListarAlunos()
{
    Console.Clear();
    ExibirTituloDaOpcao("Lista de Alunos");
    foreach (string aluno in listaDeAlunos.Keys)
    {
        Console.WriteLine(aluno);
    }
    Console.WriteLine("\nDigite qualquer tecla para volta ao menu");
    Console.ReadKey();
    Apresentacao();
}

void ExibirNotas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir notas");
    Console.Write("Digite o nome do aluno que deseja visualizar as notas: ");
    string nomeDoAluno = Console.ReadLine()!;

    if (listaDeAlunos.ContainsKey(nomeDoAluno))
    {
        Console.WriteLine($"\nCarregando as notas de {nomeDoAluno}\n");
        Thread.Sleep(1000);
        foreach (int nota in listaDeAlunos[nomeDoAluno])
        {
            Console.WriteLine(nota);
        }
        Console.WriteLine("\nDigite qualquer tecla para volta ao menu");
        Console.ReadKey();
        Apresentacao();
    }
    else
    {
        Console.WriteLine("Aluno inexistente!");
        Console.WriteLine("\nDigite qualquer tecla para volta ao menu");
        Console.ReadKey();
        Apresentacao();
    }
}

void CalcularMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Calcular média");
    Console.Write("Digite o nome do aluno que deseja calcular a média: ");
    string nomeDoAluno = Console.ReadLine()!;

    if (listaDeAlunos.ContainsKey(nomeDoAluno))
    {
        Console.WriteLine($"\nCalculando a média de {nomeDoAluno}\n");
        Thread.Sleep(1000);
        List<int> mediaDoAluno = listaDeAlunos[nomeDoAluno];
        Console.WriteLine($"A média de {nomeDoAluno} é de: {mediaDoAluno.Average()}");
        Console.WriteLine("\nDigite qualquer tecla para volta ao menu");
        Console.ReadKey();
        Apresentacao();
    }
    else
    {
        Console.WriteLine("Aluno inexistente!");
        Console.WriteLine("\nDigite qualquer tecla para volta ao menu");
        Console.ReadKey();
        Apresentacao();
    }
}

void ExibirTituloDaOpcao(string titulo)
{
    int qntLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(qntLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine($"{asteriscos}\n");
}

Apresentacao();