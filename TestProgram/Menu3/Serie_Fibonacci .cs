using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Serie_Fibonacci
	{

		public void Operaciones() 
		{
			string linea;
			int A = 0;
			int B = 1;
			int C = 0;
			int repeticiones;

			Console.Clear();
			Console.WriteLine("****************************************************************");
			Console.WriteLine("----------------------- Serie de Fibonacci ---------------------");
			Console.WriteLine("****************************************************************");
			Console.WriteLine("Ingresa un numero de repeticiones para desarrollar la serie.");
			Console.WriteLine("****************************************************************");
			Console.WriteLine();
			linea = Console.ReadLine();
			repeticiones = int.Parse(linea);
			Console.WriteLine();
			Console.WriteLine("***************************************************************");
			for (int i =0; i < repeticiones; i++) 
			{
				C = A + B;
				Console.Write(" {0}, ", C); 
				A = B;
				B = C;
			}
			Console.WriteLine();
			Console.WriteLine("***************************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();

		}
	}
}
