
using System; 
using System.Text; 
 
public class VariaveisComEntradaDeDados
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Digite seu nome aqui embaixo");
        string meuNome = Console.ReadLine();

        Console.WriteLine("Você está em um sistema Windows?");
        string? minhaResposta = Console.ReadLine();
    }
}

// ---------------------------------------------------------------------------
// EXPLICAÇÃO

// * Comece declarando a classe VariaveisComEntradaDeDados

// * [Console.ReadLine] - É o comando que nos permite escrever uma mensagemn no console

// * [string] - Significa o tipo da várivel (texto). Os demais tipos são semalhantes às demais linguagens:
//              -> [char] - Caracter único
//              -> [int] - Números inteiros
//              -> [float] - Números decimais (Lembre-se de sempre separar as casas com "." e de 
//                              adicionar "f" no final do número. Ex: 75.3f).
//                              Se quisermos limitar a apresentação de um float no console, podemos
//                              adicionar uma condição na sua exibição. Devemos escrever F(numero de casas)
//                              que queremos mostrar. Exemplo de uso:

//                              # Exemplo de uso:
//                              ---------------------------
//                              float numeroTeste = 85.9289483f
//                              Console.WriteLine("O número é: {numeroTeste:F2}")
//                              (No console): 85,93 
//                              ---------------------------

//                              Note que ele por si só arredonda o valor. Para evitar isso você pode utilizar
//                                  o Math.Truncate().

//              -> [bool] - Booleano podendo ser [true] ou [false]
//              -> [object] - Atenção: Esse é um tipo genérico e deve ser evitado para preservar a segurança 
//                              do tipo do dado. 

//                              # Exemplo de uso:
//                              ---------------------------
//                              object nomeDaVariavel = 10;
//                              nomeDaVariavel = "Agora sou um texto";
//                              ---------------------------

//                              Aqui em cima começamos com um inteiro e depois o transformamos em string.

//              -> [Outros...] 

// * [string?] - Significa que a variável pode ser null (ou seja, valor nulo). Esse caso será útil 
//                  para sinalizar valores ausentes ou que não foram definidos. Caso deixemos
//                  sem a "?" significa que a referência NÃO permite null. Espera-se que 
//                  sempre haja um valor ali, mesmo que seja " ".

// ---------------------------------------------------------------------------
// EXERCÍCIO - 02
// Desenvolva um programa que requere ao usuário duas respostas em string.