using System;
using System.Text;

public class Metodos_Funcoes_Resp{
    
    public static void Main_Resp13(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Bem-vindo ao Main");
        Console.WriteLine("\nDigite um número: ");
        string? entrada = Console.ReadLine();
        
        FuncaoSeparada(entrada);
        
        
        Console.WriteLine("Fim do Main");
        
    }

    public static void FuncaoSeparada(string entrada){
        int.TryParse(entrada, out int entradaInt);
        
        Console.WriteLine($"O número foi: {entradaInt}");
    }
    
}