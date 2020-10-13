using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Ejercicio_Propuesto_11
	{
		/*
			[ Mandato ]
			Confeccionaremos un programa que permita crear una matriz irregular y luego imprimir la
			matriz en forma completa.
		*/

		private int[][] matriz_irregular;

		// Cargamos los Elementos de la Matriz 
		public void Cargar()
		{
			string linea;
			int numero_filas = 0;
			int elementos = 0;
			int fila = 0;
			int columna = 0;
			Console.WriteLine("¿Cuantas FIlas tiene la Matriz?");
			linea = Console.ReadLine();
			numero_filas = int.Parse(linea);

			matriz_irregular = new int[numero_filas][];
			for (fila = 0; fila < matriz_irregular.Length; fila++)
			{
				Console.WriteLine("********************************************************");
				Console.WriteLine("Cuantos Elementos Tiene la Fila : {0}", fila + 1);
				Console.WriteLine("********************************************************");
				linea = Console.ReadLine();
				elementos = int.Parse(linea);
				matriz_irregular[fila] = new int[elementos];

				for(columna = 0; columna < matriz_irregular[fila].Length; columna++) 
				{
					Console.Write("Ingresa el Componente : ");
					linea = Console.ReadLine();
					matriz_irregular[fila][columna] = int.Parse(linea);
				}
			}

		}

		// Imprimimos la Matriz
		public void Imprimir() 
		{
			Console.WriteLine("********************************************************");
			Console.WriteLine("[ Matriz ]");
			Console.WriteLine("********************************************************");
			for (int fila = 0; fila < matriz_irregular.Length; fila++) 
			{
				for(int columna = 0; columna < matriz_irregular[fila].Length; columna++) 
				{
					Console.Write("{0} ",matriz_irregular[fila][columna]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("********************************************************");
		}
		public void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------- [ Ejercicio Propuesto 11 ] -------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine();

			Cargar();
			Imprimir();

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
