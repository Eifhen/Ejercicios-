using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Tablas_Multiplicar
	{

		public void Operaciones() 
		{
			string linea;
			int numero, resultado, i,T;
			Console.Clear();
			Console.WriteLine("****************************************************");
			Console.WriteLine("---------------TABLAS DE MULTIPLICAR----------------");
			Console.WriteLine("****************************************************");

			Console.WriteLine("Cuantas Tablas?");
			Console.WriteLine("****************************************************");
			linea = Console.ReadLine();
			numero = int.Parse(linea);
			Console.WriteLine("****************************************************");
			Console.WriteLine("*");
			for( T = 1; T <= numero; T++) 
			{
				for(i = 10; i >= 1; i--) 
				{
					resultado = T * i;
					Console.WriteLine("*  {0} * {1} = {2} ", i, T, resultado);
				}
				Console.WriteLine("");
				Console.WriteLine("****************************************************");
			}
			
			Console.WriteLine(" [ Pulsa para volver al menu ]");
			Console.WriteLine("****************************************************");
			Console.ReadLine();



		}
	}
}
