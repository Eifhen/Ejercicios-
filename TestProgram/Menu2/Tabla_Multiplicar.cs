using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Tabla_Multiplicar
	{

		public void Operaciones() 
		{
			string linea;
			byte numero,i;
			int resultado;

			Console.Clear();
			Console.WriteLine("************************************************************");
			Console.WriteLine("* -----------------Tabla de Multiplicar--------------------*");
			Console.WriteLine("************************************************************");
			Console.WriteLine("Ingresa un numero y te dare su tabla de multiplicar");
			Console.WriteLine("************************************************************");
			linea = Console.ReadLine();
			numero = byte.Parse(linea);

			for(i = 1; i <= 12; i++) 
			{
				resultado = i * numero;
				Console.WriteLine("{0} * {1} = {2}",numero,i,resultado);
			}
			Console.WriteLine("************************************************************");
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();

		}
	}
}
