using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Ordenamiento_Arreglo_Metodo_Burbuja
	{

		public static void Operaciones() 
		{
			string linea;
			int cantidad = 0;
			int Auxiliar = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------ Ordenamiento de un Arreglo Método Burbuja ------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("¿Cuantos Elementos Quieres Agregar?");
			linea = Console.ReadLine();
			cantidad = int.Parse(linea);
			Console.WriteLine("********************************************************");

			int[] arreglo = new int[cantidad + 1];

			// Ingreso de Datos
			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine("Indice {0} ---->", i);
				linea = Console.ReadLine();
				arreglo[i] = int.Parse(linea);
			}

			// Proceso
			for (int i = 1; i <= cantidad; i++) 
			{
				for(int k = i + 1; k <= cantidad; k++) 
				{
					if ((arreglo[i] < arreglo[k])) 
					{
						Auxiliar = arreglo[k];
						arreglo[k] = arreglo[i];
						arreglo[i] = Auxiliar;
					}
				}
			}

			// Salida
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Arreglo Ordenado Descendentemente");
			Console.WriteLine("********************************************************");
			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine(arreglo[i]);
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa una tecla para volver al Menu.");
			Console.WriteLine("********************************************************");
			Console.ReadLine();
		} 
	}
}
