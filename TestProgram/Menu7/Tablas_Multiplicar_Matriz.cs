using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Tablas_Multiplicar_Matriz
	{

		public static void Operaciones() 
		{
			string linea;
			int numero_filas = 0;
			int numero_columnas = 0;
			int columnas = 0;
			int filas = 0;
			int numero = 0;
			int[,] matriz;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- Tablas de Multiplicar Matriz N x N ----------");
			Console.WriteLine("********************************************************");

			// Generamos los Numeros de la Matriz
			Console.WriteLine("Numero de Filas de la Matriz : ");
			linea = Console.ReadLine();
			numero_filas = int.Parse(linea);
			Console.WriteLine("********************************************************");

			Console.WriteLine("Numero de Columnas de la Matriz : ");
			linea = Console.ReadLine();
			numero_columnas = int.Parse(linea);
			Console.WriteLine("********************************************************");

			matriz = new int[numero_filas + 1, numero_columnas + 1];

			// Tabla de Multiplicar
			for(filas = 1; filas <= numero_filas; filas++) 
			{
				for(columnas = 1; columnas <= numero_columnas; columnas++) 
				{	
					// va multiplicando los numeros y guardandolos en la matriz
					matriz[filas, columnas] = filas * columnas;
				}
			}

			// Salida 
			for(filas = 1; filas <= numero_filas; filas++) 
			{
				Console.Write(" [ Tabla del : {0} ] -->", filas);
				for(columnas = 1; columnas <= numero_columnas; columnas++)
				{
					Console.Write(" {0} ", matriz[filas,columnas]);
				}
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
