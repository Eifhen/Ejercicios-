using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Ejercicio_Propuesto_10
	{
		/*
			[Mandato]
			Se tiene la siguiente información:
				· Nombres de 4 empleados.
				· Ingresos en concepto de sueldo, cobrado por cada empleado, en los últimos 3 meses.
				Confeccionar el programa para:
				a) Realizar la carga de la información mencionada.
				b) Generar un vector que contenga el ingreso acumulado en sueldos en los últimos 3 meses para
				cada empleado.
				c) Mostrar por pantalla el total pagado en sueldos a todos los empleados en los últimos 3 meses.
				d) Obtener el nombre del empleado que tuvo el mayor ingreso acumulado.
			

			[Respuesta]
			
			[ Ingreamos los Datos ]
				En este Apartado Ingresamos los Datos a la Matriz[ 5 , 4] (filas, columnas respectivamente)
				en la Columna 1 Ingresamos los Nombres de los Empleados.
				en la Columna 2 Ingresamos los Salarios de los Empleados.
				en la Columna 3 Ingresamos la Suma de 3 Meses de Salario de Cada Empleado.

			[ Definimos el Mayor Salario ]
				En este apartado tratamos de identificar al empleado de mayor salario dentro de la matriz
				debemos encontrar el Nombre y el Salario espeficico de dicho empleado

				Para esto vamos Comparando los salarios Indice por Indice, de la Columna 2
				hasta obtener el salario mayor.
				Luego capturamos el valor de dicho indice mediante la Variable Indice
				esta variable nos permitira encontrar el nombre de dicho Empleado.
				
			[ Imprimimos todos los empleados con sus respectivos salarios ]
				Imprime las tres columnas de la matriz que estamos utilizando
				las Columnas 1, 2, 3
				Columna 1 : Nombre Empleado;
				Columna 2 : Salario Empleado;
				Columna 3 : Salario a 3 Meses;
			 
			[ Salida ]
				Imprimimos la Suma de todos los salarios de los empleados
				y Imprimimos el Nombre y el Salario del Empleado de Mayor Salario.
		 */

		public static void Operaciones() 
		{
			int fila = 0;
			int columna = 0;
			int numero = 0;
			int indice = 0;
			int mayor_salario = 0;
			int total_salario = 0;
			int total_salario_3_meses = 0;

			string nombre_empleado_mayor_salario = " ";
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- [ Ejercicio Propuesto 10] ---------------");
			Console.WriteLine("********************************************************");

			string[,] Empleado = new string[ 5 , 4];

			// [ Ingreamos los Datos ]
			Console.WriteLine();
			for (fila = 1; fila < 5; fila++) 
			{
				Console.Write("Ingresa el Nombre del Empleado {0} / 4 : ", fila);
				linea = Console.ReadLine();
				Empleado[fila, 1] = linea;

				Console.Write("Ingresa el Salario del Empleado {0} / 4 : ", fila);
				linea = Console.ReadLine();
				Empleado[fila, 2] = linea;

				total_salario_3_meses = int.Parse(linea) * 3;
				Empleado[fila, 3] = total_salario_3_meses.ToString();

				total_salario = total_salario + total_salario_3_meses;

				Console.WriteLine();
			}

			// [ Definimos el Mayor Salario ]
			numero = int.Parse(Empleado[2, 2]);
			for (fila = 1; fila < 5; fila++) 
			{
				mayor_salario = int.Parse(Empleado[fila, 2]);
				
				if (mayor_salario >= numero)
				{
					indice = fila; 
					nombre_empleado_mayor_salario = Empleado[indice, 1];
					numero = mayor_salario;
				}
				else
					mayor_salario = numero;
			}

			// [ Imprimimos todos los empleados con sus respectivos salarios ]
			Console.WriteLine("********************************************************");
			Console.WriteLine("[Nombre Empleado] [Salario Empleado] [3 Meses de Salario]");
			Console.WriteLine("********************************************************");
			for (fila = 1; fila < 5; fila++) 
			{
				for(columna = 1; columna <= 3; columna++) 
				{
					Console.Write("  {0}             ", Empleado[fila, columna]);		
				}
				Console.WriteLine();
			}
			Console.WriteLine();
			Console.WriteLine("********************************************************");

			// [ Salida ]
			Console.WriteLine("Total Pagado en Sueldos a todos los Empleados durante 3 Meses : {0} ", total_salario);
			Console.WriteLine("Empleado con el Mayor Salario es : {0} con un Salario de : {1}", nombre_empleado_mayor_salario, mayor_salario);


			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
