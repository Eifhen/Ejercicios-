using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_5
	{
		/*
		 *  5) Crear un programa que pida una letra al usuario y diga si se trata de una vocal.
		*/
		public static void Operaciones() 
		{

			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 5 ] -------------------");
			Console.WriteLine("********************************************************");

			// Introducimos los datos
			Console.WriteLine("Ingresa una Letra : ");
			cadena = Console.ReadLine();

			// Filtramos
			cadena = cadena.ToLower();
			switch (cadena) 
			{
				case "a":
					Console.WriteLine("la letra [ {0} ], Es una Vocal.", cadena);
					break;
				case "e":
					Console.WriteLine("la letra [ {0} ], Es una Vocal.", cadena);
					break;
				case "i":
					Console.WriteLine("la letra [ {0} ], Es una Vocal.", cadena);
					break;
				case "o":
					Console.WriteLine("la letra [ {0} ], Es una Vocal.", cadena);
					break;
				case "u":
					Console.WriteLine("la letra [ {0} ], Es una Vocal.", cadena);
					break;
				default:
					Console.WriteLine("la letra [ {0} ], No Es una Vocal.", cadena);
					break;
			}

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
