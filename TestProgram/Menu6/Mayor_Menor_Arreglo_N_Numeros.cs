using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Mayor_Menor_Arreglo_N_Numeros
	{

		public static void Operaciones()
		{
			string linea;
			int Mayor = 0, Menor = 0, indice = 0, cantidad_numeros = 0;


			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine("----- Mayor o Menor de un Arreglo de N Elementos. ------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Numeros?");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			cantidad_numeros = int.Parse(linea);
			int[] array_numeros = new int[cantidad_numeros + 1];

			// Ingresar Elementos al Array
			for (int i = 1; i <= cantidad_numeros; i++) 
			{
				Console.WriteLine("Posicion {0} ----> Ingresa un Numero : ", i);
				linea = Console.ReadLine();
				array_numeros[i] = int.Parse(linea);
			}

			// Operacion mayor y menor
			Mayor = array_numeros[1];
			Menor = array_numeros[1];
			for(int i = 2; i <= cantidad_numeros; i++) 
			{
				if ((array_numeros[i] > Mayor)) 
				{
					Mayor = array_numeros[i];
					indice = i;
				}
				if ((array_numeros[i] < Menor))
					Menor = array_numeros[i];
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("El Numero Mayor es : {0} y está en la posicion {1} ",Mayor, indice);
			Console.WriteLine("El Numero Menor es : {0} ", Menor);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu");
			Console.ReadLine();
		}
	}
}
