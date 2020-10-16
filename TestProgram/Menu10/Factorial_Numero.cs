using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Factorial_Numero
	{
		private long Factorial(int numero) 
		{
			long result = 1;
			byte k = 0;
			for (k = 2; k <= numero; k++)
			{
				result = result * k;
			}
			return result;
		}
		public static void Operaciones() 
		{

			Factorial_Numero objeto = new Factorial_Numero();
			int numero = 0;
			long result = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------- [ Factorial de un Numero ] -------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);

			// Operacion
			result = objeto.Factorial(numero);

			// Salida
			Console.WriteLine("El Factorial de : {0} es {1} ", numero, result);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
