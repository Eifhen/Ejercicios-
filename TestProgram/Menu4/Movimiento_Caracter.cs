using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Movimiento_Caracter
	{
		public static string Mid(string parametro, int startIndex, int length) 
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
			int CF = 0;
			Console.Clear();
			Console.WriteLine("******************************************************************");
			Console.WriteLine("---------- Movimiento Caracter por Caracter Horizontal -----------");
			Console.WriteLine("******************************************************************");
			Console.WriteLine("Digite su Nombre"); 
			nombre = Console.ReadLine();
			Console.WriteLine("******************************************************************");
			Console.SetCursorPosition(1, 12); 
			Console.WriteLine(nombre);
			CI = nombre.Length;
			CF = 70;
			nombre = nombre.ToUpper();
			for ( p = nombre.Length; p >= 1; p--) 
			{
				caracter = Mid(nombre, p-1 ,1);
				for (k = CI; k <= CF; k++) 
				{
					Console.SetCursorPosition(k,12);
					Console.Write("{0}",caracter);
					// realizamos pausa
					System.Threading.Thread.Sleep(100);
				}
				CF = CF - 1;
				CI = CI - 1;
				Console.WriteLine();
			}
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();
		}
	}
}
