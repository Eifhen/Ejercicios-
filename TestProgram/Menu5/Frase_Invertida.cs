using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Frase_Invertida
	{
		public static string InvertirFrase(string parametro, int StartIndex, int length) 
		{
			string InvertirCadena = parametro.Substring(StartIndex, length);
			return InvertirCadena;
		}
		public static void Operaciones() 
		{
			string linea;
			string aux = "";
			int index = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------- Frase Invertida usando While --------------");
			Console.WriteLine("********************************************************");

			Console.WriteLine("Digite una Frase : ");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			index = linea.Length;
			while((index > 0)) 
			{
				aux = aux + InvertirFrase(linea, index - 1, 1);
				index--;
			}
			Console.WriteLine("La Frase Era : {0}", linea);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Frase Invertida : {0}", aux);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();

		}
	}
}
