using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Menor_en_Arreglo
	{
		private int ElementoMenor(int[] vector, int longitud) 
		{
			int menor = 0;
			int k = 0;

			menor = vector[1];
			for (k = 2; k <= longitud; k++) 
			{
				if ((vector[k] <= menor)) menor = vector[k];
			}
			return menor;
		}
		public static void Operaciones() 
		{
			int k = 0;
			int cantidad = 0;
			int resultado = 0;
			string cadena;
			Random aleatorio = new Random();
			Menor_en_Arreglo objeto = new Menor_en_Arreglo();
		
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- [ Menor en un Arreglo ] ---------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Elementos?");
			cadena = Console.ReadLine();
			cantidad = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Poblamos el Arreglo
			int[] arreglo = new int[cantidad + 1];
			for(k = 1; k <= cantidad; k++) 
			{
				arreglo[k] = aleatorio.Next(1, 100);
				Console.Write("{0}, ", arreglo[k]);
			}

			// Extraemos el Elemento de menor valor
			Console.WriteLine();
			resultado = objeto.ElementoMenor(arreglo, cantidad);

			// Salida
			Console.WriteLine("********************************************************");
			Console.WriteLine("El Elemento Menor es : {0}", resultado);
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
