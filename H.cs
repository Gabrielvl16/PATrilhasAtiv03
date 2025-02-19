using System;
namespace ba
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite um número:");
			int numero = int.Parse(Console.ReadLine());
		    
			if (numero > 0) 
			{
				Console.WriteLine("O seu numero e positivo");
			}
			else
			{
				Console.WriteLine("O seu número e negativo");
			}
		
			Console.Write("Press any key to continue . . . ");
	    	Console.ReadKey(true);
		}
	}
}
