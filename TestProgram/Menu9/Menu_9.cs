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
				Console.WriteLine("  (6) Operacion  6 : Matriz Transpuesta NxN.");
				Console.WriteLine("  (7) Operacion  7 : Mayores de Cada Fila de una Matriz NxN en un Vector.");
				Console.WriteLine("  (8) Operacion  8 : Menores de Cada Columna de una Matriz NxN en un Vector.");
				Console.WriteLine("  (9) Operacion  9 : Promedio de Cada Columna de una Matriz de NxN en un Vector.");
				Console.WriteLine(" (10) Operacion 10 : Votaciones: Suma de Cada Columna Representa un Candidato,");
				Console.WriteLine("                     Obtener al Candidato Ganador.  ");
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
						Triangulo_Pascal_Forma_2.Operaciones();
						break;
					case 6:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Matriz Transpuesta NxN.");
						Console.ReadLine();
						Matriz_Transpuesta_NxN.Operaciones();
						break;
					case 7:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Mayores de Cada Fila de una Matriz NxN en un Vector.");
						Console.ReadLine();
						Mayores_de_Cada_Fila_Matriz_a_Vector.Operaciones();
						break;
					case 8:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Menores de Cada Columna de una Matriz NxN en un Vector.");
						Console.ReadLine();
						Menores_de_Cada_Columna_Matriz_a_Vector.Operaciones();
						break;
					case 9:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Promedio de Cada Columna de una Matriz de NxN en un Vector. ");
						Console.ReadLine();
						Promedio_Columna.Operaciones();
						break;
					case 10:
						Console.Clear();
						Console.WriteLine("Has Seleccionado la Opcion : Votaciones: Suma de Cada Columna Representa un Candidato, \n" +
										  " Obtener al Candidato Ganador.");
						Console.ReadLine();
						Votaciones.Operaciones();
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
