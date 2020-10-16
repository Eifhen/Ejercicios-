using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	public static class ClasesStaticas
	{

		public static void Operacion(string parametro) 
		{

			Console.WriteLine("**************************************************************************");
			Console.WriteLine("{0} ",parametro);
			Console.WriteLine("**************************************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu");
			Console.ReadLine();
		}
	}
}
