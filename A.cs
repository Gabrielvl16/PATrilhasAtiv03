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
			
		 if (numeroUm > numeroDois) 
		 {
			Console.WriteLine("O número " + numeroUm + " é maior que " + numeroDois);
		 }
		 else 
		 {
		        Console.WriteLine("O número " + numeroUm + " não é maior que " + numeroDois);
		 }
			
		 Console.Write("Press any key to continue . . . ");
	         Console.ReadKey(true);
		}
	}
}
