using System;
using System.Text;

public class Parse
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Informe quantos animais você possui em casa (digite em números, não tem texto): ");
        string respostaDoUsuario = Console.ReadLine();

        int numeroDeAnimais = int.Parse(respostaDoUsuario);

        Console.WriteLine($"Você possui {numeroDeAnimais} animais.");
    }
}


// ---------------------------------------------------------------------------
// EXPLICAÇÃO

// * Comece declarando a classe Parse

// * Naturalmente o [Console.ReadLine()] lerá strings. Portanto, se precisarmos armazenar um dado em um 
//      tipo que não seja uma string teremos que fazer uma conversão.

// Para isso, basta criar uma nova variável com o tipo desejado e utilizar o comando [Parse()].
// Declaramos uma nova variável do tipo desejado e a nomeamos [numeroDeAnimais]. Então utilizamos 
//      o Parse adequado para ela. Como nesse caso estamos tratando de um inteiro, usaremos
//      o int.Parse e adicionaremos a variável que será convertida dentro de seu 
//      parâmetro: int.Parse(respostaDoUsuario).

// Agora poderemos utilizar a resposta que nos foi dada previamente com um novo tipo.

// OBS: Lembre-se que devemos fazer isso apenas por que o [Console.ReadLine()] enxerga apenas textos.
//      Se a variável for desde o início declarada como um tipo inteiro, ela poderá ser chamada
//      no Console.WriteLine sem problemas.

// ---------------------------------------------------------------------------
// EXERCÍCIO - 04

// Desenvolva um programa que converte a altura em metros do usuário e exibe a resposta no console.