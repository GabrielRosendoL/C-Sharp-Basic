using System;
using System.Text;

public class WhileResp{
    
    public static void Main(string[] args) {
        
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Digite seu nome: ");
        string userName = Console.ReadLine();
        
        Console.WriteLine($"Seu nome é {userName} \n");
        
        Console.WriteLine("Digite seu segundo nome novamente: ");
        string secondUserName = Console.ReadLine();
            
        while(secondUserName != userName){
                Console.WriteLine("Falha");
                Console.WriteLine("Digite novamente: ");
                secondUserName = Console.ReadLine();
                continue;
            }
            
        Console.WriteLine("Sucesso: Os nomes são iguais.");
        
    }
    
}