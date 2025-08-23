using System;
using System.Text;

public class ForResp {
    
    public static void Main_09(string[] args){
        
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Digite um número de 2 a 5: ");
        string numUser = Console.ReadLine();
        
        int numUserConverted;
        
        bool sucess = int.TryParse(numUser, out numUserConverted);
        
        if (numUserConverted >= 2 && numUserConverted <= 5){
            
            int oldResult = numUserConverted;
            
            Console.WriteLine($"{oldResult} * {oldResult}");
        
            for (int i = 1; i <= 2; i++){
             
                numUserConverted *= 2;
                
                Console.WriteLine($"{oldResult} * {numUserConverted}");
            }
            
        }
        
        else{
            Console.WriteLine("Fim do programa");
        }
        
    }
    
}