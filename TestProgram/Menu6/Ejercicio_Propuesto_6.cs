using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Ejercicio_Propuesto_6
	{
		/*
			Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas.
			Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas
			mayores de edad (mayores o iguales a 18 años)
		*/
		public static void Operaciones() 
		{

			string linea;
			int cantidad = 6;
			string[] nombre = new string[cantidad];
			string[] apellido = new string[cantidad];
			int[] edad = new int[cantidad];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------------- Ejercicio Propuesto 6 ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine(" Desarrollar un Programa que Permita cargar 5 nombres de personas \n " +
							  "y sus edades respectivas. luego de realizar la carga por teclado \n " +
							  "de todos los datos, imprimir los nombres de las personas mayores de edad \n " +
							  "(Mayores o iguales a 18 años)");
			Console.WriteLine("********************************************************");
			
			// Definimos el numero de entradas
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Ingresa el Nombre, Apellido y Edad.");
			Console.WriteLine("********************************************************");
			Console.WriteLine();

			//Ingresamos los datos
			for (int i = 1; i < nombre.Length; i++) 
			{
				Console.WriteLine("Ingresa el Nombre : {0} / {1}", i ,cantidad -1);
				linea = Console.ReadLine();
				nombre[i] = linea;

				Console.WriteLine("Ingresa el Apellido : {0} / {1}", i, cantidad -1);
				linea = Console.ReadLine();
				apellido[i] = linea;

				Console.WriteLine("Ingresa la Edad : {0} / {1}", i, cantidad -1);
				linea = Console.ReadLine();
				edad[i] = int.Parse(linea);
				Console.WriteLine("********************************************************");
				Console.WriteLine();
			}

			//Lista de personas agregadas
			Console.WriteLine("********************************************************");
			Console.WriteLine("Lista de Personas Ingresadas: ");
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			for (int i = 1; i < nombre.Length; i++) 
			{
				Console.WriteLine("[ Nombre : {0} ] \n" +
								  "[ Apellido : {1} ] \n" +
								  "[ Edad : {2} ]", nombre[i], apellido[i], edad[i]);
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// filtramos por mayores de 18 años
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Lista de Personas Mayores de Edad : ");
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			for (int i = 1; i < nombre.Length; i++) 
			{
				if(edad[i] >= 18) 
				{
					Console.WriteLine("[ Nombre : {0} ] \n" +
					  "[ Apellido : {1} ] \n" +
					  "[ Edad : {2} ]", nombre[i], apellido[i], edad[i]);
					Console.WriteLine();
				}

			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();

		}
	}
}
