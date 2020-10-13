using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Menores_de_Cada_Columna_Matriz_a_Vector
	{

		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int menor = 0;
			int numero = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" Mayores De Cada Columna De Una Matriz NxN En Un Vector ");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Tamaño de la Matriz : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			int[,] matriz_1 = new int[100, 100];
			int[] vector = new int[numero + 1];
			Random aleatorio = new Random();

			// Poblamos la Matriz con numeros aleatorios
			Console.WriteLine("[ Matriz --------> ]");
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			for (fila = 1; fila <= numero; fila++) 
			{
				for (columna = 1; columna <= numero; columna++) 
				{
					matriz_1[fila, columna] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(columna * 4, fila + 8);
					Console.Write(matriz_1[fila, columna]);
				}
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// [ Proceso : Encontrar el numero Menor en Cada Columna de la Matriz y pasarlo al Vector]
			for (columna = 1; columna <= numero; columna++) 
			{
				menor = matriz_1[1, columna];
				for (fila = 1; fila <= numero; fila++) 
				{
					if (matriz_1[fila, columna] < menor) menor = matriz_1[fila, columna];
				}
				vector[columna] = menor;
			}

			// [ Salida ]
			Console.WriteLine("Numeros Menores de Cada Columna de la Matriz");
			Console.WriteLine("********************************************************");
			for (columna = 1; columna <= numero; columna++) 
			{
				Console.SetCursorPosition(columna * 4, 23);
				Console.Write(vector[columna]);
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
