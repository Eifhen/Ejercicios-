using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Aleatorios_Matriz
	{

		public static void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------- Generar Aleatorios en una Matriz 5 x 5 --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			int filas = 0;
			int columnas = 0;
			int[,] matriz = new int[6, 6];
			Random numero_aleatorio = new Random();

			// Generamos los numeros y los imprimimos;
			for(filas = 1; filas <= 5; filas++) 
			{
				for(columnas = 1; columnas <= 5; columnas++) 
				{
					matriz[filas, columnas] = numero_aleatorio.Next(1, 99);
					Console.Write("{0} ", matriz[filas, columnas]);
				}
				Console.WriteLine();
			}

			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
