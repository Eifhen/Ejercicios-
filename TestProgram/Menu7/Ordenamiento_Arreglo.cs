using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Ordenamiento_Arreglo
	{


		public static void Operaciones() 
		{
			string linea;
			int cantidad = 0, auxiliar = 0;

			while (cantidad == 0)
			{

				Console.Clear();
				Console.WriteLine("********************************************************");
				Console.WriteLine(" ------------- Ordenamiento de un Arreglo --------------");
				Console.WriteLine("********************************************************");
				Console.WriteLine("Cuantos Elementos? (Maximo 10)");
				linea = Console.ReadLine();
				cantidad = int.Parse(linea);
				if (cantidad > 10)
				{
					Console.WriteLine("********************************************************");
					Console.WriteLine("El Valor esta fuera de rango.");
					Console.WriteLine("********************************************************");
					Console.ReadLine();
					cantidad = 0;
				}
			}

			int[] arreglo = new int[cantidad + 1];
				

			// Ingresamos los datos
			for(int i = 1; i <= cantidad; i++) 
			{
				Console.Write("Indice {0} --> ", i);
				linea = Console.ReadLine();
				arreglo[i] = int.Parse(linea);
				Console.WriteLine("********************************************************");
			}

			// Proceso
			for(int i = 1; i <= cantidad; i++) 
			{
				for(int k = i; k <= cantidad; k++) 
				{
					if ((arreglo[k] > arreglo[i])) 
					{
						auxiliar = arreglo[k];
						arreglo[k] = arreglo[i];
						arreglo[i] = auxiliar;
					}
				}
			}
			// Arreglo Ordenado Descendentemente
			Console.WriteLine("Arreglo Ordenado Descendentemente");
			Console.WriteLine("********************************************************");
			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine(arreglo[i]);
			}
			Console.WriteLine("");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
