using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_7
	{

		/*
			7)	Crear un programa que use el operador condicional para mostrar un el valor absoluto de un número
				de la siguiente forma: si el número es positivo, se mostrará tal cual; si es negativo, se mostrará
				cambiado de signo. 
		*/
		public static void Operaciones() 
		{
			int numero = 0;
			int absoluto = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 7 ] -------------------");
			Console.WriteLine("********************************************************");

			// Ingresamos datos
			Console.WriteLine("Ingresa un Número");
			numero = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Operacion : Valor absoluto de numero
			absoluto = Math.Abs(numero);

			// Salida
			Console.WriteLine("El valor absoluto de : {0} Es : {1}", numero, absoluto);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
