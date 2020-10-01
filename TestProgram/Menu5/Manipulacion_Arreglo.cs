using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Manipulacion_Arreglo
	{
		/*
			{ Manipulacion de Arreglos }

			[Forma 1]
			Asignando valores al array al mismo tiempo que se 
			declara, la lista de valores debe ir encerrada entre llaves.
			el Arreglo_1 muestra la primera forma.
			
			[Forma 2]
			Declarar primero la variable que contendrá el array,
			asignar valores al array al mismo tiempo que se 
			instancia.la lista de valores debe ir encerrada 
			entre llaves. 
			el Arreglo_2 muestra la segunda forma.
		 */
		public static void Operaciones() 
		{

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- Manipulacion de Arreglos ----------------");
			Console.WriteLine("********************************************************");

			string[] Arreglo_1 =
			{
				"Lorena",
				"Gabriel,",
				"Joel"
			};

			int[] Arreglo_2;
			Arreglo_2 = new int[6]
			{
				10,
				15,
				20,
				25,
				30,
				35
			};

			for(byte k = 0; k < Arreglo_1.Length; k++) 
			{
				Console.WriteLine("Elementos del Arreglo 1 : {0}", Arreglo_1[k]);
				Console.WriteLine("********************************************************");
			}
			for (byte k = 0; k < Arreglo_2.Length; k++)
			{
				Console.WriteLine("Elementos del Arreglo 2 : {0}", Arreglo_2[k]);
				Console.WriteLine("********************************************************");
			}
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
