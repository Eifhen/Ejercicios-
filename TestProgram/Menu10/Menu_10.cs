using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Menu_10
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
				Console.WriteLine("  (1) Operacion  1 : Clases Staticas.                                       ");
				Console.WriteLine("  (2) Operacion  2 : Cubo de un Numero.                                     ");
				Console.WriteLine("  (3) Operacion  3 : Mayor de 3 Numeros.                                    ");
				Console.WriteLine("  (4) Operacion  4 : Valor Absoluto de un Numero.                           ");
				Console.WriteLine("  (5) Operacion  5 : Factorial de un Numero.                                ");
				Console.WriteLine("  (6) Operacion  6 : Invertir una Frase.                                    ");
				Console.WriteLine("  (7) Operacion  7 : Comprobar si un Numero es Multiplo de Otro.            ");
				Console.WriteLine("  (8) Operacion  8 : Numero a Que Dia de la Semana Corresponde.             ");
				Console.WriteLine("  (9) Operacion  9 : Numero Comprobar si es Primo.                          ");
				Console.WriteLine(" (10) Operacion 10 : Menor en un Arreglo.                                   ");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine();
				opcion = int.Parse(linea);

				switch (opcion)
				{
					case 1:
						string cadena = "Haciendo Pruebas Con Clases Staticas";
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Clases Staticas");
						Console.ReadLine();
						ClasesStaticas.Operacion(cadena);
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Cubo de un Numero.");
						Console.ReadLine();
						Cubo_Numero.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Mayor de 3 Numeros.");
						Console.ReadLine();
						Mayor_3_Numeros.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Valor Absoluto de un Numero.");
						Console.ReadLine();
						Valor_Absoluto.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Factorial de un Numero.");
						Console.ReadLine();
						Factorial_Numero.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Invertir una Frase.");
						Console.ReadLine();
						Invertir_Frase.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Comprobar si un Numero es Multiplo de Otro. ");
						Console.ReadLine();
						Comprobar_Multiplo.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Numero a Que Dia de la Semana Corresponde. ");
						Console.ReadLine();
						Numero_Dia_Semana.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Comprobar si un Numero es Primo.");
						Console.ReadLine();
						Comprobar_Numero_Primo.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Menor en un Arreglo. ");
						Console.ReadLine();
						Menor_en_Arreglo.Operaciones();
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
