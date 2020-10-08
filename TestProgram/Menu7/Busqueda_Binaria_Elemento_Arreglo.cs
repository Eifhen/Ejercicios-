using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Busqueda_Binaria_Elemento_Arreglo
	{


		public static void Operaciones() 
		{
			string linea;
			int cantidad = 0;
			int alto = 0;
			int bajo = 0;
			int central = 0;
			int busqueda = 0;
			int auxiliar = 0;
			bool encontrado = false;
			Random random = new Random();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---- Búsqueda Binaria de un Elemento en un Arreglo ----");
			Console.WriteLine("********************************************************");
			Console.WriteLine("¿Cuantos Elementos Quieres Agregar?");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			cantidad = int.Parse(linea);
			int[] arreglo = new int[cantidad + 1];

			// Ingresar Datos
			for (int i = 1;  i <= cantidad; i++) 
			{
				arreglo[i] = random.Next(0,99);
			}

			// Salida del Arreglo Aleatorio
			Console.WriteLine("[Arreglo Eleatorio]");
			Console.WriteLine("********************************************************");

			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine("Indice {0} ---> {1}", i,arreglo[i]);
			}
			Console.WriteLine("********************************************************");

			// Primero  Ordenamos el Arreglo
			for (int i = 1; i <= cantidad; i++) 
			{
				for (int k = 1; k <= cantidad - 1; k++) 
				{
					if ((arreglo[k] > arreglo[k + 1]))
					{
						auxiliar = arreglo[k];
						arreglo[k] = arreglo[k + 1];
						arreglo[k + 1] = auxiliar;
					}
				}
			}

			// Salida de Arreglo Ordenado
			Console.WriteLine("[Arreglo Ordenado]");
			Console.WriteLine("********************************************************");
			for (int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine("Indice {0} ---> {1}", i, arreglo[i]);
			}
			Console.WriteLine("********************************************************");

			// Busqueda
			Console.WriteLine();
			Console.WriteLine("Ingresa El Elemento Que Quieres Búscar");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			busqueda = int.Parse(linea);
			bajo = 1;
			alto = cantidad;

			// Central = ( BAJO + ALTO ) / 2
			while ((bajo <= alto) & (encontrado == false)) 
			{
				central = (bajo + alto) / 2;
				if (arreglo[central] == busqueda) encontrado = true;
				else 
				{
					if ((arreglo[central] > busqueda)) 
						alto = central - 1;
					else 
						bajo = central + 1;
				}
			}

			if (encontrado)
				Console.WriteLine(" {0} Encontrado en la Posicion {1} ", busqueda, central);
			else
				Console.WriteLine("El Elemento no Existe : {0}", busqueda);

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
