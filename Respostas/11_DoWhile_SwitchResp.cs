using System;
using System.Text;

public class DoWhile_SwitchResp {
    
    public static void Main_11(string[] args)
    {
        
        Console.OutputEncoding = Encoding.UTF8;
        
        Console.WriteLine("Bem-vindo!");
        
        Console.WriteLine("Digite um número entre 20 e 30: ");
        string userInput = Console.ReadLine();
        
        if (int.TryParse(userInput, out int userInputConverted) && userInputConverted >= 20 && userInputConverted <= 30)
        {
            Console.WriteLine($"O número que voce digitou foi: {userInputConverted}");
            
            char userOptionConverted;
            
            do {
                Console.WriteLine("\n--- Lista de Opções ---");
                
                Console.WriteLine("Escolha uma das opções abaixo digitando a letra correspondente:");
                
                Console.WriteLine($"\n- Opção 'a' - Multiplicar {userInputConverted} por 3");
                Console.WriteLine($"- Opção 'b' - Dividir {userInputConverted} por 2");
                Console.WriteLine($"- Opção 'c' - Subtrair 10 de {userInputConverted}");
                Console.WriteLine($"- Opção 'd' - Somar 15 a {userInputConverted}");
                Console.WriteLine($"- Opção 'e' - Encerre o programa");
                
                Console.WriteLine($"\nDigite sua opção: ");
                string userOption = Console.ReadLine();
                
                bool sucess_two = char.TryParse(userOption, out userOptionConverted); 
                
                int optionA = userInputConverted * 3;
                int optionB = userInputConverted / 2;
                int optionC = userInputConverted - 10;
                int optionD = userInputConverted + 15;
                
                switch(userOptionConverted)
                {
                    case 'a':
                        Console.WriteLine($"\nO resultado é: {optionA}");
                        break;
                    case 'b':
                        Console.WriteLine($"\nO resultado é: {optionB}");
                        break;
                    case 'c':
                        Console.WriteLine($"\nO resultado é: {optionC}");
                        break;
                    case 'd':
                        Console.WriteLine($"\nO resultado é: {optionD}");
                        break;
                    default:
                        Console.WriteLine("Opção inválida.");
                        break;
                }
            }
            while (userOptionConverted != 'e');
            
            Console.WriteLine("Você optou por encerrar o programa.");
        }
        
        else
        {
            Console.WriteLine("Falha. Programa Encerrado.");
        }
        
    }
    
}