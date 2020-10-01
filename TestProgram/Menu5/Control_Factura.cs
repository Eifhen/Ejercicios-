using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Control_Factura
	{

		public static void Operaciones() 
		{

			string producto;
			int cantidad = 0;
			int fi = 0;
			double precio = 0;
			double total = 0;
			double paga = 0;
			char op;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------------- Control de una Factura -----------------");
			Console.WriteLine("********************************************************");

			fi = 16;
			Console.SetCursorPosition(3, 9);
			Console.WriteLine("********************************************************");
			Console.SetCursorPosition(5, 10);
			Console.WriteLine("Producto | Cantidad | Precio | Total");
			Console.SetCursorPosition(3, 11);
			Console.WriteLine("********************************************************");

			do 
			{
				Console.SetCursorPosition(5, fi);
				producto = Console.ReadLine();

				Console.SetCursorPosition(17, fi);
				linea = Console.ReadLine();
				cantidad = int.Parse(linea);

				Console.SetCursorPosition(27, fi);
				linea = Console.ReadLine();
				precio = int.Parse(linea);

				total = cantidad * precio;
				Console.SetCursorPosition(33, fi);
				Console.Write("Total : {0}", total);

				paga = paga + total;
				fi = fi + 1;

				Console.SetCursorPosition(30, 23);
				Console.WriteLine("Escribe otro Producto S/N");
				Console.SetCursorPosition(30, 25);
				linea = Console.ReadLine();
				op = char.Parse(linea.ToUpper());

			} while (op.ToString().Contains("S"));

			Console.WriteLine("********************************************************");
			Console.WriteLine("Total a Pagar {0}",paga);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();
		}
	}
}
