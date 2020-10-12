using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Sumar_Elementos_Diagonales_Matriz
	{

		public static void Operaciones() 
		{
			int filas = 0;
			int columnas = 0;
			int numero = 0;
			int suma_diagonal_principal = 0;
			int suma_diagonal_secundaria = 0;
			int altura = 7;
			string linea;

			Console.Clear();
			Console.WriteLine("****************************************************************************");
			Console.WriteLine("  Sumar Elementos de Diagonal Principal y Secundaria de una Matriz N x N ");
			Console.WriteLine("****************************************************************************");
			Console.WriteLine("Tamaño de la Matriz : ");
			linea = Console.ReadLine();
			numero = int.Parse(linea);

			Console.WriteLine();
			Console.WriteLine("****************************************************************************");

			// Generamos valores Aleatorios
			Random aleatorio = new Random();
			
			// Creamos Matriz
			int[,] matriz = new int[numero + 1, numero + 1];
			for(filas = 1; filas <= numero; filas++) 
			{
				for (columnas = 1; columnas <= numero; columnas++) 
				{
					matriz[filas, columnas] = aleatorio.Next(0, 9);
					Console.SetCursorPosition(columnas * 4, altura);
					Console.Write(matriz[filas, columnas]);
				}
				altura++;
			}

			// [Suma Diagonal Principal]
			for (filas = 1; filas <= numero; filas++) 
			{
				suma_diagonal_principal = suma_diagonal_principal + matriz[filas, filas];
			}

			// [Suma Diagonal Secundaria]
			columnas = numero;
			for (filas = 1; filas <= numero; filas++) 
			{
				suma_diagonal_secundaria = suma_diagonal_secundaria + matriz[filas, columnas];
				columnas--;
			}

			// Salida
			Console.WriteLine();
			Console.WriteLine("****************************************************************************");
			Console.WriteLine("Suma Diagonal Principal : {0}", suma_diagonal_principal);
			Console.WriteLine("Suma Diagonal Secundaria : {0}", suma_diagonal_secundaria);
			Console.WriteLine("****************************************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
