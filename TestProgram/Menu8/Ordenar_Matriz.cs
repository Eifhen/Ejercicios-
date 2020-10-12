using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Ordenar_Matriz
	{

		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int numero = 0;
			int auxiliar = 0;
			int altura = 7;
			int altura2 = 0;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------- Ordenar Elementos de una Matriz N x N --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Tamaño de la Matriz : ");
			linea = Console.ReadLine();
			numero = int.Parse(linea);
			Console.WriteLine();

			// [Generamos Valores Aleatorios]
			Random aleatorio = new Random();

			// [Generamos la Matriz]
			int[,] matriz = new int[numero + 1, numero + 1];
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					matriz[fila, columna] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(columna * 4, altura);
					Console.Write(matriz[fila, columna]);
				}
				altura++;
			}

			// [ Proceso : Ordenamos la Matriz]
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					for(int i = 1; i <= numero; i++) 
					{
						for(int k = 1; k <= numero; k++) 
						{
							if (matriz[fila, columna] < matriz[i, k]) 
							{
								auxiliar = matriz[fila, columna];
								matriz[fila, columna] = matriz[i, k];
								matriz[i, k] = auxiliar;
							}
						}
					}
				}
			}

			// [Salida]
			altura2 = altura + 5;
			for(fila = 1; fila <= numero; fila++) 
			{
				for(columna = 1; columna <= numero; columna++) 
				{
					Console.SetCursorPosition(columna * 4, altura2);
					Console.Write(matriz[fila, columna]);
				}
				altura2++;
			}

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
