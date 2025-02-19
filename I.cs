using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite o primeiro número inteiro: ");
        int num1 = int.Parse(Console.ReadLine());
        
        Console.Write("Digite o segundo número inteiro: ");
        int num2 = int.Parse(Console.ReadLine());
        
        int diferenca = Math.Abs(num1 - num2);
        
        if (diferenca <= 10)
        {
            Console.WriteLine("A diferença entre os números é menor ou igual a 10.");
        }
        else
        {
            Console.WriteLine("A diferença entre os números é maior que 10.");
        }
        
        Console.Write("Press any key to continue . . . ");
	    Console.ReadKey(true);
    }
}
