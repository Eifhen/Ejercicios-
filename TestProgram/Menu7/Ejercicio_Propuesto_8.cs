using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Ejercicio_Propuesto_8
	{
		/*
			Confeccionar un programa que permita obtener una serie de sumas 
			ejemplo primer número=2,
					segundo número=4; 
					suma1=2, 
					suma2=6; 
			es decir las sumas son resultado de la suma anterior
			mas el numero ingresado correspondiente.
 
		*/

		public static void Operaciones() 
		{
			string linea;
			int[] numeros = new int[6];
			int suma_numeros = 0;
			int resultado = 0;
			int i = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------------- Ejercicio Propuesto 8 ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine(" Confeccionar un programa que permita obtener una serie de sumas \n" +
							  "	Ejemplo: \n " +
							  "	primer número=2, \n" +
							  "	segundo número = 4; \n" +
							  "	suma1 = 2, \n" +
							  "	suma2 = 6; ");
			Console.WriteLine("********************************************************");
			
			// Ingresamos los Datos
			for(i = 1; i <= 5; i++) 
			{
				Console.WriteLine("Ingresa los valores a Sumar : {0} / 5", i);
				linea = Console.ReadLine();
				numeros[i] = int.Parse(linea);
				Console.WriteLine("********************************************************");
				Console.WriteLine();
			}

			// Sumamos
			for(i = 1; i <= 5; i++) 
			{
				resultado = suma_numeros + numeros[i];
				Console.WriteLine("Suma {0} :  {1} + {2} = {3} ", i, suma_numeros, numeros[i], resultado);
				suma_numeros = suma_numeros + numeros[i];
			}

			//Salida
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
