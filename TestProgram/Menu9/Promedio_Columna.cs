using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Promedio_Columna
	{

		public static void Operaciones() 
		{

			int fila = 0;
			int columna = 0;
			int numero = 0;
			int suma = 0;
			string cadena;
			Random aleatorio = new Random();

			Console.Clear();
			Console.WriteLine("**********************************************************");
			Console.WriteLine("Promedio de Cada Columna de una Matriz de NxN en un Vector");
			Console.WriteLine("**********************************************************");

			// Poblamos la Matriz con valores Aleatorios
			Console.WriteLine("Tamaño de la Matriz");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("**********************************************************");

			int[,] matriz = new int[numero + 1, numero + 1];
			double[] vector = new double[numero + 1];

			Console.WriteLine("*******************[ Matriz Original]**********************");
			Console.WriteLine();
			for (fila = 1; fila <= numero; fila++) 
			{
				for (columna = 1; columna <= numero; columna++) 
				{
					matriz[fila, columna] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(columna * 4, fila + 7);
					Console.Write(matriz[fila, columna]);
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("**********************************************************");

			// [ Proceso : Sacar Promedio a los valores de cada columna e insertarlos en el vector ]
			for (columna = 1; columna <= numero; columna++)
			{
				suma = 0;
				for (fila = 1; fila <= numero; fila++)
				{
					suma = suma + matriz[fila, columna];
				}
				vector[columna] = suma / numero;
			}

			// [ Salida ]
			Console.WriteLine("******* [ Promedio Por Columna ] ***************************");
			Console.WriteLine();

			for (columna = 1; columna <= numero; columna++) 
			{	
				//string.Format("{0:##.0}", vector[columna])
				Console.WriteLine(string.Format("Promedio Columna {0} : {1:##.1}", columna, vector[columna]));
			}

			Console.WriteLine();
			Console.WriteLine("**********************************************************");

			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
