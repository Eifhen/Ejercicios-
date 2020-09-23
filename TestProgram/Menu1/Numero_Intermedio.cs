using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Numero_Intermedio
	{
		public void Operaciones()
		{
			int numero1, numero2, numero3;
			string linea;
			Console.WriteLine("****************************************");
			Console.WriteLine("Primer Numero");
			Console.WriteLine("****************************************");
			linea = Console.ReadLine();
			numero1 = int.Parse(linea);

			Console.WriteLine("*****************************************");
			Console.WriteLine("Segundo Numero");
			Console.WriteLine("****************************************");
			linea = Console.ReadLine();
			numero2 = int.Parse(linea);

			Console.WriteLine("*****************************************");
			Console.WriteLine("Tercer Numero");
			Console.WriteLine("****************************************");
			linea = Console.ReadLine();
			numero3 = int.Parse(linea);

			Console.WriteLine("");
			Console.WriteLine("****************************************");
			int b = Math.Max(numero1, numero2); // quien es mayor de numero 1 o numero 2
			int c = Math.Max(numero2, numero3); // quien es mayor de numero 2 y numero 3
			int d = Math.Max(numero3, numero1); // quien es mayor de numero 3 y numero 1

			if (b == numero1)
				if (b < numero3)
					Console.WriteLine("El Numero Intermedio es {0}", b);
				else
					if(c == numero2)
						Console.WriteLine("El Numero Intermedio es {0}", numero2); 
					else
						Console.WriteLine("El Numero Intermedio es {0}", numero3);
			else
				if(c == numero3)
						Console.WriteLine("El Numero Intermedio es {0}", numero2);
				else
					if(d == numero1)
						Console.WriteLine("El Numero Intermedio es {0}", numero1);
					else
						Console.WriteLine("El Numero Intermedio es {0}", numero3);

			Console.WriteLine("****************************************");
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();

		}

		/* [Explicacion del IF:] 
		 * utilice IF's sin llaves, la variable [b] retorna
		*  el numero mayor entre "numero1" y "numero2", la variable [c] retorna el numero mayor entre
		*  "numero2" y "numero3" y la variable [d] retorna el numero mayor entre "numero3" y "numero1"
		*  
		*  Si el valor devuelto por la  variable [b] es igual al valor almacenado en la variable "numero1"
		*  entonces preguntaremos si [b] es menor a la variable "numero3" si es menor, entonces el numero
		*  intermedio sera la variable "numero2", de lo contrario el numero intermedio sera la variable "numero3"
		*  
		*  Pero si el valor devuelto por la variable [b] no es igual al valor almacenado en la variable "numero1",
		*  esto significara que el valor de la variable [b] es igual al valor almacenado en la variable "numero2".
		*  
		*  Por lo tanto si este es el caso, preguntaremos si el valor devuelto por la variable [c] es igual a
		*  "numero3" si es el caso entonces el valor intermedio sera "numero2"
		*  de lo contrario preguntaremos si el valor devuelto por la variable [d] es igual a "numero1"
		*  si es el caso el valor intermedio sera "numero1".
		*  
		*  pero si el valor devuelto por la variable [d] no es igual a "numero1" entonces el 
		*  valor intermedio sera "numero3".
		*/
	}
}
