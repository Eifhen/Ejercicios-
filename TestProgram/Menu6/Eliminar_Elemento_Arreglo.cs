using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Eliminar_Elemento_Arreglo
	{

		
		public static void Operaciones()
		{

			int indice_elemento = 0;
			int cantidad;
			string linea ,seleccion_s_n;
			bool seleccion = false;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------- Eliminar Elementos de un Arreglo -----------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Elementos?");
			linea = Console.ReadLine();
			cantidad = int.Parse(linea);
			Console.WriteLine("********************************************************");

			int[] array_1 = new int[cantidad + 1];
			int[] array_nuevo = new int[cantidad];

			// Ingresamos datos

			for( int i = 1; i < cantidad + 1; i++) 
			{
				Console.Write("POSICIÓN {0} ==>", i);
				linea = Console.ReadLine();
				array_1[i] = int.Parse(linea);
			}

			// Eliminamos un Elemento

			do
			{
				Console.WriteLine("Desea Eliminar un Elemento de la Matriz?    S / N");
				linea = Console.ReadLine();
				Console.WriteLine("********************************************************");
				seleccion_s_n = linea.ToLower();
			
				switch (seleccion_s_n) 
				{
					case "s":
						Console.WriteLine("Ingresa el indice del elemento que deseas Eliminar");
						linea = Console.ReadLine();
						Console.WriteLine("********************************************************");
						indice_elemento = int.Parse(linea);
						Eliminar_Elemento(indice_elemento, array_1, array_nuevo, cantidad);
						break;
					case "n":
						Console.WriteLine("Bien, Has Seleccionado la opcion : No.");
						Console.ReadLine();
						seleccion = true;
						break;
					default:
						Console.WriteLine("Opcion Invalida, Programa terminado.");
						seleccion = true;
						break;
				}
			} while (seleccion == false);

			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}

		public static void Eliminar_Elemento(int indice_elemento, int[] array_1, int[] array_nuevo, int cantidad)
		{
			// PROCESO
			// TRANSLADAMOS los DATOS ANTES DE LA POSICIÓN
			for( int i = 0; i < indice_elemento; i++) 
			{
				array_nuevo[i] = array_1[i];
			}
			// Transladamos datos despues de la Posición
			for (int i = indice_elemento + 1; i <= cantidad; i++) 
			{
				array_nuevo[i - 1] = array_1[i];
			}
			//Salida
			Console.WriteLine();
			Console.WriteLine("Nuevo Arreglo : ");
			Console.WriteLine("********************************************************");
			for (int i = 1; i < cantidad; i++) 
			{
				Console.WriteLine(array_nuevo[i]);
			}
			Console.ReadLine();

		}
	}
}
