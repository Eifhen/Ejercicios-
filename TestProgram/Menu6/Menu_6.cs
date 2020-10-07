using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Menu_6
	{
		public void Operaciones()
		{
			string linea;
			int operacion = 0;
			int salida = 0;
			while (salida == 0)
			{

				Console.Clear();
				Console.WriteLine("[ MENU 6 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Pasar una Frase a un Arreglo.");
				Console.WriteLine("  (2) Operacion  2 : Suma de Elementos Pares e Impares en un Arreglo.");
				Console.WriteLine("  (3) Operacion  3 : Mayor o Menor de un Arreglo de N Elementos.");
				Console.WriteLine("  (4) Operacion  4 : Obtener el digito verificador de la Cedula.");
				Console.WriteLine("  (5) Operacion  5 : Insertar un Elemento en un Arreglo.");
				Console.WriteLine("  (6) Operacion  6 : Eliminar un Elemento en un Arreglo.");
				Console.WriteLine("  (7) Operacion  7 : Suma de Dos Arreglos de 5 Elementos.");
				Console.WriteLine("  (8) Operacion  8 : Suma de Dos Arreglos de 5 Elementos Intercalado.");
				Console.WriteLine("  (9) Operacion  9 : Ejercicio Propuesto 6.");
				Console.WriteLine(" (10) Operacion 10 : Ejercicio Propuesto 7.");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");
				linea = Console.ReadLine(); operacion = int.Parse(linea);

				switch (operacion) 
				{

					case 1:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Pasar una Frase a un Arreglo.");
						Console.ReadLine();
						Frase_Arreglo.Operaciones();
						break;
					case 2:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Suma de Elementos Pares e Impares en un Arreglo ");
						Console.ReadLine();
						Suma_de_Elementos_Arreglo.Operaciones();
						break;
					case 3:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Mayor o Menor de un Arreglo de N Elementos");
						Console.ReadLine();
						Mayor_Menor_Arreglo_N_Numeros.Operaciones();
						break;
					case 4:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Obtener el Digito verificador de la Cedula.");
						Console.ReadLine();
						Obtener_Digito_Cedula.Operaciones();
						break;
					case 5:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Insertar un Elemento en un Arreglo.");
						Console.ReadLine();
						Insertar_Elemento_Arreglo.Operacioens();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Eliminar Elementos en un Arreglo.");
						Console.ReadLine();
						Eliminar_Elemento_Arreglo.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Suma de Dos Arreglos de 5 Elementos.");
						Console.ReadLine();
						Suma_Arreglos.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion :  Suma de Dos Arreglos de 5 Elementos Intercalado.");
						Console.ReadLine();
						Suma_Arreglos_Intercalado.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ejercicio Propuesto 6.");
						Console.ReadLine();
						Ejercicio_Propuesto_6.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Operacion : Ejercicio Propuesto 7.");
						Console.ReadLine();
						Ejercicio_Propuesto_7.Operaciones();
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Salir del Menu 6");
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

