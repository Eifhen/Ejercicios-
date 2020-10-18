using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu11
{
	class Menu_11
	{
		public static void Operaciones()
		{
			string linea;
			int opcion = 0;
			int salida = 0;
			while (salida == 0)
			{
				Console.Clear();
				Console.WriteLine("[ MENU 10 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Transformar Numero Decimal a Binario.                  ");
				Console.WriteLine("  (2) Operacion  2 : Ejercicio Propuesto 12.                                ");
				Console.WriteLine("  (3) Operacion  3 : Obtener el Dígito Verificador para la Cédula.          ");
				Console.WriteLine("  (4) Operacion  4 :                                                        ");
				Console.WriteLine("  (5) Operacion  5 :                                                        ");
				Console.WriteLine("  (6) Operacion  6 :                                                        ");
				Console.WriteLine("  (7) Operacion  7 :                                                        ");
				Console.WriteLine("  (8) Operacion  8 :                                                        ");
				Console.WriteLine("  (9) Operacion  9 :                                                        ");
				Console.WriteLine(" (10) Operacion 10 :                                                        ");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);

				switch (opcion)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Transformar Numero Decimal a Binario.");
						Console.ReadLine();
						Trasformar_Decimal_a_Binario.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio Propuesto 12");
						Console.ReadLine();
						Ejercicio_Propuesto_12.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Obtener el Dígito Verificador para la Cédula.");
						Console.ReadLine();
						Digito_Cedula.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : ");
						Console.ReadLine();
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
						Console.WriteLine("Has Elegido Salir del Menu 10.");
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
	}
}
