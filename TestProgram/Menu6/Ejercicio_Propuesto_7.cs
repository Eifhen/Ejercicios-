using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Ejercicio_Propuesto_7
	{

		/*
			Confeccionar un programa que permita cargar los nombres de 5 operarios y sus sueldos
			respectivos. Mostrar el sueldo mayor y el nombre del operario.	
		*/
		public static void Operaciones() 
		{
			string linea;
			string[] nombre_operario = new string[6];
			int[] sueldo_operario = new int[6];
			int i = 1;
			int k = 1;
			int operario_mayor_sueldo = sueldo_operario[1];
			string nombre_operario_mayor_sueldo = nombre_operario[1];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- Ejercicio Propuesto 7 -----------------");
			Console.WriteLine("********************************************************");


			// Poblamos los Arreglos
			while( i <= 5) 
			{
				Console.WriteLine("Ingresa el Nombre del operario : {0} / 5", i);
				linea = Console.ReadLine();
				nombre_operario[i] = linea;

				Console.WriteLine("Ingresa el Salario del operario : {0} / 5", i);
				linea = Console.ReadLine();
				sueldo_operario[i] = int.Parse(linea);
				i++;
				Console.WriteLine("********************************************************");
				Console.WriteLine();
			}

			// Filtramos por el Salario Mayor
			while (k < nombre_operario.Length)
			{
				if (sueldo_operario[k] >= operario_mayor_sueldo)
				{
					operario_mayor_sueldo = sueldo_operario[k];
					nombre_operario_mayor_sueldo = nombre_operario[k];
					k++;
				}
				else 
				{
					Console.WriteLine("El Empleado Con el Sueldo Mas Alto es : {0}", nombre_operario_mayor_sueldo);
					Console.WriteLine("Con un Salario de : {0}", operario_mayor_sueldo);
					k = nombre_operario.Length + 1; 
				}
				
			}
			Console.WriteLine("********************************************************");
			Console.ReadLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
