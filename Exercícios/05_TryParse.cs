using System;
using System.Globalization;
using System.Text;

public class TryParse
{
    public static void Main_05(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("Olá! Por favor, digite a sua idade: ");
        string respostaDoUsuario = Console.ReadLine();

        int idadeConvertida;

        if (int.TryParse(respostaDoUsuario, out idadeConvertida))
        {

            Console.WriteLine("\nObrigado! Idade registrada com sucesso.");
            Console.WriteLine($"Você tem {idadeConvertida} anos.");
        }
        else
        {
            Console.WriteLine("\nErro: O valor que você digitou não é uma idade válida.");
            Console.WriteLine($"O texto '{respostaDoUsuario}' não pôde ser convertido para um número.");
        }

        Console.WriteLine("\nO programa terminou.");
    }
}

// ---------------------------------------------------------------------------
// EXPLICAÇÃO

// * Comece declarando a classe TryParse

// Troque:
//      public static void Main_05(string[] args)
// para:
//      public static void Main(string[] args)

// * Agora veremos o [TryParse]. Ele tem o mesmo intuito do Parse: realizar uma conversão. Porém faz isso de
//      maneira mais robusta. Imagine uma situação em que o usuário passa um valor em um Parse que não pode 
//      ser convertido para o tipo requerido. Exemplo: passar a string "quatro" ao invés de "4". Isso causa
//      um erro e o programa não consegue prosseguir. Como alternativa, podemos utilizar o [TryParse], que 
//      TENTARÁ realizar a conversão. Caso não consiga, realiza outro comportamento.
//      
// * Nesse código, utilizamos a estrutura de decisão [if / else]. O programa realizará um
//      comportamento X caso o argumento que passamos dentro dos parâmetros de [if] for verdadeiro.
//      Se esse comportamento for false, ele entrará no bloco [else] e realizará o comportamento que
//      estabelecemos lá dentro. No fim de qualquer que seja o caso, exibiremos uma mensagem informando
//      que o programa foi encerrado.
//      
// * Para fornecer a estrutura de [TryParse], podemos colocar ela dentro do parâmetro do [if].      
//      No nosso exemplo fizemos: (int.TryParse(respostaDoUsuario, out idadeConvertida)). Ou seja,
//      passamos primeiro a variável que será convertida [respostaDoUsuario] e depois estabelecemos
//      a variável que receberá esse valor convertido (idadeConvertida). Lembre-se que o [, out] faz
//      parte da estrtutura padrão do [TryPase].
//
//          OBS: Você deve declarar a variável que receberá o valor convertido ANTES de utilizar 
//                  o [TryPase]. Isso inclusive nos permite entender que, alocando um novo valor
//                  nessa variável (idadeConvertida), quando a nossa estrutura de decisão terminar,
//                  o valor de [idadeConvertida] irá perdurar, uma vez que não é parte exclusiva 
//                  da estrutura de decisão, mas sim de uma lógica fora dela.

// ---------------------------------------------------------------------------
// EXERCÍCIO - 05

// Desenvolva um programa que pergunta ao usuário qual o peso de sua mochila.
// Exiba sua resposta limitando o número da resposta em até no máximo 2 casas decimais.
// Caso o usuário digite algo que não se encaixe do tipo estabelecido por você, informe isso
// em uma mensagem para que o usuário saiba que a conversão não funcionou.

// Independente dos casos, exiba uma mensagem final que dirá: "Fim da aplicação".