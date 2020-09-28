using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Sucesion_N_Cuadrados
	{
		public static void Operaciones() 
		{
			int cantidad, F, C, T, FI, FF, CI, CF;
			string linea;

			Console.Clear();
			Console.WriteLine("***************************************************");
			Console.WriteLine("------------- Sucesion de N Cuadrados. ------------");
			Console.WriteLine("***************************************************");
			Console.WriteLine("Digite un Numero Menor o Igual a 10"); 
			linea = Console.ReadLine();
			Console.WriteLine("***************************************************");
			Console.WriteLine();
			cantidad = int.Parse(linea);
			FI = 2; FF = 10; CI = 2; CF = 50;
			
			for(T = 1;  T <= cantidad; T++) 
			{
				for (F = CI; F <= CF; F++) 
				{
					Console.SetCursorPosition(F,FF); Console.Write("X");
					Console.SetCursorPosition(F, FI); Console.Write("X");
				}

				for (C = FI; C <= FF; C++) 
				{
					Console.SetCursorPosition(CI, C); Console.Write("X");
					Console.SetCursorPosition(CF, C); Console.Write("X");
				}
				FI = FI + 1;   FF = FF - 1;
				CI = CI + 1;   CF = CF - 1;
			}
			Console.WriteLine();
			Console.SetCursorPosition(24, 25);
			Console.WriteLine("Pulsa para volver al Menu."); Console.ReadLine();
		}
	} // End Class
} // End NameSpace
