using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_6
	{

		/*	6)	 Crear un programa que pida al usuario dos números enteros y diga "Uno de los números es positivo",
				"Los dos números son positivos" o bien "Ninguno de los números es positivo", según corresponda.
		 */
		public static void Operaciones() 
		{
			int numero1 = 0;
			int numero2 = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 6 ] -------------------");
			Console.WriteLine("********************************************************");

			// Introducimos los datos
			Console.WriteLine("Ingresa el primer Numero : ");
			numero1 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			Console.WriteLine("Ingresa el Segundo Numero : ");
			numero2 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Filtramos los datos
			if ((numero1 >= 0) && (numero2 >= 0)) Console.WriteLine("Los dos números son positivos.");
			else if ((numero1 < 0) && (numero2 >= 0)) Console.WriteLine("Uno de los números es positivo");
			else if ((numero1 >= 0) && (numero2 < 0)) Console.WriteLine("Uno de los números es positivo.");
			else if ((numero1 < 0) && (numero2 < 0)) Console.WriteLine("Ninguno de los números es positivo.");
			
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
