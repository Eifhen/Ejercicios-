using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Menu_5
	{

		public void Operaciones() 
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while (salida == 0)
			{

				Console.Clear();
				Console.WriteLine("[ MENU 5 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Generar un Numero Aleatorio entre 10 y 30.");
				Console.WriteLine("  (2) Operacion  2 : Adivina un Numero.");
				Console.WriteLine("  (3) Operacion  3 : Control de una Factura");
				Console.WriteLine("  (4) Operacion  4 : Votaciones por Sector");
				Console.WriteLine("  (5) Operacion  5 : Promedio de Sueldos");
				Console.WriteLine("  (6) Operacion  6 : Frase Invertida Con While");
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
						Console.WriteLine("Has Seleccionado la Operacion : Genera un Numero Aleatorio entre 10 y 30.");
						Console.ReadLine();
						Numero_Aleatorio.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Adivina un Numero.");
						Console.ReadLine();
						Adivina_Numero.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Control de una Factura.");
						Console.ReadLine();
						Control_Factura.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Votaciones por Sector.");
						Console.ReadLine();
						Votaciones_por_Sector.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Promedio de Sueldos");
						Console.ReadLine();
						Promedio_Sueldos.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Frase Invertida Con While");
						Console.ReadLine();
						Frase_Invertida.Operaciones();
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
						Console.WriteLine("Has Elegido Salir del Menu 5");
						Console.ReadLine();
						salida = 1;
						break;
					default:
						Console.WriteLine("Opcion Fuera de Rango.");
						Console.ReadLine();
						break;
				}

			}

		} // end method
	}
}
