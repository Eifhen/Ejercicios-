using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Suma_Arreglos
	{

		public static void Operaciones()
		{
			string linea;
			int[] arreglo_1 = new int[5];
			int[] arreglo_2 = new int[5];
			int[] suma_arreglos = new int[5];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------- Suma de Dos Arreglos de 5 Elementos ----------");
			Console.WriteLine("********************************************************");

			// Ingreso DATOS
			Console.WriteLine();
			Console.WriteLine("Ingresa los numeros del primer arreglo : ");
			Console.WriteLine("********************************************************");
			for (int i = 0; i < 5; i++) 
			{
				// Arreglo 1
				Console.WriteLine("Indice {0}", i);
				linea = Console.ReadLine();
				arreglo_1[i] = int.Parse(linea);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Ingresa los numeros del segundo arreglo : ");
			Console.WriteLine("********************************************************");
			for (int i = 0; i < 5; i++)
			{
				// Arreglo 2 
				Console.WriteLine("Indice {0}", i);
				linea = Console.ReadLine();
				arreglo_2[i] = int.Parse(linea);
				// Suma
				suma_arreglos[i] = arreglo_1[i] + arreglo_2[i];
			}


			Console.WriteLine("*******************[Primer Arreglo]-*******************");
			//Salida
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(arreglo_1[i]);
			}
			Console.WriteLine("******************[Segundo Arreglo]-*******************");
			for (int i = 0; i < 5; i++)
			{
				Console.WriteLine(arreglo_2[i]);
			}
			Console.WriteLine("*******************[Suma Arreglos]**********************");
			for (int i = 0; i < 5; i++) 
			{
				Console.WriteLine(suma_arreglos[i]);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
