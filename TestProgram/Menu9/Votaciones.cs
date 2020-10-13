using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Votaciones
	{
		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int numero = 0;
			int suma = 0;
			int k = 0;
			int mayor = 0;
			string cadena;
			Random aleatorio = new Random();


			Console.Clear();
			Console.WriteLine("************************************************************");
			Console.WriteLine("* Votaciones: Suma de Cada Columna Representa un Candidato * \n" +
							  "*             Obtener al Candidato Ganador.                *");
			Console.WriteLine("************************************************************");

			// Poblamos la matriz con valores aleatorios
			Console.WriteLine("Tamaño de la Matriz : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("************************************************************");

			int[,] matriz = new int[100, 100];
			int[] arreglo = new int[numero + 1];

			Console.WriteLine("*******************[ Matriz Original]**********************");
			Console.WriteLine();

			for (fila = 1; fila <= numero; fila++)
			{
				for (columna = 1; columna <= numero; columna++)
				{
					matriz[fila, columna] = aleatorio.Next(0, 100);
					Console.SetCursorPosition(columna * 4, fila + 8);
					Console.Write(matriz[fila, columna]);
				}
			}
			Console.WriteLine();
			Console.WriteLine();
			Console.WriteLine("**********************************************************");

			// [ Proceso : Suma de Columnas ]
			for (columna = 1; columna <= numero; columna++)
			{
				suma = 0;
				for (fila = 1; fila <= numero; fila++) 
				{
					suma = suma + matriz[fila, columna];
				}
				arreglo[columna] = suma;
			}

			// [ Obtenemos al Candidato Ganador ]

			mayor = arreglo[1];
			k = 1;
			for( columna = 2; columna <= numero; columna++) 
			{
				if(arreglo[columna] > mayor) 
				{
					mayor = arreglo[columna];
					k = columna;
				}
			}

			// [ Salida ]
			
			for (columna = 1; columna <= numero; columna++)
			{
				Console.SetCursorPosition(columna * 4, 21);
				Console.Write(arreglo[columna]);
			}

			Console.WriteLine();
			Console.WriteLine("**********************************************************");
			Console.WriteLine();
			Console.WriteLine("**********************************************************");
			Console.WriteLine("NÚMERO MAYOR ES {0} ESTA EN LA COLUMNA {1}", mayor, k);
			Console.WriteLine("**********************************************************");
			Console.WriteLine();
			Console.WriteLine("**********************************************************");
			Console.WriteLine("Se suman los valores de cada columna y la columna con el \n" +
							  "numero mas alto es la ganadora.");
			Console.WriteLine("**********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
