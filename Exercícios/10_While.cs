// Adicionamos a biblioteca 'Threading' para poder usar a função de pausa (Sleep).
using System;
using System.Text;
using System.Threading;

public class While
{
    public static void Main_10(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        // A classe 'Random' é usada para gerar números aleatórios.
        Random geradorAleatorio = new Random();
        int numeroSecreto = geradorAleatorio.Next(1, 101); // Gera um número entre 1 e 100

        int palpite = 0;
        int tentativas = 0;

        Console.WriteLine("Eu pensei em um número entre 1 e 100. Tente adivinhar!");

        while (palpite != numeroSecreto)
        {
            Console.Write("\nQual é o seu palpite? ");
            string? entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out palpite))
            {
                Console.WriteLine("Entrada inválida. Por favor, digite apenas números.");
                continue; // O 'continue' pula para a próxima volta do laço.
            }

            tentativas++;

            if (palpite < numeroSecreto)
            {
                Console.WriteLine("Muito baixo! Tente um número maior.");
            }
            else if (palpite > numeroSecreto)
            {
                Console.WriteLine("Muito alto! Tente um número menor.");
            }
        }

        Console.WriteLine($"\nParabéns! Você acertou o número secreto, que era {numeroSecreto}!");
        Console.WriteLine($"Você precisou de {tentativas} tentativas.");
    }
}

/*
---------------------------------------------------------------------------

EXPLICAÇÃO

* Comece declarando a classe While

Troque:
     public static void Main_10(string[] args)
para:
     public static void Main(string[] args)

* Agora podemos utilizar uma outra estrutura de repetição muito comum: [While].
    Ao contrário do [For], que possui uma repetição "fixada", o [While] serve
    para repetirmos um comportamento que continuará rodando até que uma condição
    incerta ocorra. Na prática, com o [For] nós definimos de maneira mais "fixa"
    como essa reptição vai acontecer e até quando ela vai acontecer. No [While]
    isso é incerto e o programa tenderá a continuar até que aquilo que estabelecemos
    seja obedecido.
          
* No exemplo acima, temos um programa que randomiza um número e pergunta ao usuário que
    número é esse. O objetivo é que o usuário uma hora acerte o número randomizado.
    Isso se ret=petirá infinitamente, uma vez que o usuário pode repetir o mesmo
    palpite quantas vezes quiser.

* Primeiro iniciamos com um novo conceito: a classse [Random]. Essa classe nos permitirá 
    randomizar um número.
            


---------------------------------------------------------------------------

EXERCÍCIO - 10

Desenvolva um programa que 
*/
