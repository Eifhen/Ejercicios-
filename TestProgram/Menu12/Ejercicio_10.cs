using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_10
	{

		/*
			10) Crea un programa que escriba en pantalla los números del 1 al 10, usando "do..while"	 
		*/
		public static void Operaciones() 
		{
			int numero = 0;
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 10 ] -------------------");
			Console.WriteLine("********************************************************");

			Console.WriteLine("A Continuacion se imprimen los numeros del 1 al 10 usando Do While");
			Console.WriteLine("********************************************************");
			
			do 
			{
				Console.WriteLine(numero);
				numero++;
			
			} while (numero <= 10);

			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
