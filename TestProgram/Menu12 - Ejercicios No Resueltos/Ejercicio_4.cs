using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_4
	{
		/*
		 	4)	Crear un programa que pida al usuario dos números reales. Si el segundo no es cero, mostrará el
				resultado de dividir entre el primero y el segundo. Por el contrario, si el segundo número es cero,
				escribirá “Error: No se puede dividir entre cero”.
		*/

		private int IsValid(int numero) 
		{
			while(numero == 0) 
			{
				Console.WriteLine("Error. No se puede dividir entre 0.");
				Console.WriteLine("Ingresa un Numero");
				numero = int.Parse(Console.ReadLine());
			}
			return numero;
		}

		public static void Operaciones() 
		{
			int numero1 = 0;
			int numero2 = 0;
			int dividir = 0;
			Ejercicio_4 objeto = new Ejercicio_4();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 4 ] -------------------");
			Console.WriteLine("********************************************************");

			// Ingresamos Datos a la variable Numero1
			Console.WriteLine("Ingresa un Numero : ");
			numero1 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");


			// validamos
			numero1 = objeto.IsValid(numero1);

			// Ingresamos Datos a la variable Numero2
			Console.WriteLine("Ingresa un Segundo Numero : ");
			numero2 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// validamos
			numero2 = objeto.IsValid(numero2);

			// Dividimos
			dividir = (numero1 / numero2);

			// Salida
			Console.WriteLine("{0} entre {1} es igual a : {2}", numero1, numero2, dividir);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
