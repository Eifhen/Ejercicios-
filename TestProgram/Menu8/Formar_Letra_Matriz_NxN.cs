using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Formar_Letra_Matriz_NxN
	{

		public static void Operaciones() 
		{

			int fila = 0, columna = 0, numero = 0, formar_letra = 0;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----- Formar la Letra ( A ) en una  Matriz N x N ------");
			Console.WriteLine("********************************************************");

			// [ Definimos Tamaño de la Matriz ]
			Console.WriteLine("Define el Tamaño de la Matriz Impar");
			linea = Console.ReadLine();
			numero = int.Parse(linea);
			numero = (numero % 2 == 0 ? numero + 1 : numero );
			string[,] matriz = new string[numero + 1, numero + 1];
			
			// [ Matriz en Blanco ]
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					matriz[fila, columna] = " ";
				}
			}

			// [ Formamos la Letra ]
			formar_letra = (numero / 2) + 1;
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					matriz[fila, 1] = "A";   // todas las filas en la columna 1 son iguales a ( A )
					matriz[fila, numero] = "A";  // la matriz en la fila x en la columna numero es igual a ( A ) 
					matriz[formar_letra, fila] = "A";
					matriz[1, fila] = "A";
				}
			}

			// [ Salida ]
			int posicion_y = 7;
			Console.WriteLine("********************************************************");
			for (fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					Console.SetCursorPosition(columna, posicion_y + 1);
					Console.Write("{0} ", matriz[fila , columna]);

				}
				posicion_y++;
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
