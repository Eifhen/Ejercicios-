using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Ejercicio_Propuesto_9
	{
		/*
			[ Mandato ]
			Crear una matriz de n * m filas (cargar n y m por teclado) 
			Imprimir la matriz completa y la última fila.
			
			[Descripcion Metodos]:
			
			[ Cargar ]: 
			Definimos el Numero de Filas y el Numero de Columnas que tendra nuestra Matriz, 
			Luego Introducimos los Datos en la Matriz.
			
			[Imprimir]:
			Encontramos la Primera Fila y la imprimimos, luego continuamos imprimiendo
			las demas Filas de manera subsecuente.
			
			[Imprimir Ultimo]
			Encuentra la Ultima Fila y la Imprime.
	
			[Operaciones]
			Despliega todos los metodos.
		*/

		private int[,] matriz;

		public void Cargar() 
		{
			int indice = 0;
			string linea;
			
			Console.WriteLine("¿Cuantas Filas Quieres que tenga la Matriz?");
			linea = Console.ReadLine();
			int numero_filas = int.Parse(linea);

			Console.WriteLine("¿Cuantas Columnas Quieres que tenga la Matriz?");
			linea = Console.ReadLine();
			int numero_columnas = int.Parse(linea);
			matriz = new int[numero_filas, numero_columnas];

			Console.WriteLine("********************************************************");
			Console.WriteLine("Numero de Filas en la Matriz : {0}", matriz.GetLength(0));
			Console.WriteLine("Numero de Columnas en la Matriz : {0}", matriz.GetLength(1));
			Console.WriteLine("Tu Matriz es : {0} x {1} ", matriz.GetLength(0), matriz.GetLength(1));
			Console.WriteLine("********************************************************");

			for (int fila = 0; fila < matriz.GetLength(0); fila++) 
			{
				for(int columna = 0; columna < matriz.GetLength(1); columna++) 
				{
					Console.Write("Indice {0} --> Ingrese el Elemento : ", indice);
					linea = Console.ReadLine();
					matriz[fila, columna] = int.Parse(linea);
					indice++;
				}
			}

		}
		public void Imprimir() 
		{
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			for (int fila = 0; fila < matriz.GetLength(0); fila++) 
			{
				if (fila == 0)
				{
					Console.Write("Primera Fila ---> ");
					for (int columna = 0; columna < matriz.GetLength(1); columna++)
					{
						Console.Write(" {0} ", matriz[fila, columna]);
					}
				}
				else 
				{
					for (int columna = 0; columna < matriz.GetLength(1); columna++)
					{
						Console.Write("{0}  ", matriz[fila, columna]);
					}
				}
				Console.WriteLine();
				Console.WriteLine("********************************************************");
			}
		}
		public  void Imprimir_Ultima_Fila() 
		{
			Console.WriteLine("********************************************************");
			Console.WriteLine("Imprimir Ultima Fila");
			Console.WriteLine("********************************************************");

			for(int columna = 0; columna < matriz.GetLength(1); columna++) 
			{
				int ultima_fila = matriz.GetLength(0) - 1; 
				Console.Write("{0}  ",matriz[ultima_fila, columna]);
			}
		}
		public  void Operaciones() 
		{

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------------- Ejercicio Propuesto 9 ----------------");
			Console.WriteLine("********************************************************");

			Cargar();
			Imprimir();
			Imprimir_Ultima_Fila();

			Console.WriteLine("");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu");
			Console.ReadLine();
		}
	}
}
