using System;
using System.Text;

public class Exibicao
{
    public static void Main_03(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        int numeroDoAno = 2025;

        Console.Write("Por favor, digite o mês em que estamos: ");
        string respostaDoUsuario = Console.ReadLine();

        Console.WriteLine($"Então estamos no mês de {respostaDoUsuario} do ano {numeroDoAno}");

        Console.WriteLine($"O próximo ano será {numeroDoAno + 1}");
    }
}

// ---------------------------------------------------------------------------
// EXPLICAÇÃO

// * Comece declarando a classe Exibicao

// Troque:
//      public static void Main_03(string[] args)
// para:
//      public static void Main(string[] args)

// * Para exibir uma variável no console insira o "$" dentro do parâmetro do Console.WriteLine. Após 
//      isso chame a variável entre { }. 

//      OBS: Também podemos manipular a exibição, assim como fizemos no segundo Console.WriteLine ao
//              adicionar + 1 no valor da variável. Podemos usar qualquer operador aqui (+; -; *; / etc...)

// ---------------------------------------------------------------------------
// EXERCÍCIO - 03
// Desenvolva um programa que declare previavemente a variável do usuário informando sua idade.
// Depois exiba quantos anos ele tinha no ano retrasado.
// E por fim exiba qual o valor de sua idade muktiplicado por 3x.