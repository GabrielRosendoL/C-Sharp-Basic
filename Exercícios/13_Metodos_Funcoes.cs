using System;
using System.Text;

public class Metodos_Funcoes
{
    public static void Main_13(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("O método Main começou.");

        ExibirMensagem();

        Console.WriteLine("O método Main está prestes a terminar.");
    }

    public static void ExibirMensagem()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\n------------------------------------------------");
        Console.WriteLine("Esta mensagem está vindo de um método separado!");
        Console.WriteLine("------------------------------------------------\n");
        Console.ResetColor();
    }
}

/*
---------------------------------------------------------------------------

EXPLICAÇÃO

* Comece declarando a classe Metodos_Funcoes

Troque:
    public static void Main_13(string[] args)
para:
    public static void Main(string[] args)

* Devemos considerar que o método Main é, como o póprio nome sugere, nosso método principal.
    Isso signfica que ele sempre será chamado com prioridade. Portanto, é importante que consideremos
    que ele funciona como uma espécie de "Gerenciador Geral".

* É de uma melhor prática utilizar o conceito de Funções (que é a declaração de outros Métodos). 
    Em resumo, se você tem alguma certa ação que ocorrerá no seu código (principalmente se for uma ação
    que vá ser repetida mais vezes) é mais interessante colocar ela dentro de um método fora do escopo
    principal, e por sua vez chamá-la quando for necessário. 

* No exemplo de cima temos um método chamado ExibirMensagem, que ao ser chamado no Main acaba por
    ser executado. Após ele ser finalizado, o Main prossegue executando seus próximos passos.

* Ele foi declado como [public static] para poder ser lido pelo Main e recebeu [void] pois
    essa função não retorna nenhum valor, apenas executa um comando.
---------------------------------------------------------------------------

EXERCÍCIO - 13

- Desenvolva um programa tenha um método separado do Main.
- Dentro do Main, peça para o usuário digitar um número.
- Armazene esse valor.
- A função separada será responsável por exibir qual foi o
    valor digitado pelo usuário.
- Chame a função criada dentro do método Main.
*/