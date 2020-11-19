using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_2
	{
		/*
		      2) Crear un programa que pida al usuario dos números enteros y diga si el primero es múltiplo del
			  segundo (pista: igual que antes, habrá que ver si el resto de la división es cero: a % b == 0).
		*/
		public static void Operaciones()
		{
			int numero1 = 0;
			int numero2 = 0;
			int residuo = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 2 ] -------------------");
			Console.WriteLine("********************************************************");

			// Ingresamos 2 Numeros
			Console.WriteLine("Ingresa el Primer Numero : ");
			numero1 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			Console.WriteLine("Ingresa el Segundo Numero : ");
			numero2 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Operacion : Determinamos si los numeros son multiplos
			residuo = numero1 % numero2;

			if (residuo == 0) Console.WriteLine("{0} y {1} Son Multiplos", numero1, numero2);
			else Console.WriteLine("{0} y {1} No Son Multiplos", numero1, numero2);

			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
