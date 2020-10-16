using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Comprobar_Multiplo
	{
		private string Multiplo(int numero1, int numero2) 
		{
			string resultado;
			int numero = numero1 % numero2;

			if (numero == 0) resultado = "Es Multiplo";
			else resultado = "No es Multiplo";

			return resultado;

		}
		public static void Operaciones() 
		{
			int numero1 = 0;
			int numero2 = 0;
			string result;
			string cadena;
			Comprobar_Multiplo objeto = new Comprobar_Multiplo();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --- [ Comprobar si un Numero es Multiplo de Otro ] ----");
			Console.WriteLine("********************************************************");
			
			// Input Data
			Console.WriteLine("Digita el Primer Numero : ");
			cadena = Console.ReadLine();
			numero1 = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			Console.WriteLine("Digita el Segundo Numero : ");
			cadena = Console.ReadLine();
			numero2 = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Operation
			result = objeto.Multiplo(numero1, numero2);

			// Output Data
			Console.WriteLine("********************************************************");
			Console.WriteLine("{0} {1} de {2}", numero1, result, numero2);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
