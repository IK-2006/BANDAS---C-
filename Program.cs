//**int notaMedia = 7;
//**if (notaMedia >= 7)
//**{
//**//**Console.WriteLine("Aprovado");
//**}
//**else
//**{
//**Console.WriteLine("Reprovado");
//**}

//**string linguagensProgramacao = "C#, Java, Python, JavaScript";
//**Console.WriteLine(linguagensProgramacao[0]);

//**console.writeline("escreva um numero:");
//**int numero = int.parse(console.readline());

//**int[] lista = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }
//;
//**console.writeline(lista[numero]); **//

//console.writeline("digite um número de 1 a 100");

//random random = new random();
//int meta = random.next(1, 101);

//int numero;
//do
//{
//    numero = int.parse(console.readline());
//    if (numero < meta)
//    {
//        console.writeline("o número é maior");
//    }
//    if (numero > meta)
//    {
//        console.writeline("o número é menor");
//    }

//}
//while (numero != meta);
//console.writeline("parabens, você acertou o numero segredo");

//using System.Reflection.Metadata;
//using System;
//using System.Collections.Generic;

//void conta()
//{
//    float num1 = 8.5f;
//    float num2 = 2.5f;
//    float adicao = num1 + num2;
//    float subtracao = num1 - num2;
//    float multiplicacao = num1 * num2;
//    float divisao = num1 / num2;
//    Console.WriteLine("Adição: " + adicao);
//    Console.WriteLine("Subtração: " + subtracao);
//    Console.WriteLine("Multiplicação: " + multiplicacao);
//    Console.WriteLine("Divisão: " + divisao);
//}
//;

//conta();

//List<string> bandas = new List<string>() { "Pierce the veil", "Muse", "deftones" };
//foreach (string banda in bandas)
//{
//    Console.WriteLine(banda);
//}

//List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };
//int soma = numeros.Sum();
//Console.WriteLine("Soma dos números: " + soma);


//var NotaAlunos = new Dictionary<string, Dictionary<string, List<int>>>
//{
//    { "João", new Dictionary<string, List<int>> {
//        {"Matemática", new List<int> {8, 9, 7}},
//        {"Português", new List<int> {6, 7, 8}}
//    }
//},
//    {"Maria", new Dictionary<string, List<int>> {
//        {"Matemática", new List<int> {9, 8, 10}},
//        {"Português", new List<int> {7, 8, 9}}
//    } }
//};

//List<int> MediaNotasJoaoMatematica = NotaAlunos["João"]["Matemática"];
//double mediaJoaoMatematica = MediaNotasJoaoMatematica.Average();
//Console.WriteLine($"Média das notas de João em Matemática: {mediaJoaoMatematica}");


//var Produtos = new Dictionary<string, int>
//{
//    { "Calça", 80 },
//    { "Tênis", 120 },
//    { "Camiseta", 40 }
//};

//Console.WriteLine("Digite a opção desejada: ");
//Console.WriteLine("1 - Listar Produtos");
//Console.WriteLine("2 - Quantidade em Estoque");
//int opcaoEscolhida = int.Parse(Console.ReadLine()!);

//switch (opcaoEscolhida)
//{
//    case 1:
//        Console.Clear();
//        foreach (var produto in Produtos)
//        {
//            Console.WriteLine($"{produto.Key} ");
//        }
//        break;
//    case 2: foreach (var produto in Produtos)
//        {
//            Console.WriteLine($"{produto.Key}: {produto.Value} unidades");
//        }break;
//}


//var Quiz = new Dictionary<string, string>
//{
//    { "Qual a capital da França?", "Paris" },
//    { "Qual o maior planeta do sistema solar?", "Júpiter" },
//    { "Quem escreveu 'Dom Quixote'?", "Miguel de Cervantes" }
//};

//Console.WriteLine("Bem-vindo ao Quiz! Responda às perguntas abaixo:");
//foreach (var pergunta in Quiz)
//{
//    Console.WriteLine(pergunta.Key);
//    string respostaUsuario = Console.ReadLine()!;
//    if (respostaUsuario.Equals(pergunta.Value, StringComparison.OrdinalIgnoreCase))
//    {
//        Console.WriteLine("Resposta correta!");
//    }
//    else
//    {
//        Console.WriteLine($"Resposta incorreta! A resposta correta é: {pergunta.Value}");
//    }
//}


var login = new Dictionary<string, string>
{
    {"inacio", "123" },
    {"admin", "admin" }
};

Console.WriteLine("Digite seu usuário e sua senha:");
Console.WriteLine("Usuario: ");
string usuario = Console.ReadLine()!;
Console.WriteLine("Senha: ");
string senha = Console.ReadLine()!;

if (login.ContainsKey(usuario) && login[usuario] == senha)
{
    Console.WriteLine("Login bem-sucedido!");
}
else
{
    Console.WriteLine("Usuário ou senha incorretos.");
}


