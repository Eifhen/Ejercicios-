using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Ejercicio_Propuesto
	{

		// Crea un Programa que muestre la letra A y Z descendiendo.
		// la clave aqui esta en los numeros 65 al 90 los cuales contienen
		// la secuencia completa del alfabeto entonces lo unico que hacemos es imprimir un string
		// de la clase "CHAR" en la posicion en la posicion en que se encuentra la variable "i" del for
		// al hacerlo de con la secuencia "for ( int i = 90; i >= 65; i--)" se imprimira el abecedario de
		// forma descendente pero si lo hicieramos "for(int i = 65; i <= 90; i++)" imprimiriamos
		// de forma ascendente.
		public static void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("******************************************************");
			Console.WriteLine(" ------ Ejercicio Propuesto :  ABC Descendiente ------");
			Console.WriteLine("******************************************************");
			
			for(int i = 90; i >= 65; i--) 
			{
				Console.WriteLine("Letra : {0}",Convert.ToString((char)i));
			}
			Console.WriteLine("Pulsa una tecla para volver al Menu");
			Console.ReadLine();
		}
	}
}
