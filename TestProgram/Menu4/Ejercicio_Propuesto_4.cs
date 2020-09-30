using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Ejercicio_Propuesto_4
	{
		/*	Crear un programa calcule cuantas cifras tiene un número entero positivo (pista: se
			puede hacer dividiendo varias veces entre 10).
		*/
		public static void Operaciones() 
		{
			string linea; 
			int Numero_Digitos;
			int Numero;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- Ejercicio Propuesto 4 -----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Crear un Programa que calcule cuantas cifras tiene un");
			Console.WriteLine("numero entero Positivo.");
			Console.WriteLine("");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Introduce un Numero : ");
			Console.WriteLine("********************************************************");

			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");

			Numero_Digitos = linea.Length;
			Numero = int.Parse(linea);

			Console.WriteLine("El Numero {0} tiene : {1} digitos.", Numero, Numero_Digitos);
			Console.WriteLine("********************************************************");
			Console.WriteLine("");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
