using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Menu_3
	{
		Serie_Fibonacci serie_Fibonacci = new Serie_Fibonacci();
		public void Operaciones() 
		{
			string linea;
			int operacion;
			int salida = 0;

			while(salida == 0) 
			{
				Console.Clear();
				Console.WriteLine("[ MENU 3 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Serie de Fibonacci.  ");
				Console.WriteLine("  (2) Operacion  2 : ");
				Console.WriteLine("  (3) Operacion  3 : ");
				Console.WriteLine("  (4) Operacion  4 : ");
				Console.WriteLine("  (5) Operacion  5 : ");
				Console.WriteLine("  (6) Operacion  6 : ");
				Console.WriteLine("  (7) Operacion  7 : ");
				Console.WriteLine("  (8) Operacion  8 : ");
				Console.WriteLine("  (9) Operacion  9 : ");
				Console.WriteLine(" (10) Operacion 10 : ");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");

				linea = Console.ReadLine();
				operacion = int.Parse(linea);

				switch (operacion) 
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Serie de Fibonacci.");
						Console.ReadLine();
						serie_Fibonacci.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("");
						Console.ReadLine();
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Salido del Menu 3, Pulsa para volver al Menu principal.");
						Console.ReadLine();
						salida = 1;
						break;

				}
			}


		}
	}
}
