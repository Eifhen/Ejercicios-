using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Multiplicacion_Matrices_4x4
	{


		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int numero = 4;
			int altura = 5;
			int[,] A = new int[100, 100];
			int[,] B = new int[100, 100];
			int[,] C = new int[numero + 1, numero + 1];
			Random aleatorio = new Random();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------- Multiplicacion de Matrices 4x4 ------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz A ]");
			Console.WriteLine("********************************************************");
			Console.SetCursorPosition(0, altura + 6);
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz B]");
			Console.WriteLine("********************************************************");

			// Poblamos la Matriz A y B con numeros aleatorios
			for (fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					A[fila, columna] = aleatorio.Next(0, 10);
					B[fila, columna] = aleatorio.Next(0, 10);

					// [ Salida Matriz A ]
					Console.SetCursorPosition(columna * 4, altura + 1);
					Console.Write(A[fila, columna]);
					
					// [ Salida Matriz B ]
					Console.SetCursorPosition(columna * 4, altura + 9);
					Console.Write(B[fila, columna]);
				}
				altura++;
			}


			// [ Proceso : Multiplicar Matrices A y B y almacenar resultados en Matriz C ]
			for (fila = 1; fila <= numero; fila++) 
			{
				for (columna = 1; columna <= numero; columna++) 
				{
					C[fila, columna] = A[fila, columna] * B[fila, columna];
				}
			}

			// Salida
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz Resultante ]");
			Console.WriteLine("********************************************************");
			Console.WriteLine();

			for (fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					Console.SetCursorPosition(columna * 4, altura + 12);
					Console.Write(C[fila, columna]);
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
