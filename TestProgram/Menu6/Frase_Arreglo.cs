using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Frase_Arreglo
	{

		/*Formas de Introducir datos en un array 
		 Ej 1: 
			string [] arreglo = new string[]
			{
				"nombre",
				"Edad",
				"ejemplo"
			};

		 Ej 2:
			string [] arreglo = 
			{
				"nombre",
				"Edad",
				"Ejemplo"
			};
		Ej 3 :
			string [] arreglo = new string [3]
			{
				"nombre",
				"Edad",
				"Ejemplo"
			};
		Ej 4 : 
			string [] arreglo;
			arreglo = new string []
			{
				"nombre",
				"Edad",
				"Ejemplo"
			};
		Ej 5 :
			string [] arreglo;
			arreglo = new string [3]
			{
				"nombre",
				"Edad",
				"Ejemplo"
			};
		 */
		public static string Frase(int StartIndex, int Length, string parametro ) 
		{
			string frase = parametro.Substring(StartIndex,Length);
			return frase;
		
		}
		public static void Operaciones() 
		{
			string linea;
			int indice = 0;
			int longitud_cadena = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------ Pasar Frases a un Arreglo. ---------------");
			Console.WriteLine("********************************************************");

			Console.WriteLine("Introduce una Frase : ");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");

			longitud_cadena = linea.Length;
			string[] arreglo = new string[longitud_cadena + 1];
			string[] arreglo2 = { linea };
		

			// pasamos el string caracter por caracter al arreglo1 y 
			// pasamos la frase compleata al arreglo2;

			for (indice = 1; indice <= longitud_cadena; indice++) 
			{
				arreglo[indice] = Frase(indice - 1, 1, linea);
			}
			//salida
			for(indice = 1; indice <= longitud_cadena; indice++) 
			{
				Console.WriteLine(arreglo[indice]);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("------> Frase Completa <-----");
			Console.WriteLine("********************************************************");

			for (int i = 0; i < arreglo2.Length; i++) 
			{
				Console.WriteLine(arreglo2[i]);
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
