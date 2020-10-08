using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Prueba_Array
	{

		public static void Operaciones() 
		{
			int acumular = 0;

			// probar ultimo elemento de un array
			int[] array = new int[4]
			{
				11,   // indice 0
				12,   // indice 1
				13,   // indice 2
				14    // indice 3
					 // indice 4 -- el arreglo tiene 4 indices pero no esta siendo usado.
			};
			Console.WriteLine();
			Console.WriteLine("****************************************************************************");
			Console.WriteLine("Array de Prueba");
			Console.WriteLine("****************************************************************************");

			for (int i = 0; i <= array.Count() - 1; i++)
			{
				Console.WriteLine(array[i]);
				acumular++;
			}
			int ultimo = array.Length - 1;  // devuelve la longitud - 1 lo que es igual a 3;
			int longitud = array.Length;  // la longitud del arreglo es 4;

			Console.WriteLine("****************************************************************************");
			Console.WriteLine("El Valor de la Variable Acumular es de : {0}", acumular);
			Console.WriteLine("Longitud Arreglo : {0}", longitud); 
			Console.WriteLine("Ultimo Elemento del Array de Prueba {0}", array[ultimo]); // imprime el arreglo en la posicion 3 
			Console.WriteLine("****************************************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
