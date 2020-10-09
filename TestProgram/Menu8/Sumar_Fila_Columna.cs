using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Sumar_Fila_Columna
	{

		public static void Operaciones() 
		{
			string linea;
			int fila = 0;
			int columna = 0;
			int suma_filas = 0;
			int suma_columnas = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --- Sumar Elementos una Fila y una Columna Matriz 5x5 --");
			Console.WriteLine("********************************************************");

			// Ingreso
			int[,] matriz = new int[6, 6];
			
			for (fila = 1; fila <= 5; fila++) 
			{
				Console.WriteLine("Fila {0} ", fila);
				for (columna = 1; columna <= 5; columna++) 
				{
					Console.Write("Ingresa una Columna {0} / 5 --> ", columna);
					linea = Console.ReadLine();
					matriz[fila, columna] = int.Parse(linea);
				}
				Console.WriteLine();
			}

			// Imprimir Matriz
			Console.WriteLine("********************************************************");
			for(fila = 1; fila <= 5; fila++) 
			{
				for(columna = 1; columna <= 5; columna++) 
				{
					Console.Write(" [ {0} ] ", matriz[fila, columna]);
				}
				Console.WriteLine();
			}
			Console.WriteLine("********************************************************");

			// Suma Fila 2;
			for (columna = 1; columna <= 5; columna++) 
			{
				suma_filas = suma_filas + matriz[2, columna];
			}

			// Suma Columna 3;
			for(fila = 1; fila <= 5; fila++) 
			{
				suma_columnas = suma_columnas + matriz[fila, 3];
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Suma Fila 2 : {0} ", suma_filas);
			Console.WriteLine("Suma Columna 3 : {0} ", suma_columnas);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
