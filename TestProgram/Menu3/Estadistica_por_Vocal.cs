using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Estadistica_por_Vocal
	{
		public static string Mid(string parametro, int length, int startIndex) 
		{
			string result = parametro.Substring(startIndex,length);
			return result;
		}
		public static void Operaciones() 
		{
			string linea, LE;
			int A = 0;
			int E = 0;
			int I = 0;
			int O = 0;
			int U = 0;
			int index = 0;
			Console.Clear();
			Console.WriteLine("**********************************************");
			Console.WriteLine(" ----------- Estadistica por Vocal -----------");
			Console.WriteLine("**********************************************");

			Console.WriteLine("Digite una Frase");
			linea = Console.ReadLine();
			for(int k = 0; k < linea.Length; k++) 
			{
				index = k;
				linea = linea.ToUpper();
				LE = Mid(linea, 1, index);
				switch (LE) 
				{
					case "A":
						A = A + 1;
						break;
					case "E":
						E = E + 1;
						break;
					case "I":
						I = I + 1;
						break;
					case "O":
						O = O + 1;
						break;
					case "U":
						U = U + 1;
						break;
				}
			}
			Console.WriteLine("**********************************************");
			Console.WriteLine(" Existen {0} Vocales A ",A);
			Console.WriteLine(" Existen {0} Vocales E ", E);
			Console.WriteLine(" Existen {0} Vocales I ", I);
			Console.WriteLine(" Existen {0} Vocales O ", O);
			Console.WriteLine(" Existen {0} Vocales U ", U);
			Console.WriteLine("**********************************************");
			Console.WriteLine("Pulsa una tecla para volver al menu");
			Console.ReadLine();

		}
	}
}
