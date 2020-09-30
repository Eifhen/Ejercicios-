using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Factores_Primos_de_un_Numero
	{



		public static void Operaciones() 
		{

			int numero, residuo;
			int k = 2;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------- Factores Primos de un Numero --------------");
			Console.WriteLine("********************************************************");

			Console.WriteLine("Ingresa un Numero : ");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			numero = int.Parse(linea);
			Console.WriteLine("Los Factores Primos de {0} son : ", numero);
			Console.WriteLine("********************************************************");
			while (numero != 1) 
			{
				residuo = numero % k;
				if( residuo == 0) 
				{
					Console.WriteLine();
					Console.WriteLine(k);
					numero = numero / k;
				}
				else 
				{
					k++;
				}
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa una tecla para volver al menu.");
			Console.WriteLine("********************************************************");
			Console.ReadLine();
		} 
	} // End Class
}
