using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Movimiento_Frase
	{

		public static void Operaciones() 
		{

			string frase;
			Console.Clear();
			Console.WriteLine("**************************************************");
			Console.WriteLine(" ------------ Movimiento de una Frase ------------");
			Console.WriteLine("**************************************************");
			Console.WriteLine("Su Nombre es : ");  frase = Console.ReadLine();
			for(int k = 0; k <= 70; k++) 
			{
				Console.SetCursorPosition(k,12);
				Console.Write(" {0}",frase);

				// realizamos pausa;
				System.Threading.Thread.Sleep(100);
			}
			Console.WriteLine("");
			Console.WriteLine("Pulsa una tecla para volver al menu.");
			Console.ReadLine();
		}
	}
}
