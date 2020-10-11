using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Sumar_Diagonales_Matriz
	{


		public static void Operaciones() 
		{

			int fila = 0;
			int columna = 0;
			int suma_diagonal_principal = 0;
			int suma_diagonal_secundaria = 0;
			int numero = 0;
			string linea;
			
			Console.Clear();
			Console.WriteLine("************************************************************************");
			Console.WriteLine(" Sumar Elementos Diagonal Principal y Diagonal Secundaria Matriz N x N ");
			Console.WriteLine("************************************************************************");

			// Definimos tamaño de la matriz
			Console.WriteLine("Define el Tamaño de la Matriz : ");
			linea = Console.ReadLine();
			numero = int.Parse(linea);
			int[,] matriz = new int[numero + 1, numero+1];

			// Llenamos la matriz con numeros aleatorios.
			Random numero_aleatorio = new Random();

			for (fila = 1; fila <= numero; fila++) 
			{
				Console.Write("Fila {0} --> ", fila);

				for (columna = 1; columna <= numero; columna++ ) 
				{
					matriz[fila, columna] = numero_aleatorio.Next(1, 9);
					Console.Write("{0} ", matriz[fila, columna]);
				}
				Console.WriteLine();
			}

			// Suma Diagonal Principal
			Console.WriteLine("************************************************************************");
			Console.WriteLine("[Suma Diagonal Principal]");
			for (fila = 1; fila <= numero; fila++) 
			{
				Console.Write("{0} ", matriz[fila, fila]);
				suma_diagonal_principal = suma_diagonal_principal + matriz[fila, fila];
			}
			Console.WriteLine();
			Console.WriteLine("************************************************************************");

			// Suma Diagonal Secundaria
			columna = numero;
			Console.WriteLine("************************************************************************");
			Console.WriteLine("[Suma Diagonal Secundaria]");
			for (fila = 1; fila <= numero; fila++) 
			{
				Console.Write("{0} ", matriz[fila , columna]);
				suma_diagonal_secundaria = suma_diagonal_secundaria + matriz[fila, columna];
				columna --;
			}
			Console.WriteLine();
			Console.WriteLine("************************************************************************");

			// Salida
			Console.WriteLine();
			Console.WriteLine("Suma Diagonal Principal : {0}", suma_diagonal_principal);
			Console.WriteLine("Suma Diagonal Secundaria : {0}", suma_diagonal_secundaria);
			Console.WriteLine("************************************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
