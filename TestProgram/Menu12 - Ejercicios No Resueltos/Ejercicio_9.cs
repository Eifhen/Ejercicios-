using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_9
	{

		/*
				 9) Crea un programa que escriba en pantalla los números pares 
					del 26 al 10 (descendiendo), usando "while".
		*/
		public static void Operaciones() 
		{
			int numero = 26;
			bool operacion;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 9 ] -------------------");
			Console.WriteLine("********************************************************");

			while (numero >= 10)
			{
				operacion = numero % 2 == 0;
				if (operacion) 
					Console.WriteLine("{0} Es par", numero);
				else 
					Console.WriteLine("{0} Es Impar", numero);

				Console.WriteLine("********************************************************");
				numero--;
			}

			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
