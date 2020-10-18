using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProgram.Menu12___Ejercicios_No_Resueltos;

namespace TestProgram.Menu12
{
	class Menu_12
	{
		public static void Operaciones()
		{
			string linea;
			int opcion = 0;
			int salida = 0;
			while (salida == 0)
			{
				Console.Clear();
				Console.WriteLine("[ MENU 12 : Ejercicios No Resueltos ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 :    Ejercicio 1.                                        ");
				Console.WriteLine("  (2) Operacion  2 :    Ejercicio 2.                                        ");
				Console.WriteLine("  (3) Operacion  3 :    Ejercicio 3.                                        ");
				Console.WriteLine("  (4) Operacion  4 :    Ejercicio 4.                                        ");
				Console.WriteLine("  (5) Operacion  5 :                                                        ");
				Console.WriteLine("  (6) Operacion  6 :                                                        ");
				Console.WriteLine("  (7) Operacion  7 :                                                        ");
				Console.WriteLine("  (8) Operacion  8 :                                                        ");
				Console.WriteLine("  (9) Operacion  9 :                                                        ");
				Console.WriteLine(" (10) Operacion 10 :                                                        ");
				Console.WriteLine("																			   ");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);

				switch (opcion)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio 1.");
						Console.ReadLine();
						Ejercicio_1.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio 2.");
						Console.ReadLine();
						Ejercicio_2.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio 3.");
						Console.ReadLine();
						Ejercicio_3.Operaciones();
						break;

					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio 4.");
						Console.ReadLine();
						Ejercicio_4.Operaciones();	
						break;

					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;

					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;

					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Salir del Menu 12.");
						Console.ReadLine();
						salida = 1;
						break;
					default:
						Console.WriteLine("Opcion Fuera de Rango.");
						Console.ReadLine();
						break;
				}
			}
		}
	} // End Class
}
