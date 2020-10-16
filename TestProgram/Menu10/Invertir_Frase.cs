using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Invertir_Frase
	{
		private string ReverseString(string cadena) 
		{

			string auxiliar;
			string reversed = "";
			int index = cadena.Length;
			while(index >= 1) 
			{
				auxiliar = cadena.Substring(index-1, 1);
				reversed = reversed + auxiliar;
				index--;
			}
			return reversed;
		}

		public static void Operaciones() 
		{
			Invertir_Frase objeto = new Invertir_Frase();
			string cadena;
			string cadena_invertida;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- [ Invertir una Frase ] ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite una Frase : ");
			cadena = Console.ReadLine();
			Console.WriteLine("********************************************************");

			// Operacion
			cadena_invertida = objeto.ReverseString(cadena);

			// Salida
			Console.WriteLine("El Resultado es : {0}", cadena_invertida);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
