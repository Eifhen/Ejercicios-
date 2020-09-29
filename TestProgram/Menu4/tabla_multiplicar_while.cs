using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class tabla_multiplicar_while
	{
		public static void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("******************************************************");
			Console.WriteLine(" ---------- Tabla de Multiplicar Usando WHILE --------");
			Console.WriteLine("******************************************************");
			int numero, resultado, I;
			string linea;
			Console.WriteLine("Digite un Numero"); 
			linea = Console.ReadLine();
			Console.WriteLine("******************************************************");
			numero = int.Parse(linea);
			I = 1;
			while(I <= 12) 
			{
				resultado = numero * I;
				Console.WriteLine("{0} * {1} = {2} ",numero,I, resultado);
				I++;
			}
			Console.WriteLine("******************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
