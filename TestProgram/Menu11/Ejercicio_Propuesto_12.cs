using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu11
{
	class Ejercicio_Propuesto_12
	{	
		/*
			Crear una Matriz 4 x 4 e Imprimir la diagonal Principal
			 x  -  -  -
		     -  x  -  -
			 -  -  x  -
		     -  -  -  x
		*/
		public static void Operaciones() 
		{
			int filas = 4;
			int columnas = 4;
			Random aleatorio = new Random();
			int[,] matriz = new int[filas + 1, columnas + 1];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------- [ Ejercicio Propuesto 12 ] -------------");
			Console.WriteLine("********************************************************");
			
			// Poblamos e Imprimimos la Matriz
			for(int fila = 1; fila <= 4; fila++) 
			{
				for(int columna = 1; columna <= 4; columna++) 
				{
					matriz[fila, columna] = aleatorio.Next(0, 10);
					Console.Write("{0}  ", matriz[fila, columna]);
				}
				Console.WriteLine();
			}

			Console.WriteLine("********************************************************");
			Console.WriteLine("Diagonal Principal ----> ");
			Console.WriteLine("********************************************************");

			for (int fila = 1; fila <= 4; fila++) 
			{
				Console.Write("{0} ", matriz[fila, fila]);
			}
	
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
