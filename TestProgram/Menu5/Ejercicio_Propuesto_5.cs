using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Ejercicio_Propuesto_5
	{
		/*
			Crear un programa que pida números positivos al usuario, y vaya calculando la suma
			de todos ellos (terminará cuando se teclea un número negativo o cero).
		 */
		public static void Operaciones() 
		{
			string linea;
			int numero, resto;
			int total = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------------- Ejercicio Propuesto 5 ----------------");
			Console.WriteLine("********************************************************");

			do 
			{
				Console.WriteLine("Ingresa un Numero");
				Console.WriteLine("********************************************************");
				linea = Console.ReadLine();
				numero = int.Parse(linea);
				resto = numero % 2;
				if (resto == 0 && numero != 0) total = total + numero;

			} while (resto == 0 && numero != 0);

			Console.WriteLine("La Suma de todos los numeros Ingresados es : {0} ", total);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulse para volver al Menu.");
			Console.ReadLine();

		}
	}
}
