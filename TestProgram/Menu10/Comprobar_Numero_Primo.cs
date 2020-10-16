using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Comprobar_Numero_Primo
	{
		private string NumeroPrimo(int numero) 
		{
			int k = 0;
			int sw = 0;
			int residuo = 0;

			k = 2;
			while (((k < numero) & (sw  == 0))) 
			{
				residuo = numero % k;
				if (residuo == 0) sw = 1;
				else k = k + 1;
			}
			if ((sw == 0)) return "Es Primo.";
			else return "No es Primo.";
		}
		public static void Operaciones() 
		{
			int numero = 0;
			string result = null;
			string cadena;
			Comprobar_Numero_Primo objeto = new Comprobar_Numero_Primo();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- [ Comprobar si un Numero es Primo ] ---------");
			Console.WriteLine("********************************************************");
			
			// Input Data
			Console.WriteLine("Digite un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Operation
			result = objeto.NumeroPrimo(numero);

			// Output Data
			Console.WriteLine("El Numero : {0} {1}", numero, result);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
