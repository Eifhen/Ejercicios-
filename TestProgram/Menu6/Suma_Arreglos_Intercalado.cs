using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Suma_Arreglos_Intercalado
	{

		public static void Operaciones() 
		{
			string linea;
			int[] arreglo_1 = new int[6];
			int[] arreglo_2 = new int[6];
			int[] suma_intercalada = new int[6];
			int posicion = 5;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------- Suma de Dos Arreglos Intercalado ------------");
			Console.WriteLine("********************************************************");

			// Poblamos los Arreglos

			Console.WriteLine(" -------------> [ Arreglo  ]");
			Console.WriteLine("********************************************************");
			for (int k = 1; k <= 5; k++)
			{
				Console.WriteLine("Indice {0}", k);
				linea = Console.ReadLine();
				arreglo_1[k] = int.Parse(linea);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------> [ Arreglo 2 ]");
			Console.WriteLine("********************************************************");
			for (int n = 1; n <= 5; n++)
			{
				Console.WriteLine("Indice {0}", n);
				linea = Console.ReadLine();
				arreglo_2[n] = int.Parse(linea);
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// Suma Intercalada
			Console.WriteLine(" -------------> [ Suma Intercalada ]");
			Console.WriteLine("********************************************************");
			for (int i = 1; i <= 5; i++) 
			{
				suma_intercalada[i] = arreglo_1[i] + arreglo_2[posicion];
				Console.WriteLine("Suma Intercalada : {0} + {1} = {2}",arreglo_1[i], arreglo_2[posicion], suma_intercalada[i]);
				posicion--;
			}

			// Salida
	
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
