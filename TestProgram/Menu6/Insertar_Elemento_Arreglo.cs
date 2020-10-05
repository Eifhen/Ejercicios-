using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Insertar_Elemento_Arreglo
	{

		public static void Operacioens()
		{
			string linea;
			byte cantidad = 0, indice = 0;
			int elemento = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- Insertar un Elemento en un Arreglo ----------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Elementos?");
			linea = Console.ReadLine();
			cantidad = byte.Parse(linea);

			int[] array_1 = new int[cantidad + 1];
			int[] array_2 = new int[cantidad + 2];

			// Ingresamos Datos
			Console.WriteLine("********************************************************");
			Console.WriteLine("            -------- [ Array 1 ] --------");
			Console.WriteLine("********************************************************");

			for (int i = 0; i <= cantidad; i++) 
			{
				Console.WriteLine("");
				Console.Write("Indice {0} --> ", i);
				linea = Console.ReadLine();
				array_1[i] = int.Parse(linea);
			}

			Console.WriteLine("********************************************************");
			Console.WriteLine("            -------- [ Array 2 ] --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Elemento a Insertar");
			Console.WriteLine("********************************************************");
			linea = Console.ReadLine();
			elemento = int.Parse(linea);
			Console.WriteLine("********************************************************");

			do
			{
				Console.WriteLine("Indice en donde desea Insertar el Elemento--> ");
				linea = Console.ReadLine();
				indice = byte.Parse(linea);
			} while ((indice < 1) | (indice > cantidad));

			// PROCESO
			// TRANSLADAMOS DATOS ANTES DE LA POSICION

			for(int i = 0; i <= indice - 1; i++) 
			{
				array_2[i] = array_1[i];
			}

			// Insertamos Elemento

			array_2[indice] = elemento;

			// Trasladamos datos despues de la posicion

			for (int i = indice; i <= cantidad; i++) 
			{
				array_2[i + 1] = array_1[i];
			}

			// Salida

			Console.WriteLine();
			for (int i = 1; i <= cantidad + 1; i++) 
			{
				Console.WriteLine(array_2[i]);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
