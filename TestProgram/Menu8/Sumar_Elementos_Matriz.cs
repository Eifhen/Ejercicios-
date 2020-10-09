using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Sumar_Elementos_Matriz
	{

		public static void Operaciones() 
		{

			int filas = 0;
			int columnas = 0;
			int suma = 0;
			int numeros = 0;
			string linea; 

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- Sumar Elementos de una Matriz N x N ---------");
			Console.WriteLine("********************************************************");
			
			// Definimos el Tamaño de la Matriz
			Console.WriteLine("Tamaño de la Matriz : ");
			linea = Console.ReadLine();
			numeros = int.Parse(linea);
			int[,] matriz = new int[numeros + 1 , numeros + 1];

			// Ingresamos Elementos a la Matriz
			Console.WriteLine("********************************************************");
			for ( filas = 1; filas <= numeros; filas++) 
			{
				for (columnas = 1; columnas <= numeros; columnas++) 
				{
					Console.WriteLine("Ingresa un valor : ");
					linea = Console.ReadLine();
					matriz[filas, columnas] = int.Parse(linea);
				}
			}
			Console.WriteLine("********************************************************");

			// Imprimir Matriz
			for (filas = 1; filas <= numeros; filas++) 
			{
				for (columnas = 1; columnas <= numeros; columnas++) 
				{
					Console.Write("{0} ",matriz[filas, columnas]);
				}
				Console.WriteLine();
			}

			// Proceso Suma
			for ( filas = 1; filas <= numeros; filas++) 
			{
				for (columnas = 1; columnas <= numeros; columnas++) 
				{
					suma = suma + matriz[filas, columnas];	
				}
			}

			// Salida
			Console.WriteLine(); 
			Console.WriteLine("********************************************************");
			Console.WriteLine("Suma Total es : {0} ", suma);
			Console.WriteLine("Promedio Total es : {0} ", suma / (numeros * numeros));
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
