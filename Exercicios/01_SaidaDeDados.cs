
using System; 
using System.Text; 
 
public class SaidaDeDados
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Hello, World!");
        
        Console.WriteLine("A acentuação está funcionando.");
    }
}

// ---------------------------------------------------------------------------
// EXPLICAÇÃO
// * System é a biblioteca fundamental para codar em C#
// * A .Text traz a possibilidade de acentuarmos os textos

// * Comece declarando a classe SaidaDeDados

// * [public static void Main(string [] args)] - É o nosso ponto de entrada
// * Esse é nosso ponto de entrada. É a primeira coisa que o C# procura para executar quando o programa roda.
// * OBS:
    // * -> [public] - Significa que esse é um método público e pode ser acessado e chamado por 
    //                  qualquer parte do sistema.
    // * -> [static] - Significa que o método que criamos (ou seja, [Main]) pertence a classe em si, e 
    //                  não a um objeto dessa classe (instância).
    // * -> [void] - Significa que o método não retorna nenhum valor. Ele simplesmente executa e termina.
    // * -> [Main] - Siginica o nome do método. Por padrão, o C# sempre procura por "Main" para definir 
    //                  o ponto de entrada.
    // * -> [string[]] - Siginica que o tipo do nosso método é um array de strings. Deve ser um array de strings 
    //                      pois estamos passando linhas de comando para o terminal. O fato de abrirmos um array 
    //                      com [] faz com que o programa entenda que ele vai receber mais de uma instrução. Ou 
    //                      seja, não é apenas uma string, mas sim uma coleção delas. Podemos adicionar informações 
    //                      dentro do array caso necessário.
    // * -> [args] - Nome do nosso array.

// * [Console.OutputEncoding = Encoding.UTF8;] - Garante que o console exiba caracteres especiais e acentos.

// * [Console.WriteLine] - É o comando que nos permite exibir uma mensagemn no console

// ---------------------------------------------------------------------------
// EXERCÍCIO - 01
// Contrua um programa que exiba a exata mensagem: "Utilização do Console.WriteLine e acentuação válida".
