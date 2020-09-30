using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Numero_Primo
	{


		/*
			Nota: Me di cuenta que, en este ejercicio el bucle while necesita que 2 condiciones sean ciertas
			para activarse, pero solo necesita que una condicion sea verdadera para salir del bucle
			en este caso las dos condiciones son :
			 (1) ( x < numero )
					Mientras que la variable "x" sea menor que la variable "numero"
					el bucle se iniciara, ( esta es la condicion para ENTRAR en el bucle)
			 (2) (sw == 0)
					Mientras que la variable "sw" sea igual a 0 el bucle se iniciara 
					
			Si ambas condiciones se cumplen entonces el bucle puede iniciar, pero esto no significa que 
			ambas condiciones tengan que ser verdaderas para poder salir del bucle, bastara
			conque una de las dos condiciones sea verdadera para salir, ya sea que : 
			la variable "x" sea mayor que la variable numero , o que la variable "sw" tenga un
			valor distinto a "0", en cualquiera de los dos casos el bucle terminaria.
		 */
		public static void Operaciones() 
		{

			string linea;
			int numero, x, sw, residuo;
			x = 2;
			sw = 0;

			Console.Clear();
			Console.WriteLine("*******************************************************");
			Console.WriteLine(" --------- Comprobar si un Numero es Primo ------------");
			Console.WriteLine("*******************************************************");
			Console.WriteLine("Ingrese un Numero");
			linea = Console.ReadLine();
			numero = int.Parse(linea);
			Console.WriteLine("*******************************************************");
			while( x < numero && sw == 0) 
			{
				residuo = numero % x;
				if(residuo == 0) 
				{
					sw = 1;
				}
				else 
				{
					x++;
				}
				
			}
			if(sw == 0) 
			{
				Console.WriteLine("El Numero Es Primo.");
				Console.WriteLine("*******************************************************");
			}
			else 
			{
				Console.WriteLine("El Numero No Es Primo.");
				Console.WriteLine("*******************************************************");
			}

			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
