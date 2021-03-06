﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Menu_8
	{
		public void Operaciones()
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while (salida == 0)
			{

				Console.Clear();
				Console.WriteLine("[ MENU 8 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Generar Aleatorios en una Matriz 5x5.");
				Console.WriteLine("  (2) Operacion  2 : Sumar Elementos de una Matriz NxN.");
				Console.WriteLine("  (3) Operacion  3 : Sumar Elementos de una Fila y una Columna Matriz de 5x5.");
				Console.WriteLine("  (4) Operacion  4 : Sumar Elementos de Diagonal Principal y Secundaria Matriz NxN.");
				Console.WriteLine("  (5) Operacion  5 : Forma la Letra (A) en una Matriz NxN.");
				Console.WriteLine("  (6) Operacion  6 : Ejercicio Propuesto 10.");
				Console.WriteLine("  (7) Operacion  7 : Formar la Letra (R) en una Matriz NxN.");
				Console.WriteLine("  (8) Operacion  8 : Sumar Elementos Diagonal Principal y Secundaria.");
				Console.WriteLine("  (9) Operacion  9 : Numero Mayor y Menor en una Matriz NxN.");
				Console.WriteLine(" (10) Operacion 10 : Ordenamiento de una Matriz NxN.");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine(); operacion = int.Parse(linea);

				switch (operacion)
				{
					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Generar Aleatorios en una Matriz 5x5.");
						Console.ReadLine();
						Aleatorios_Matriz.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Sumar Elementos de una Matriz N x N.");
						Console.ReadLine();
						Sumar_Elementos_Matriz.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Sumar Elementos de una Fila y una Columna Matriz de 5x5.");
						Console.ReadLine();
						Sumar_Fila_Columna.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Sumar Elementos de Diagonal Principal y Secundaria Matriz NxN.");
						Console.ReadLine();
						Sumar_Diagonales_Matriz.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Forma la Letra (A) en una Matriz NxN.");
						Console.ReadLine();
						Formar_Letra_Matriz_NxN.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ejercicio Propuesto 10.");
						Console.ReadLine();
						Ejercicio_Propuesto_10.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Formar la Letra ( R ) en una Matriz NxN");
						Console.ReadLine();
						Formar_Letra_R.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Sumar Elementos Diagonal Principal y Secundaria.");
						Console.ReadLine();
						Sumar_Elementos_Diagonales_Matriz.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Numero Mayor o Menor en una Matriz NxN.");
						Console.ReadLine();
						Numero_Mayor_o_Menor_Matriz_NxN.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ordenamiento de una Matriz NxN.");
						Console.ReadLine();
						Ordenar_Matriz.Operaciones();
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
