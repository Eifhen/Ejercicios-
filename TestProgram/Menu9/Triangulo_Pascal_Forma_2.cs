using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Triangulo_Pascal_Forma_2
	{

		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int numero = 0;
			int F = 0;
			int C = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- Triangulo de Pascal Forma 2 -------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantas Filas?");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			int[,] matriz = new int[numero + 1, numero + 1];

			// Proceso
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					if ((columna == 1) | (fila == columna))
					{
						matriz[fila, columna] = 1;
					}
					else 
					{
						matriz[fila, columna] = matriz[fila - 1, columna] + matriz[fila - 1, columna - 1];
					}
				}
			}

			// Salida
			Console.WriteLine("********************************************************");
			F = 8;
			for (fila = 1; fila <= numero; fila++) 
			{
				C = 40 - (fila * 2);
				for (columna = 1;columna <= numero; columna++) 
				{
					if ((matriz[fila, columna] != 0)) 
					{
						Console.SetCursorPosition(C, F);
						Console.Write(matriz[fila, columna]);
						C = C + 4;
					}
				}
				F++;
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
