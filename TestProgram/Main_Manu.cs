using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProgram.Menu3;
using TestProgram.Menu4;
using TestProgram.Menu5;
using TestProgram.Menu6;
using TestProgram.Menu7;
using TestProgram.Menu8;
using TestProgram.Menu9;

namespace TestProgram
{
	class Main_Manu
	{
		
		Menu_2 menu2 = new Menu_2();
		Menu menu1 = new Menu();
		Menu_3 menu3 = new Menu_3();
		Menu_4 menu4 = new Menu_4();
		Menu_5 menu5 = new Menu_5();
		Menu_6 menu6 = new Menu_6();
		Menu_7 menu7 = new Menu_7();
		Menu_8 menu8 = new Menu_8();
		Menu_9 menu9 = new Menu_9();

		public void Operaciones() 
		{
			string linea;
			int opcion = 0;
			int salida = 0;
			while(salida == 0) 
			{
				Console.Clear();
				Console.WriteLine("*****************************************************************");
				Console.WriteLine("*                     [MAIN MENU]                               *");
				Console.WriteLine("*****************************************************************");
				Console.WriteLine("*                                                               *");
				Console.WriteLine("*   [1] -- IR Al MENU 1                                         *");
				Console.WriteLine("*   [2] -- IR Al MENU 2                                         *");
				Console.WriteLine("*   [3] -- IR AL MENU 3                                         *");
				Console.WriteLine("*   [4] -- IR Al Menu 4                                         *");
				Console.WriteLine("*   [5] -- IR Al Menu 5                                         *");
				Console.WriteLine("*   [6] -- IR Al Menu 6                                         *");
				Console.WriteLine("*   [7] -- IR Al Menu 7                                         *");
				Console.WriteLine("*   [8] -- IR Al Menu 8                                         *");
				Console.WriteLine("*   [9] -- IR Al Menu 9                                         *");
				Console.WriteLine("*  [10] -- IR Al Menu 10                                        *");
				Console.WriteLine("*                                                               *");
				Console.WriteLine("*****************************************************************");
				Console.WriteLine("*  [99] -- SALIR                                                *");
				Console.WriteLine("*****************************************************************");
				Console.WriteLine("* -- Selecciona una Opcion --                                   *");
				Console.WriteLine("*****************************************************************");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);

				switch (opcion) 
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 1");
						Console.ReadLine();
						menu1.Ini();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 2");
						Console.ReadLine();
						menu2.ini();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 3");
						Console.ReadLine();
						menu3.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 4");
						Console.ReadLine();
						menu4.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 5");
						Console.ReadLine();
						menu5.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 6");
						Console.ReadLine();
						menu6.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 7");
						Console.ReadLine();
						menu7.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 8");
						Console.ReadLine();
						menu8.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 9");
						Console.ReadLine();
						menu9.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado el MENU 10");
						Console.ReadLine();
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Salir, la aplicacion va a cerrarse");
						Console.ReadLine();
						salida = 1;
						break;
					default:
						Console.WriteLine("Opcion Fuera de Rango.");
						Console.ReadLine();
						break;
				}
				Console.ReadKey();
			}
		}
	}
}
