using System;
using System.Text;

public class DoWhile_Switch
{
    public static void Main_11(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        string escolhaDoUsuario;

        do
        {

            Console.WriteLine("--- MENU PRINCIPAL ---");

            Console.WriteLine("1 - Iniciar Novo Jogo");
            Console.WriteLine("2 - Carregar Jogo");
            Console.WriteLine("3 - Ver Opções");
            Console.WriteLine("0 - Sair do Programa");

            Console.Write("\nDigite sua escolha: ");

            escolhaDoUsuario = Console.ReadLine();

            switch (escolhaDoUsuario)
            {
                case "1":
                    Console.WriteLine("\nIniciando um novo jogo...");
                    Thread.Sleep(1500);
                    break;
                case "2":
                    Console.WriteLine("\nCarregando seu jogo salvo...");
                    Thread.Sleep(1500);
                    break;
                case "3":
                    Console.WriteLine("\nExibindo opções...");
                    Thread.Sleep(1500);
                    break;
                case "0":
                    Console.WriteLine("\nSaindo do programa...");
                    Thread.Sleep(1000);
                    break;
                default:
                    Console.WriteLine("\nOpção inválida! Tente novamente.");
                    Thread.Sleep(1000);
                    break;
            }

        } while (escolhaDoUsuario != "0");

        Console.WriteLine("\nPrograma encerrado.");
    }
}
/*
---------------------------------------------------------------------------

EXPLICAÇÃO

* Comece declarando a classe DoWhile_Switch

Troque:
    public static void Main_11(string[] args)
para:
    public static void Main(string[] args)

* Utilizamos o [do... while] para executar uma certa ação no mínimo 1x vez. Após isso, ele
    verificará a condição. Caso seja true, a ação continuará a ser repetida. Caso seja
    false, o programa passará desse bloco.

* No nosso exemplo, isso ocorre na exibição do menu.

* Aqui temos também uma outra estrutura muito usada, o [switch]. O switch serve para
    requerirmos uma resposta do usuário (que pode ser [int] ou [char]). A depender
    da resposta, o programa executará o comando referente ao case que seja igual
    a resposta que esse usuário forneceu. Cada caso ([case]) do [switch] precisa
    de um [break] para não executar os próximos.

    No nosso exemplo, ele pede para que o usuário digite um número referente a uma
        opções do menu. Para qualquer número que o usuário digitar, oferecemos um
        comportamento diferente. Caso o usuário não digite algo dentro das opções
        disponíveis, temos o [default], que será executado sempre que houver um
        caso inválido.
    
    O programa será encerrado caso o usuário digite "0" pois estamos dizendo que
        essa é a condição do nosso [while]: (escolhaDoUsuario != "0").
---------------------------------------------------------------------------

EXERCÍCIO - 11

- Desenvolva um programa com [do... while] e [switch] que pedirá um número de 20 a 30 ao usuário
- Caso não esteja dentro desse intervalo, encerre o programa.
- Armazene esse número
- Forneça uma lista de opções para ele, onde:
    * Opção "a" - Irá multiplicar esse número por 3
    * Opção "b" - Irá dividir esse número por 2
    * Opção "c" - Irá subtrair 10 desse número
    * Opção "d" - Irá somar 15 a esse número
- Peça para ele escolher uma das opções digitando a letra correspondente
- Caso o usuário digite uma opção inválida, exiba uma mensagem que informará isso
    e peça para ele digitar uma opçõo válida.
- Caso o usuário digite "e" o programa será encerrado.
*/