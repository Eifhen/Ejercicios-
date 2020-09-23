using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Dia_Semana
	{
		public void Operaciones() 
		{
			string linea;
			byte numero;
			Console.Clear();
			Console.WriteLine("*********************************************************");
			Console.WriteLine("Dias de la Semana");
			Console.WriteLine("*********************************************************");
			Console.WriteLine("Elige un numero del 1 al 7");

			linea = Console.ReadLine();
			numero = byte.Parse(linea);

			switch (numero) 
			{
				case 1:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Domingo");
					Console.ReadLine();
					break;
				case 2:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Lunes");
					Console.ReadLine();
					break;
				case 3:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Martes");
					Console.ReadLine();
					break;
				case 4:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Miercoles");
					Console.ReadLine();
					break;
				case 5:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Jueves");
					Console.ReadLine();
					break;
				case 6:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Viernes");
					Console.ReadLine();
					break;
				case 7:
					Console.WriteLine("Has elegido el numero : {0}", numero);
					Console.WriteLine("El dia correspondiente a ese numero es el Sabado");
					Console.ReadLine();
					break;
				default:
					Console.WriteLine();
					Console.WriteLine("El numero que ingreso esta fuera de rango");
					Console.ReadLine();
					break;
			}
			Console.ReadKey();

		}
	}
}
