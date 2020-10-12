using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Suma_Matrices_5x5
	{
		/*
			Crearemos 3 Matrices, Matriz_A, Matriz_B y Matriz_C 
			sumaremos A + B y el resultado lo mostraremos en C
		*/

		public static void Operaciones() 
		{

			Random aleatorio = new Random();
			int[,] A = new int[100, 100];
			int[,] B = new int[100, 100];
			int[,] C = new int[6, 6];
			int altura = 4;
			int filas = 0;
			int columnas = 0;


			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------- [ Suma de Matrices 5x5 ] ---------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz A ]");
			Console.SetCursorPosition(0, altura + 7);
			Console.WriteLine("[ Matriz B]");

			// [ Poblar Matrices ]
			for(filas = 1; filas <= 5; filas++) 
			{
				for (columnas = 1; columnas <= 5; columnas++) 
				{

					A[filas, columnas] = aleatorio.Next(0, 9);
					B[filas, columnas] = aleatorio.Next(0, 9);

					// [ Salida Matriz A ]
					Console.SetCursorPosition(columnas * 4, altura + 1);
					Console.Write(A[filas, columnas]);

					// [ Salida Matriz B ]
					Console.SetCursorPosition(columnas * 4, altura + 9);
					Console.Write(B[filas, columnas]);
				}
				altura++;
			}

			// [ Proceso : Sumar Matrices A y B ]
			for(filas = 1; filas <= 5; filas++) 
			{
				for(columnas = 1; columnas <= 5; columnas++) 
				{
					C[filas, columnas] = A[filas, columnas] + B[filas, columnas];
				}
			}

			// [ Salida ]
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz Resultante ]");
			Console.WriteLine("********************************************************");
			Console.WriteLine();

			for (filas = 1; filas <= 5; filas++) 
			{
				for(columnas = 1; columnas <= 5; columnas++) 
				{
					Console.SetCursorPosition(columnas * 4, altura + 12);
					Console.Write(C[filas, columnas]);
				}
				altura++;
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
