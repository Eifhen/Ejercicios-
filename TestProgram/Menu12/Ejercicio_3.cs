using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_3
	{
		/*
		 *  3)	Crear un programa que multiplique dos números enteros de la siguiente forma: pedirá al usuario un
				primer número entero. Si el número que se que teclee es 0, escribirá en pantalla "El producto de 0 por
				cualquier número es 0". Si se ha tecleado un número distinto de cero, se pedirá al usuario un segundo
				número y se mostrará el producto de ambos.
		*/
		private int validar(int numero) 
		{
			// Validamos que el numero Ingresado no sea 0
			while (numero == 0)
			{
				Console.WriteLine("El Producto de 0 por cualquier número es 0.");
				Console.WriteLine("********************************************************");
				Console.WriteLine("Ingresa un Numero");
				numero = int.Parse(Console.ReadLine());
				Console.WriteLine("********************************************************");
			}
			return numero;
		}
		public static void Operaciones() 
		{
			int numero1 = 0;
			int numero2 = 0;
			int multiplicar = 0;
			Ejercicio_3 objeto = new Ejercicio_3();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 3 ] -------------------");
			Console.WriteLine("********************************************************");

			// Ingresar Datos : Primer Numero
			Console.WriteLine("Ingresa un Numero : ");
			numero1 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Validamos que el numero Ingresado no sea 0
			numero1 = objeto.validar(numero1);

			// Ingresar Datos : Segundo Numero
			Console.WriteLine("Ingresa un Segundo Numero : ");
			numero2 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Validamos que el numero Ingresado no sea 0
			numero2 = objeto.validar(numero2);

			// Multiplicamos
			multiplicar = (numero1 * numero2);

			// Salida
			Console.WriteLine("{0} x {1} es igual a : {2}", numero1, numero2, multiplicar);
			Console.WriteLine("********************************************************");


			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
