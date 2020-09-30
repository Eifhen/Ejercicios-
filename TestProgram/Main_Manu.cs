﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProgram.Menu3;
using TestProgram.Menu4;
using TestProgram.Menu5;

namespace TestProgram
{
	class Main_Manu
	{
		
		Menu_2 menu2 = new Menu_2();
		Menu menu1 = new Menu();
		Menu_3 menu3 = new Menu_3();
		Menu_4 menu4 = new Menu_4();
		Menu_5 menu5 = new Menu_5();
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
				Console.WriteLine("*   [4] -- IR Al Menu 5                                         *");
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
