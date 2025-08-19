using System;
using System.Text;
using System.Globalization;


public class OperadoresLogicos
{

    public static void Main_07(string[] args)
    {

        Console.OutputEncoding = Encoding.UTF8;

        Console.Write("\nDigite o primeiro número (pode ser decimal): ");
        string primeiroNumeroTexto = Console.ReadLine();

        double numero1 = double.Parse(primeiroNumeroTexto, CultureInfo.InvariantCulture);


        Console.Write("Digite o segundo número: ");
        string segundoNumeroTexto = Console.ReadLine();
        double numero2 = double.Parse(segundoNumeroTexto, CultureInfo.InvariantCulture);

        Console.WriteLine("\n1. Operadores Aritméticos");

        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double multiplicacao = numero1 * numero2;
        double divisao = numero1 / numero2;

        int restoDaDivisao = (int)numero1 % (int)numero2;

        Console.WriteLine($"{numero1} + {numero2} = {soma}");
        Console.WriteLine($"{numero1} - {numero2} = {subtracao}");
        Console.WriteLine($"{numero1} * {numero2} = {multiplicacao}");
        Console.WriteLine($"{numero1} / {numero2} = {divisao:F2}");
        Console.WriteLine($"O resto da divisão inteira de {(int)numero1} por {(int)numero2} é: {restoDaDivisao}");


        Console.WriteLine("\n2. Operadores de Atribuição Composta");
        double valorDinamico = numero1;
        Console.WriteLine($"Valor inicial: {valorDinamico}");

        valorDinamico += numero2;
        Console.WriteLine($"Após somar {numero2} (+=): {valorDinamico}");

        valorDinamico -= 5;
        Console.WriteLine($"Após subtrair 5 (-=): {valorDinamico}");

        valorDinamico *= 2;
        Console.WriteLine($"Após multiplicar por 2 (*=): {valorDinamico}");

        valorDinamico /= 3;
        Console.WriteLine($"Após dividir por 3 (/=): {valorDinamico:F2}");


        Console.WriteLine("\n3. Operadores de Comparação (Resultam em 'true' ou 'false')");

        bool eIgual = numero1 == numero2;
        bool eDiferente = numero1 != numero2;
        bool eMaior = numero1 > numero2;
        bool eMenor = numero1 < numero2;
        bool eMaiorOuIgual = numero1 >= numero2;
        bool eMenorOuIgual = numero1 <= numero2;

        Console.WriteLine($"'{numero1} == {numero2}' é: {eIgual}");
        Console.WriteLine($"'{numero1} != {numero2}' é: {eDiferente}");
        Console.WriteLine($"'{numero1} > {numero2}' é: {eMaior}");
        Console.WriteLine($"'{numero1} < {numero2}' é: {eMenor}");
        Console.WriteLine($"'{numero1} >= {numero2}' é: {eMaiorOuIgual}");
        Console.WriteLine($"'{numero1} <= {numero2}' é: {eMenorOuIgual}");


        Console.WriteLine("\n4. Operadores Lógicos (Combinando valores true/false)");
        bool condicaoA = numero1 > 0;
        bool condicaoB = numero2 > 0;

        Console.WriteLine($"Condição A (numero1 > 0) é: {condicaoA}");
        Console.WriteLine($"Condição B (numero2 > 0) é: {condicaoB}");

        bool resultadoE = condicaoA && condicaoB;
        bool resultadoOU = condicaoA || condicaoB;
        bool resultadoNAO = !condicaoA;

        Console.WriteLine($"Condição A E (&&) Condição B: {resultadoE}");
        Console.WriteLine($"Condição A OU (||) Condição B: {resultadoOU}");
        Console.WriteLine($"NÃO (!) Condição A: {resultadoNAO}");
    }
}

// ---------------------------------------------------------------------------
// EXPLICAÇÃO

// * Comece declarando a classe OperadoresLogicos

// Troque:
//      public static void Main_07(string[] args)
// para:
//      public static void Main(string[] args)

// * Utilizamos a biblioteca Globalization para lidar com divergências de padrão regional, como
//      utlização da vírgula ou ponto; ou ordem de dia e mês. 

//  * Com Operadores Lógicos podemos manipular as variávels ou fazer comparações com base 
//              nas afirmações que estabelecemos.

// ---------------------------------------------------------------------------
// EXERCÍCIO - 07

// Desenvolva um programa que exiba um texto em verde e um texto em vermelho no console.