using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Matriz_Transpuesta_NxN
	{
		public static void Operaciones() 
		{
			int F = 0;
			int C = 0;
			int N = 0;
			string cadena;
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- Matriz Transpuesta de N x N -------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Tamaño de la Matriz: ");
			cadena = Console.ReadLine();
			N = int.Parse(cadena);
			Console.WriteLine("********************************************************");
			int[,] matriz_1 = new int[N + 1, N + 1];
			int[,] matriz_2 = new int[100, 100];

			// Poblamos la Matriz
			Console.WriteLine("******************* [Matriz Original] ******************");
			Random aleatorio = new Random();
			for (F = 1; F <= N; F++) 
			{
				for (C = 1; C <= N; C++) 
				{
					matriz_1[F, C] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(C * 4, F + 7);
					Console.Write(matriz_1[F, C]);
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*********************************************************");

			// Proceso
			for (F = 1; F <= N; F++)
			{
				for (C = 1; C <= N; C++)
				{
					matriz_2[F, C] = matriz_1[C, F];
				}
			}

			// Salida
			Console.WriteLine("***************** [Matriz Transpuesta] ******************");
			for (F = 1; F <= N; F++)
			{
				for (C = 1; C <= N; C++) 
				{
					Console.SetCursorPosition(C * 4, F + 21);
					Console.Write(matriz_2[F, C]);
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("*********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
