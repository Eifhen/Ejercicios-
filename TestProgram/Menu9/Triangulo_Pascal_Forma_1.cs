using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Triangulo_Pascal_Forma_1
	{

		public static void Operaciones()
		{
			int fila = 0;
			int columna = 0;
			int numero = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --- Generacion del Triangulo de Pascal Forma 1 --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantas Filas? ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			int[,] matriz = new int[numero + 1, numero + 1];

			// [ Proceso ]
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

			// [ Salida ]
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					if (matriz[fila, columna] != 0) 
					{
						Console.Write("{0} ", matriz[fila, columna]);
					}
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
