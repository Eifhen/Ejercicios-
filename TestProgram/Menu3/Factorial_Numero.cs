using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Factorial_Numero
	{

		public static void Operaciones() 
		{

			byte numero;
			string linea;
			long result = 1;
			Console.Clear();
			Console.WriteLine("**********************************************");
			Console.WriteLine(" --------- Factorial de un Numero. -----------");
			Console.WriteLine("**********************************************");
			Console.WriteLine("Digite un Numero."); linea = Console.ReadLine();
			Console.WriteLine("**********************************************");
			numero = byte.Parse(linea);
			for(int k = 1; k <= numero; k++) 
			{
				result = result * k;
			}
			Console.WriteLine("El Factorial del numero {0} es : {1} ", numero, result);
			Console.WriteLine("**********************************************");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();
		}
	} // End Class
} // End NameSpace
