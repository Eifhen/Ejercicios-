using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Menu
	{
		Operacion1 FirstTest = new Operacion1();
		Operacion2 SecondTest = new Operacion2();
		Operacion3 ThirdTest = new Operacion3();
		Operacion4 FourthTest = new Operacion4();
		FormatoSalida formatoSalida = new FormatoSalida();
		MathTest mathTest = new MathTest();
		Numero_Intermedio numero_intermedio = new Numero_Intermedio();
		Tarifa_Telefonica tarifa_telefonica = new Tarifa_Telefonica();
		Triangulos triangulos = new Triangulos();
		EjercicioPropuesto2 ejercicioPropuesto2 = new EjercicioPropuesto2();
		public void Ini() 
		{
			int salir = 0;
			int Tipo_Operacion = 0;
			while (salir == 0)
			{
				Console.Clear();
				Console.WriteLine("[ MENU 1 ]");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  [ Selecciona la Operacion que desea realizar ] ");
				Console.WriteLine("****************************************************************************");
				Console.WriteLine("  (1) Operacion  1 : Invertir Numero de Dos Cifras.");
				Console.WriteLine("  (2) Operacion  2 : Invertir Numero de Tres Cifras.");
				Console.WriteLine("  (3) Operacion  3 : Operaciones Basicas.");
				Console.WriteLine("  (4) Operacion  4 : Compra en restaurant.");
				Console.WriteLine("  (5) Operacion  5 : Operaciones con la libreria Math.");
				Console.WriteLine("  (6) Operacion  6 : Formatos de Salida.");
				Console.WriteLine("  (7) Operacion  7 : Numero Intermedio.");
				Console.WriteLine("  (8) Operacion  8 : Tarifa Telefonica.");
				Console.WriteLine("  (9) Operacion  9 : Tipos de Triangulos");
				Console.WriteLine(" (10) Operacion 10 : Ejercicio Propuesto 2");
				Console.WriteLine("");
				Console.WriteLine("**************************************************************************");
				Console.WriteLine(" (99) Operacion : Salir del Menu Actual");
				Console.WriteLine("**************************************************************************");

				string tipo = Console.ReadLine();
				Tipo_Operacion = int.Parse(tipo);

				switch (Tipo_Operacion)
				{
					case 1:
						Console.WriteLine("Seleccionaste la primera Operacion");
						Console.ReadLine();
						Console.Clear();
						FirstTest.Operacion();
						break;

					case 2:
						Console.WriteLine("Seleccionaste la segunda Operacion");
						Console.ReadLine();
						Console.Clear();
						SecondTest.Operacion();
						break;

					case 3:
						Console.WriteLine("Seleccionaste la tercera Operacion");
						Console.ReadLine();
						Console.Clear();
						ThirdTest.Operacion();
						break;

					case 4:
						Console.WriteLine("Seleccionaste la cuarta Operacion");
						Console.ReadLine();
						Console.Clear();
						FourthTest.Operacion();
						break;
					case 5:
						Console.WriteLine("Seleccionaste la quinta Operacion");
						Console.ReadLine();
						Console.Clear();
						mathTest.Operacion();
						break;
					case 6:
						Console.WriteLine("Seleccionaste la Sexta Operacion");
						Console.ReadLine();
						Console.Clear();
						formatoSalida.Operacion();
						break;
					case 7:
						Console.WriteLine("Seleccionaste la Septima Operacion");
						Console.ReadLine();
						Console.Clear();
						numero_intermedio.Operaciones();
						break;
					case 8:
						Console.WriteLine("Seleccionaste la Octava Operacion");
						Console.ReadLine();
						Console.Clear();
						tarifa_telefonica.Operaciones();
						break;
					case 9:
						Console.WriteLine("Seleccionaste la Novena Operacion");
						Console.ReadLine();
						Console.Clear();
						triangulos.Operaciones();

						break;

					case 10:
						Console.WriteLine("Seleccionaste la Decima Operacion");
						Console.ReadLine();
						Console.Clear();
						ejercicioPropuesto2.Operaciones();
						break;

					case 99:
						Console.Clear();
						Console.WriteLine("****************************************");
						Console.WriteLine("Seleccionaste la Opcion de Salir");
						Console.WriteLine("****************************************");
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
		}
	}
}
