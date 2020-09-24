using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Suma_N_Numeros
	{

		public void Operaciones() 
		{
			string linea;
			byte cantidad;
			int suma = 0;
			int numero;

			Console.Clear();
			Console.WriteLine("*********************************************************");
			Console.WriteLine("----------------- Suma de N Numeros ---------------------");
			Console.WriteLine("*********************************************************");
			Console.WriteLine("Ingresa el limite de numeros a sumar.");
			Console.WriteLine("*********************************************************");

			linea = Console.ReadLine();
			cantidad = byte.Parse(linea);

			for(int i = 1; i <= cantidad; i++) 
			{
				Console.WriteLine("*********************************************************");
				Console.WriteLine("[ {0} ]-- Ingresa un Numero:",i);
				Console.WriteLine("*********************************************************");
				linea = Console.ReadLine();
				numero = int.Parse(linea);
				suma += numero;
			}
			Console.WriteLine("*********************************************************");
			Console.WriteLine("La Suma total es : {0}",suma);
			Console.WriteLine("La Media Aritmetica es : {0}", suma / cantidad);
			Console.WriteLine("*********************************************************");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();
		}
	}
}
