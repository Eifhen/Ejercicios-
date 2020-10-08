using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Buscar_Elemento_en_Arreglo
	{

		public static void Operaciones() 
		{

			string linea;
			int cantidad = 0;
			int total = 0;
			int busqueda = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------- Búsqueda de un Elemento en un Arreglo ---------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("¿Cuantos Elementos Quieres Agregar?");
			linea = Console.ReadLine();
			cantidad = int.Parse(linea);
			Console.WriteLine("********************************************************");

			int[] arreglo = new int[cantidad + 1];

			// Ingresar Datos
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine();

			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine("Indice {0} --->", i);
				linea = Console.ReadLine();
				arreglo[i] = int.Parse(linea);
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// Buscar Elemento
			Console.WriteLine("Elemento a Buscar : ");
			linea = Console.ReadLine();
			busqueda = int.Parse(linea);

			// Proceso
			for (int i = 1; i <= cantidad; i++) 
			{
				if ((arreglo[i] == busqueda)) total++;
			}

			// Salida
			Console.WriteLine("********************************************************");
			Console.WriteLine("Total de Elementos {0}", total);
			Console.WriteLine("********************************************************");
			Console.WriteLine("El Elemento Que estas Buscando es : {0}", busqueda);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
