using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Suma_de_Elementos_Arreglo
	{

		public static void Operaciones() 
		{
			int numeros_a_sumar;
			int suma_numeros_impares = 0;
			int suma_numeros_pares = 0;
			string linea;
			int[] array_numeros = new int[10];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --- Suma de Elementos Pares e Impares en un Arreglo ---");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Numeros quieres sumar? Maximo 10 Numeros.");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			numeros_a_sumar = int.Parse(linea);
			Console.WriteLine("********************************************************");
			Console.WriteLine("La Cantidad de Numeros a Sumar es de : {0}", numeros_a_sumar);
			Console.WriteLine("********************************************************");

			// Ingresan Datos al Array

			for ( int i = 0; i <= numeros_a_sumar; i++) 
			{
				Console.WriteLine(" Posicion {0} --> Ingresa un Numero :", i);
				linea = Console.ReadLine();
				array_numeros[i] = int.Parse(linea);
			}

			// PROCESO

			for (int i = 0; i <= numeros_a_sumar; i++) 
			{
				if ((array_numeros[i] % 2) == 0)
					suma_numeros_pares = suma_numeros_pares + array_numeros[i];
				else
					suma_numeros_impares = suma_numeros_impares + array_numeros[i];
			}

			// Salida

			Console.WriteLine();
			Console.WriteLine("Suma de Numeros Pares {0} ", suma_numeros_pares);
			Console.WriteLine("Suma de Numeros Impares {0} ", suma_numeros_impares);
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
