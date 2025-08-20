using System;
using System.Text;

public class IfElse
{
    public static void Main_08(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int horaAtual = DateTime.Now.Hour;

        Console.WriteLine($"A hora atual do sistema é: {horaAtual} horas.");

        if (horaAtual < 12)
        {
            Console.WriteLine("Bom dia!");
        }
 
        else if (horaAtual < 18)
        {
            Console.WriteLine("Boa tarde!");
        }
       
        else
        {
            Console.WriteLine("Boa noite!");
        }

        Console.WriteLine("\nFim do programa.");
    }
}

// ---------------------------------------------------------------------------

// EXPLICAÇÃO

// * Comece declarando a classe IfElse

// Troque:
//      public static void Main_08(string[] args)
// para:
//      public static void Main(string[] args)

// * Utilizamos a estrutura de decisão [If/Else] para dizer ao código realizar X comportamento
//          caso seja uma verdade. 
//          [if] - "Se" essa condição X for verdadeira, execute isso.
//          [else if] - "Se" a condição X for false, mas essa outra condição Y for 
//          true, então execute isso.
//          [else] - "Se" todas as condições anteriores forem falsas.

//              OBS: * Note que por mais que utilizemos a hora como critério de
//                      decisão, em momento algum requisitamos ela ao usuário.
//                      O que fizemos foi utilizar o [DateTime.Now.Hour], que
//                      automaticamente nos fornece a hora atual do sistema como
//                      um inteiro de 0 até 23.

// ---------------------------------------------------------------------------

// EXERCÍCIO - 08

// Desenvolva um programa que peça ao usuario sua idade.
// Se ele possuir mais de 60 anos, divida sua idade por 2, multiplique o novo resultado por 5 e 
//  exiba no console.
// Se ele tiver de 59 pra baixo, multiplique sua idade por 3 e exiba o resto de sua divisão por 3.
// Depois exiba o resultado.