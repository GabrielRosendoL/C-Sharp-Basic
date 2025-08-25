using System;
using System.Text;

public class Exerc_12
{
    public static void Main_Resp12(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("Lista de Convidados");

        string[] listaDeConvidados = new string[7];

        for (int i = 0; i < 7; i++)
        {
            Console.WriteLine($"Digite o nome do convidado {i + 1}");
            string? convidado = Console.ReadLine();
            listaDeConvidados[i] = convidado;
        }

        Console.WriteLine("\nLista de Convidados: \n");

        foreach (string convidado in listaDeConvidados)
        {
            Console.WriteLine($"Convidado: {convidado}");
        }

        Console.WriteLine("\nAgora digite o nome de um dos convidados: ");
        string? convidadoDigitado = Console.ReadLine();

        bool encontrado = false;
        
        foreach (string convidado in listaDeConvidados)
        {
            if (convidadoDigitado == convidado)
            {
                encontrado = true;
                break;
            }
        }

        if (encontrado)
        {
            Console.WriteLine("Esse convidado está na lista.");
        }
        else
        {
            Console.WriteLine("Esse convidado não está na lista.");
        }
    }
}