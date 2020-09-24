using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProgram.Menu2;

namespace TestProgram
{
	class Menu_2
	{

		Dia_Semana dia_Semana = new Dia_Semana();
		Estado_Civil estado_Civil = new Estado_Civil();
		Calificacion calificacion = new Calificacion();
		Ejercicio_Propuesto3 ejercicioPropuesto = new Ejercicio_Propuesto3();
		Tabla_Multiplicar tabla_Multiplicar = new Tabla_Multiplicar();
		Hospital presupuesto_Hospital = new Hospital();
		Suma_Numeros_Pares_Impares numeros_Pares_Impares = new Suma_Numeros_Pares_Impares();
		public void ini() 
		{
			int salir = 0;
			int tipo_operacion;
			string linea;

			while (salir == 0)
			{
				Console.Clear();
				Console.WriteLine("[ MENU 2 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Dias de la Semana.");
				Console.WriteLine("  (2) Operacion  2 : Estado Civil.");
				Console.WriteLine("  (3) Operacion  3 : Calificacion.");
				Console.WriteLine("  (4) Operacion  4 : Ejercicio Propuesto.");
				Console.WriteLine("  (5) Operacion  5 : Tabla de Multiplicar.");
				Console.WriteLine("  (6) Operacion  6 : Presupuesto Areas Hospital.");
				Console.WriteLine("  (7) Operacion  7 : Suma Numero Par e Impar.");
				Console.WriteLine("  (8) Operacion  8 : Tablas de Multiplicar.");
				Console.WriteLine("  (9) Operacion  9 : ");
				Console.WriteLine(" (10) Operacion 10 : ");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual. ");
				Console.WriteLine("**************************************************************************");

				linea = Console.ReadLine();
				tipo_operacion = int.Parse(linea);

				switch (tipo_operacion) 
				{
					case 1:
						Console.WriteLine("Has Elegido la operacion : Dias de la Semana.");
						Console.ReadLine();
						dia_Semana.Operaciones();
						break;
					case 2:
						Console.WriteLine("Has Elegido la operacion : Estado Civil.");
						Console.ReadLine();
						estado_Civil.Operaciones();
						break;
					case 3:
						Console.WriteLine("Has Elegido la operacion : Calificacion.");
						Console.ReadLine();
						calificacion.Operaciones();
						break;
					case 4:
						Console.WriteLine("Has Elegido la operacion : Ejercicio Propuesto.");
						Console.ReadLine();
						ejercicioPropuesto.Operaciones();
						break;
					case 5:
						Console.WriteLine("Has Elegido la operacion : Tabla Multiplicar.");
						Console.ReadLine();
						tabla_Multiplicar.Operaciones();
						break;
					case 6:
						Console.WriteLine("Has Elegido la operacion : Presupuesto Areas Hospital.");
						Console.ReadLine();
						presupuesto_Hospital.Operaciones();
						break;
					case 7:
						Console.WriteLine("Has Elegido la operacion : Suma Numeros Pares e Impares.");
						Console.ReadLine();
						numeros_Pares_Impares.Operaciones();
						break;
					case 8:
						break;
					case 9:
						break;
					case 10:
						break;
					case 11:
						break;
					case 99:
						Console.Clear();
						Console.WriteLine("Has Elegido Volver al Menu Anterior");
						Console.ReadLine();
						salir = 1;
						break;
					default:
						Console.WriteLine();
						Console.WriteLine("El numero que ingreso esta fuera de rango");
						Console.ReadLine();
						break;
				}

			}


		} // End Method

	} // Class End
}
