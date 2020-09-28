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
		Numeros_Aleatorios_y_ASCII numeros_Aleatorios_Y_ASCII = new Numeros_Aleatorios_y_ASCII();
		Funciones_Cadena funciones_Cadena = new Funciones_Cadena();
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
				Console.WriteLine("  (2) Operacion  2 : Numeros Aleatorios y Caracteres ASCII. ");
				Console.WriteLine("  (3) Operacion  3 : Funciones de Cadena.");
				Console.WriteLine("  (4) Operacion  4 : Simulacion de un Relog Digital.");
				Console.WriteLine("  (5) Operacion  5 : Cantidad de Vocales Cerradas. ");
				Console.WriteLine("  (6) Operacion  6 : Estadistica por Vocal.");
				Console.WriteLine("  (7) Operacion  7 : Factorial de un Numero.");
				Console.WriteLine("  (8) Operacion  8 : Serie de un Numero.");
				Console.WriteLine("  (9) Operacion  9 : Sucesion de N Cuadrados.");
				Console.WriteLine(" (10) Operacion 10 : Movimiento de una Frase");
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
						Console.WriteLine("Has Seleccionado la Opcion : Numeros Aleatorios y Caracteres ASCII.");
						Console.ReadLine();
						numeros_Aleatorios_Y_ASCII.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Funciones de Cadena.");
						Console.ReadLine();
						funciones_Cadena.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Simulacion de un Relog Digital.");
						Console.ReadLine();
						Simulacion_Relog.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Cantidad Vocales Cerradas.");
						Console.ReadLine();
						Cantidad_Vocales_Cerradas.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Estadistica por Vocal.");
						Console.ReadLine();
						Estadistica_por_Vocal.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Factorial de un Numero.");
						Console.ReadLine();
						Factorial_Numero.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Serie de un Numero.");
						Console.ReadLine();
						Serie_Numero.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Sucesion de N Cuadrados ");
						Console.ReadLine();
						Sucesion_N_Cuadrados.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Movimiento de una Frase.");
						Console.ReadLine();
						Movimiento_Frase.Operaciones();
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
