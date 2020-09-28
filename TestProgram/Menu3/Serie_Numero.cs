using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Serie_Numero
	{
		public static void Operaciones() 
		{
			byte numero, k, F;
			long factorial;
			double resultado = 0;
			string linea;
			Console.Clear();
			Console.WriteLine("***************************************************");
			Console.WriteLine(" ------------- Serie de un Numero. ----------------");
			Console.WriteLine("***************************************************");
			Console.WriteLine("Digita un Numero."); linea = Console.ReadLine();
			Console.WriteLine("***************************************************");
			numero = byte.Parse(linea);
			for( k = 1; k <= numero; k++) 
			{
				factorial = 1;
				for(F = 1; F <= k; F++) 
				{
					factorial = factorial * F;
				}
				resultado = resultado + (k / factorial);
			}
			Console.WriteLine("El Resultado de la Serie es : {0} ", resultado);
			Console.WriteLine("***************************************************");
			Console.WriteLine("Pulsa para volver al menu."); 
			Console.ReadLine();
		}
	}
}
