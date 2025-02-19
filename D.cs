using System;
namespace ba
{
	class Program
	{
		public static void Main()
		{
			Console.WriteLine("Digite dois números inteiros: ");
			int numeroUm = int.Parse(Console.ReadLine());
			int numeroDois = int.Parse(Console.ReadLine());
			int numeroTres = int.Parse(Console.ReadLine());
			
			if (numeroUm < numeroDois && numeroUm > numeroTres) 
			{
				Console.WriteLine("O número " + numeroUm + " é menor que " + numeroDois + " é maior que " + numeroTres);
			}
			else
			{
				Console.WriteLine("O número " + numeroUm + " não é menor que " + numeroDois + " é maior que " + numeroTres);
			}
			
			Console.Write("Press any key to continue . . . ");
	    	Console.ReadKey(true);
		}
	}
}
