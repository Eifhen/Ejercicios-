using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Verificacion_Clave
	{
		public static void Operaciones() 
		{
			// Usando  Do While

			string clave;
			byte k = 0;
			byte sw = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------- Verificacion Clave 3 Intentos -------------");
			Console.WriteLine("********************************************************");

			do 
			{
			
				Console.WriteLine("Digite Una Clave");
				Console.WriteLine("********************************************************");
				clave = Console.ReadLine();

				if (clave.ToUpper() == "GABRIEL") sw = 1;
				else k++;

			} while ((k < 3) && (sw == 0));

			if (sw == 1) Console.WriteLine("Bienvenido {0} ", clave);
			else Console.WriteLine("Oportunidades Terminadas");

			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu");
			Console.WriteLine("********************************************************");
			Console.ReadLine();
		}
	}
}
