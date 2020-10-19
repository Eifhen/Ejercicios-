using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_8
	{
		/*
			8) Crea un programa que escriba en pantalla los números del 1 al 10, usando "while"
		 */

		public static void Operaciones() 
		{
			int numero = 0;
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 8 ] -------------------");
			Console.WriteLine("********************************************************");

			// Salida
			Console.WriteLine("A Continuacion se Imprimen los Números del 1 al 10");
			Console.WriteLine("********************************************************");
			while (numero <= 10) 
			{
				Console.SetCursorPosition(4, numero + 6);
				Console.WriteLine(numero);
				numero++;
			}

			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
