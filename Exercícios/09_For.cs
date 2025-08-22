// Adicionamos a biblioteca 'Threading' para poder usar a função de pausa (Sleep).
using System;
using System.Text;
using System.Threading; 

public class For
{
    public static void Main_09(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Iniciando contagem regressiva");

    
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);

            Thread.Sleep(1000); 
        }

        Console.WriteLine("\nFim da contagem");
    }
}
// ---------------------------------------------------------------------------

// EXPLICAÇÃO

// * Comece declarando a classe For

// Troque:
//      public static void Main_09(string[] args)
// para:
//      public static void Main(string[] args)

// * Utilizamos a estrutura de repetição [for] para realizar um loop baseado
//           em condições que passamos dentro de seu parâmetro. No caso do exemplo
//           estamos inicializando uma variável [i] com valor 10. Logo depois estamos
//           dizendo que o loop continuará se repetindo enquanto a segunda condição for
//           verdadeira, que nesse caso é: até que [i] for menor ou igual a 1.
//           Nessa situação, teremos esse loop rodando infinitamente, uma vez que 10 (que
//           foi o valor que atribuimos para [i]) sempre será maior que 1. Porém, na terceira
//           etapa da estrutura, estamos dizendo que [i] receberá um >decremento< de 1 inteiro
//           a cada vez que o loop for executado [i--]. 

// * O [Console.WriteLine(i)] estará nos informando o valor de [i] a cada repetição do loop.

// * Utilizamos o [Thread.Sleep(1000)] através do [using System.Threading] para pausarmos o 
//          programa por 1 segundo (passamos '1000' pois ele é lido em miléssimos).                   

// ---------------------------------------------------------------------------

// EXERCÍCIO - 08

// Desenvolva um programa que peça ao usuario um número de 2 a 5.
// Caso não seja um número entre 2 e 5, encerre o programa.
// Faça com que o console exiba a multiplição contínua desse número
//      por 3 vezes seguidas e então encerre o programa.
//      Exemplo: Usuário digita 2.
//                  Logo: 2 * 2 * 2 = 8.