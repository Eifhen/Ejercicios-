using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Mayores_de_Cada_Fila_Matriz_a_Vector
	{

		public static void Operaciones() 
		{
			string cadena;
			int F = 0;
			int C = 0;
			int numero = 0;
			int mayor = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine("** Mayores de Cada Fila de Una Matriz NxN En Un Vector *");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Tamaño de la Matriz : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			int[,] matriz = new int[100, 100];
			int[] vector = new int[numero + 1];

			// Poblamos la Matriz
			Console.WriteLine("[ Matriz ] ---> ");
			Console.WriteLine("********************************************************");
			Random aleatorio = new Random();
			for(F= 1; F <= numero; F++) 
			{
				for (C = 1; C <= numero; C++) 
				{
					matriz[F, C] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(C * 4, F + 9);
					Console.Write(matriz[F, C]);
				}			
			}

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// [ Proceso : Determinamos el Numero Mayor  de cada fila ]
			for (F = 1; F <= numero; F++)
			{
				mayor = matriz[F, 1];
				for (C = 1; C <= numero; C++)
				{
					if (matriz[F, C] > mayor) mayor = matriz[F, C];
				}
				vector[F] = mayor;
			}

			// [ Salida ]
			Console.WriteLine("[ Numero Mayor de Cada Fila ] ---> ");
			Console.WriteLine("********************************************************");

			for (F = 1; F <= numero; F++)
			{
				Console.SetCursorPosition(25, F + 23);
				Console.Write(vector[F]);
			}


			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
