using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Intercalacion_Minusculas_y_Mayusculas
	{

		public static string IntercalarFrase(string parametro, int StartIndex, int Length) 
		{
			string frase_intercalada = parametro.Substring(StartIndex, Length);
			return frase_intercalada;
		}
		public static void Operaciones()
		{
			string frase, LE;
			int indice = 0;
			string Aux = "";
			
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----- Intercalacion de Mayusculas y Minusculas --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite una frase : ");
			frase = Console.ReadLine();
			Console.WriteLine("********************************************************");
			indice = 1;
			while ((indice <= frase.Length)) 
			{
				LE = IntercalarFrase(frase, indice-1, 1);
				if ((indice % 2 == 0)) Aux = Aux + LE.ToLower();
				else Aux = Aux + LE.ToUpper();

				indice++;
			}
			Console.WriteLine();
			Console.WriteLine("Frase Intercalada : {0}", Aux);
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
