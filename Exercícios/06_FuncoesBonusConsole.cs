using System;
using System.Text;
using System.Threading;

public class FuncoesBonusConsole
{
    public static void Main_06(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Title = "Criação de Personagem";

        Console.BackgroundColor = ConsoleColor.DarkBlue;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("--- INFORMAÇÕES ---");
        Console.ResetColor();

        Console.Write("Digite o seu nome: ");

        string? respostaNome = Console.ReadLine();

        Console.Write("Digite a sua idade: "); ;
        string? respostaIdade = Console.ReadLine();

        int idade;

        bool sucesso = int.TryParse(respostaIdade, out idade);

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("--- Informações obtidas! ---");
        Console.ResetColor();
        Console.WriteLine($"Nome: {respostaNome}");
        Console.WriteLine($"Idade: {idade}");
    }
}
/*
---------------------------------------------------------------------------
EXPLICAÇÃO

* Comece declarando a classe FuncoesBonusConsole

Troque:
    public static void Main_06(string[] args)
para:
    public static void Main(string[] args)

* Essas são algumas funções bônus do Console. Você pode alterar a cor da fonte, seu
    background, estabelecer um título no terminal etc. É interessante dar uma olhada
    na documentação do C# para entender quais comandos podemos explorar na linguagem.

OBS: Note que abrimos um booleano ali apenas para informar ao programa
    se nossa conversão foi bem sucedida ou não.

---------------------------------------------------------------------------
EXERCÍCIO - 06

- Desenvolva um programa que exiba um texto em verde e um texto em vermelho no console.
*/