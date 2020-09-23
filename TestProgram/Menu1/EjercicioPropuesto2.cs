using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class EjercicioPropuesto2
	{
		public void Operaciones() 
		{	
			string linea, nombre, lowName;
			Console.WriteLine("*****************************************************************************");
			Console.WriteLine("Hola, Por favor escribe tu nombre para poder saber si te conozco o no.");
			Console.WriteLine("****************************************************************************");
			linea = Console.ReadLine();
			lowName= linea.ToLower();
			nombre = linea;
			Console.WriteLine("");
			Console.WriteLine("Tu nombre es {0} ? ",nombre);
			if (lowName == "david")
				Console.WriteLine("Hola {0} claro que si te reconoci!",nombre);
			else
				Console.WriteLine("Lo siento pero no te conozco");

			Console.WriteLine("****************************************************************************");
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();


		}
	}
}
