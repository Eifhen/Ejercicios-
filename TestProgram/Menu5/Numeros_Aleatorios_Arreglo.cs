using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Numeros_Aleatorios_Arreglo
	{

		public static void Operaciones()
		{
			string linea;
			int indice = 0;
			int cantidad = 0;
			Random numero_aleatorio = new Random();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- Numeros Aleatorios en un Arreglo ------------");
			Console.WriteLine("********************************************************");

			Console.WriteLine("Cuantos Numeros Aleatorios?");
			linea = Console.ReadLine();
			cantidad = int.Parse(linea);
			Console.WriteLine("********************************************************");

			// le estoy pasando el numero de indices al arreglo;
			double[] array_1 = new double[cantidad + 1];
			byte[] array_2 = new byte[cantidad + 1];

			// generamos aleatorios

			for (indice = 1; indice <= cantidad; indice++)
			{
				array_1[indice] = numero_aleatorio.Next(0, 99);
				// obtenemos un entero de 2 cifras
			}
			for (indice = 1; indice <= cantidad; indice++)
			{
				Console.SetCursorPosition(3, indice + 5);
				Console.WriteLine(array_1[indice]);

				Console.SetCursorPosition(30, indice +5);
				Console.WriteLine(array_2[indice]);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
