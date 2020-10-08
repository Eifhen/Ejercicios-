using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Menu_7
	{

		Ejercicio_Propuesto_9 ejercicio_9 = new Ejercicio_Propuesto_9();
		public void Operaciones()
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while (salida == 0)
			{

				Console.Clear();
				Console.WriteLine("[ MENU 7 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Numero Decimal a Binario.");
				Console.WriteLine("  (2) Operacion  2 : Numero Decimal a Octal.");
				Console.WriteLine("  (3) Operacion  3 : Numero Decimal a Hexadecimal.");
				Console.WriteLine("  (4) Operacion  4 : Ejercicio Propuesto 8.");
				Console.WriteLine("  (5) Operacion  5 : Ordenamiento de un Arreglo.");
				Console.WriteLine("  (6) Operacion  6 : Ordenamiento de un Arreglo Metodo Burbuja.");
				Console.WriteLine("  (7) Operacion  7 : Búsqueda de un Elemento en un Arreglo.");
				Console.WriteLine("  (8) Operacion  8 : Búsqueda Binaria De Un Elemento En Un Arreglo.");
				Console.WriteLine("  (9) Operacion  9 : Ejercicio Propuesto 9.");
				Console.WriteLine(" (10) Operacion 10 : Tablas de Multiplicar en una Matriz de N x N. ");
				Console.WriteLine(" (11) Operacion 11 : Pruebas con Array.");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine(); operacion = int.Parse(linea);

				switch (operacion)
				{

					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Numero Decimal a Binario");
						Console.ReadLine();
						Numero_Decimal_a_Binario.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Numero Decimal a Octal.");
						Console.ReadLine();
						Numero_Decimal_a_Octal.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Numero Decimal a Hexadecimal.");
						Console.ReadLine();
						Numero_Decimal_a_Hexadecimal.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ejercicio Propuesto 8.");
						Console.ReadLine();
						Ejercicio_Propuesto_8.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ordenamiento de un Arreglo.");
						Console.ReadLine();
						Ordenamiento_Arreglo.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ordenamiento de un Arreglo Metodo Burbuja.");
						Console.ReadLine();
						Ordenamiento_Arreglo_Metodo_Burbuja.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Buscar Elementos en un Arreglo.");
						Console.ReadLine();
						Buscar_Elemento_en_Arreglo.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Busqueda Binaria de un Elemento en un Arreglo.");
						Console.ReadLine();
						Busqueda_Binaria_Elemento_Arreglo.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ejercicio Propuesto 9");
						Console.ReadLine();
						ejercicio_9.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Tablas de Multiplicar en una Matriz N x N");
						Console.ReadLine();
						Tablas_Multiplicar_Matriz.Operaciones();
						break;
					case 11:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Pruebas con Array.");
						Console.ReadLine();
						Prueba_Array.Operaciones();
						break;

					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Salir del Menu 7");
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

	} //end class
} //nameSpace
