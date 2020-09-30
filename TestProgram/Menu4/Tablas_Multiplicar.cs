using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Tablas_Multiplicar
	{


		public static void Operaciones()
		{

			string linea;
			int numero_de_tablas;
			int t = 1;
			int i, resultado;
			Console.Clear();
			Console.WriteLine("*******************************************************");
			Console.WriteLine(" -------- Tablas de Multiplicar usando While ----------");
			Console.WriteLine("*******************************************************");
		
			Console.WriteLine("Cuantas Tablas quieres mostrar?");
			linea = Console.ReadLine();
			numero_de_tablas = int.Parse(linea);
			Console.WriteLine("*******************************************************");
			while ( t <= numero_de_tablas) 
			{
				i = 10;
				while( i > 1) 
				{
					resultado = t * i;
					Console.WriteLine(" {0} x {1} = {2} ", t,i,resultado);
					i--;
				}
				Console.WriteLine("*******************************************************");
			
				t++;
			}
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.WriteLine("*******************************************************");
			Console.ReadLine();
		}
	}
}
