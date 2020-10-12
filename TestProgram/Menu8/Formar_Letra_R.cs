using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu8
{
	class Formar_Letra_R
	{

		public static void Operaciones() 
		{

			int filas = 0;
			int columnas = 0;
			int numero = 0;
			int Mi = 0;
			int Fi = 0;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------ Formar la Letra ( R ) en una Matriz N x N ------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Tamaño de la Matriz : ");
			linea = Console.ReadLine();
			numero = int.Parse(linea);

			// [ Matriz en Blanco ]
			numero = (numero % 2 == 0 ? numero + 1 : numero);
			string[,] matriz = new string[numero + 1, numero + 1];

			for(filas = 1; filas <= numero; filas++) 
			{
				for(columnas = 1; columnas <= numero; columnas++) 
				{
					matriz[filas, columnas] = " ";
					// espacio en blanco
				}
			}

			// [ Formamos la Letra]

			Mi = (numero / 2) + 1;

			for(filas = 1; filas <= numero; filas++) 
			{
				matriz[filas, 1] = "A";
				matriz[Mi, filas] = "A";
				matriz[1, filas] = "A";
			}

			Fi = Mi;

			// para empesar desde la mitad de la fila
			for (filas = 1; filas <= Mi; filas++) 
			{
				matriz[filas, numero] = "A";
				matriz[Fi, Fi] = "A";
				Fi = Fi + 1;
			}

			// [ Salida ]
			int altura = 7;
			for(filas = 1; filas <= numero; filas++) 
			{
				for(columnas = 1; columnas <= numero; columnas++) 
				{
					Console.SetCursorPosition(columnas, altura);
					Console.Write(matriz[filas, columnas]);
				}
				altura++;
				Console.WriteLine();
			}

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
