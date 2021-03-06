﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Menu_4
	{

		public void Operaciones() 
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while(salida == 0) 
			{

				Console.Clear();
				Console.WriteLine("[ MENU 4 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Movimiento Caracter por Caracter Horizontal.");
				Console.WriteLine("  (2) Operacion  2 : Movimiento Caracter por Caracter Vertical");
				Console.WriteLine("  (3) Operacion  3 : Ejercicio propuesto 3 ");
				Console.WriteLine("  (4) Operacion  4 : Tabla de Multiplicar con While");
				Console.WriteLine("  (5) Operacion  5 : Tablas de Multiplicar con While");
				Console.WriteLine("  (6) Operacion  6 : Comprobar si es Numero Primo.");
				Console.WriteLine("  (7) Operacion  7 : Factores Primos de un Numero.");
				Console.WriteLine("  (8) Operacion  8 : Generar N Numeros Primos");
				Console.WriteLine("  (9) Operacion  9 : Ejercicio Propuesto 4.");
				Console.WriteLine(" (10) Operacion 10 : Verificacion de una Clave 3 Intentos.");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine(); operacion = int.Parse(linea);

				switch (operacion) 
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Movimiento Caracter por Caracter Horizontal.");
						Console.ReadLine();
						Movimiento_Caracter.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Movimiento Caracter por Caracter Vertical.");
						Console.ReadLine();
						Movimiento_Caracter_Vertical.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Ejercicio Propuesto 3");
						Console.ReadLine();
						Ejercicio_Propuesto.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Tabla de Multiplicar con While");
						Console.ReadLine();
						tabla_multiplicar_while.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Tablas de Multiplicar con While");
						Console.ReadLine();
						Tablas_Multiplicar.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Comprobar si un Numero es Primo.");
						Console.ReadLine();
						Numero_Primo.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Factores Primos de un Numero.");
						Console.ReadLine();
						Factores_Primos_de_un_Numero.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Generar N Numeros Primos");
						Console.ReadLine();
						Generar_N_Numeros_Primos.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Ejercicio Propuesto 4");
						Console.ReadLine();
						Ejercicio_Propuesto_4.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Elegido la Operacion : Verificacion de una Clave 3 Intentos.");
						Console.ReadLine();
						Verificacion_Clave.Operaciones();
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Salir del Menu 4");
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
