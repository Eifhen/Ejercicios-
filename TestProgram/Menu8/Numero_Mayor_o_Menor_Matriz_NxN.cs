using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Numero_Mayor_o_Menor_Matriz_NxN
	{

		public static void Operaciones() 
		{
			int filas = 0;
			int columnas = 0;
			int numero = 0;
			int numero_mayor = 0;
			int numero_menor = 0;
			int altura = 7;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------ Numero Mayor o Menor en una Matriz N x N -------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Ingresa el Tamaño de la Matriz");
			linea = Console.ReadLine();
			numero = int.Parse(linea);

			Console.WriteLine("********************************************************");
			// [ Generamos Valores Aleatorios para la Matriz ]
			Random aleatorio = new Random();

			int[,] matriz = new int[numero + 1, numero + 1];
			for(filas = 1; filas <= numero; filas++) 
			{
				for (columnas = 1; columnas <= numero; columnas++) 
				{
					matriz[filas, columnas] = aleatorio.Next(0, 99);
					Console.SetCursorPosition(columnas * 4, altura);
					Console.Write(matriz[filas, columnas]);
				}
				altura++;
			}

			// [Proceso]
			numero_mayor = matriz[1, 1];
			numero_menor = matriz[1, 1];
			for(filas = 1; filas <= numero; filas++) 
			{
				for(columnas = 1; columnas <= numero; columnas++) 
				{
					if ((matriz[filas, columnas] > numero_mayor)) numero_mayor = matriz[filas, columnas];
					if ((matriz[filas, columnas] < numero_menor)) numero_menor = matriz[filas, columnas];
				}
			}

			// [ Salida ]
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Numero Mayor es : {0}", numero_mayor);
			Console.WriteLine("Numero Menor es : {0}", numero_menor);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
