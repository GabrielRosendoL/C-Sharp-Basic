using System;
using System.Globalization;
using System.Text;

public class Arrays_Foreach

{
    public static void Main_12(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        double[] notas = new double[4];

        Console.WriteLine("--- Cadastro de Notas da Turma ---");

        for (int i = 0; i < notas.Length; i++)
        {

            while (true)
            {
                Console.Write($"Digite a {i + 1}ª nota: ");
                string? entrada = Console.ReadLine();

                if (double.TryParse(entrada, CultureInfo.InvariantCulture, out double notaDigitada))
                {
                    notas[i] = notaDigitada;
                    break;
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Digite um número válido.");
                }
            }
        }

        Console.WriteLine("\n--- Notas Registradas ---");
        double soma = 0;

        foreach (double nota in notas)
        {
            Console.WriteLine($"Nota: {nota}");
            soma += nota;
        }

        double media = soma / notas.Length;

        Console.WriteLine($"\nA soma de todas as notas é: {soma}");
        Console.WriteLine($"A média da turma é: {media:F2}");
    }
}
/*
---------------------------------------------------------------------------

EXPLICAÇÃO

* Comece declarando a classe DoWhile_Switch

Troque:
    public static void Main_12(string[] args)
para:
    public static void Main(string[] args)

* As variáveis conseguem armazenar um valor X dentro delas, mas podem haver situações
    em que precisaremos armazenar mais de um valor para um certo tipo de dado.

* No exemplo acima, fazemos isso para colocar as notas dos alunos dentro de uma
    "gaveta". Para declarar um array (lista) passamos o seu tipo (ex: double) e 
    seguimos abrindo e fechando colchetes. É justamente isso que fazemos ao declarar
    nosso método Main por exemplo, que é um array de strings chamada "args".

        Exemplo: double[] notas = new double[4];
        OBS: Os índices (ou seja, as posições) dentro de um array começam a partir
        do 0. Sendo assim, se armazenarmos as notas "nota_01", "nota_02" e "nota_03"
        teremos um array que vai até o índice 2, já que as posições seriam 0, 1 e 2.

* No nosso for, como o nome do array pode variar, nós podemos usar o ".Lenght" após
    chamarmos a lista para que ele pegue todo o tamanho do array. Se declaramos que
    o array "notas" possui tamanho 4, então ao usarmos "notas.Lenght" no for, estamos
    pegando 4 índices como parâmetro.

* E após isso entramos em um [while] que recebe "true" como parâmetro.

----- BREAK -----

* Certo, só pra repassar tudo o que está acontecendo até agora:
    - Ainda não pedimos nada ao usuário, apenas declaramos que haverá uma lista chaamda "notas".
    - Abrimos um for que irá se repetir uma quantidade X de vezes. Nesse caso, pedimos para que
        ele se repita enquanto a nossa variável [i] for MENOR que o tamanho desse array.
        Fazemos isso pois [i] começa em 0. Então a lógica seria: 0, 1, 2 e 3 (4x vezes, que é
        justamente o que precisamos). A cada fim desse laço, incrementaremos + 1 à variável [i].
    - Depois entreremos no nosos [while (true)]. Mas o que isso quer dizer na prátrica? Simples:
        estamos dizendo que enquanto a nossa condição anterior for verdadeira (ou seja, [i] < 4)
        então realize todos os comandos que colocarmos dentro do while.

----- CONTINUE -----

* Agora prosseguindo o nosso comportamento, o que acontece dentro do while? Primeiro que ao
    informarmos ao usuário o número da nota, lembre-que se [i] começa com "0", então para deixar
    o texto mais "apresentável" passamos +1 para [i] > apenas < para apresentar isso ao usuário:
        Console.Write($"Digite a {i + 1}ª nota: ");

* Como a entrada do usuário será sempre uma string, ao entrarmos no [if] já podemos converter
    o valor para um double (que é o valor que nossa lista aceita).
        OBS: Mais uma vez usamos o CultureInfo.InvariantCulture para fins de discrepância de
            entradas.

* Agora pssamos o valor da nota que o usuário digitar para cada posição da lista:

    notas[i] = notaDigitada;

    Ou seja, se vamos passarmos por [i] 4x vezes, toda [notaDigitada] vai entrar
    em uma posição de [i] lá na lista [notas]. Respeitando a ordem em que o laço for
    ocorre, teremos:
        - Nota 1: Posição (índice) = 0
        - Nota 2: Posição (índice) = 1
        - Nota 3: Posição (índice) = 2
        - Nota 4: Posição (índice) = 3

* O [break] fará com que a gente saia do nosso [while] e passemoss para a próxima
    interação com for. É como se informassemos: já paramos por aqui, podemos seguir.

* O [else] cuidará dos casos em que o usuário digite algo que não se encaixe na lista.

* Agora seguimos o nosso programa para calcular essas notas e exibir a média de todas elas.
    Para isso, vamos usar um novo conceito: o [foreach]. Aqui podemos passar um comando
    em que lerá uma ordem de "para cada... realize isso". No nosso caso seria:

        foreach (double nota in notas)
        {
            Console.WriteLine($"Nota: {nota}");
            soma += nota;
        }

    Ou seja: Para cada [nota] do tipo [double] dentro da lista [notas] realize...
        - A exibição delas no console.
        - A soma delas a partir de uma nova variável chmada [soma] que já declaramos:
            soma += nota
            Ou
            soma = soma + nota

* Por fim, finalmente exibimos a média atráves de:

    double media = soma / notas.Length;

    - A variável média é do tipo double
    - O resultado da média é a soma de todos os números dividida pela quantidade deles.
---------------------------------------------------------------------------

EXERCÍCIO - 12

- Desenvolva um programa que funciona como uma lista de convidados.
- Primeiro peça ao usuário para digitar o nome de 7 convidados.
- Depois exiba todos os nomes que ele digitou.
- Após isso, peça para o usuário digitar o nome de um dos convidados.
- Se o nome constar na lista, exiba uma mensagem permitindo sua entrada.
- Caso não, informe a ele que o nome não consta na lista.

*/