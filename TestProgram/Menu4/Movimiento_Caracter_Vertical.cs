using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Movimiento_Caracter_Vertical
	{

		public static string MID(string parametro, int startIndex, int length) 
		{
			string resultado = parametro.Substring(startIndex, length);
			return resultado;

		}

		public static void Operaciones() 
		{
			string nombre;
			string caracter;
			int k = 0;
			int p = 0;
			int CI = 0;

			Console.Clear();
			Console.WriteLine("******************************************************************");
			Console.WriteLine("----------- Movimiento Caracter por Caracter Vertical ------------");
			Console.WriteLine("******************************************************************");
			Console.WriteLine("Escribe tu nombre.");
			nombre = Console.ReadLine();
			Console.WriteLine("******************************************************************");
			Console.SetCursorPosition(25, 10);
			Console.Write(nombre);
			CI = 25;
			nombre = nombre.ToUpper();
			for( p = 1; p <= nombre.Length; p++) 
			{
				caracter = MID(nombre, p - 1, 1);
				for(k = 1; k < 22; k++) 
				{
					Console.SetCursorPosition(CI,k);
					Console.Write(caracter);
					// pause
					System.Threading.Thread.Sleep(100);
					Console.SetCursorPosition(CI, k);
					Console.Write(" ");
				}
				Console.SetCursorPosition(CI,k);
				Console.Write(caracter);
				CI = CI + 1;
			}
			Console.WriteLine();
			Console.WriteLine("Pulsa una tecla para volver al Menu.");
			Console.ReadLine();
		}
	}
}
