using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu9
{
	class Menu_9
	{
		Ejercicio_Propuesto_11 ejercicio_11 = new Ejercicio_Propuesto_11();

		public void Operaciones()
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while (salida == 0)
			{

				Console.Clear();
				Console.WriteLine("[ MENU 9 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Suma de Matrices 5x5.");
				Console.WriteLine("  (2) Operacion  2 : Multiplicacion de Matrices 4x4.");
				Console.WriteLine("  (3) Operacion  3 : Ejercicio Propuesto 11.");
				Console.WriteLine("  (4) Operacion  4 : Generacion del Triangulo de Pascal Forma 1.");
				Console.WriteLine("  (5) Operacion  5 : Generacion del Triangulo de Pascal Forma 2.");
				Console.WriteLine("  (6) Operacion  6 : ");
				Console.WriteLine("  (7) Operacion  7 : ");
				Console.WriteLine("  (8) Operacion  8 : ");
				Console.WriteLine("  (9) Operacion  9 : ");
				Console.WriteLine(" (10) Operacion 10 : ");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine(); operacion = int.Parse(linea);

				switch (operacion)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Suma de Matrices 5x5. ");
						Console.ReadLine();
						Suma_Matrices_5x5.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Multiplicacion de Matrices 4x4.");
						Console.ReadLine();
						Multiplicacion_Matrices_4x4.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Ejercicio Propuesto 11.");
						Console.ReadLine();
						ejercicio_11.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Generacion del Triangulo de Pascal Forma 1.");
						Console.ReadLine();
						Triangulo_Pascal_Forma_1.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Generacion del Triangulo de Pascal Forma 2.");
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
						Console.WriteLine("Has Elegido Salir del Menu 8.");
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
