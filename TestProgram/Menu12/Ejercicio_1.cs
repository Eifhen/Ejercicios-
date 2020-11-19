using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu12___Ejercicios_No_Resueltos
{
	class Ejercicio_1
	{
		/*
			1)  El usuario tecleará dos números (x e y), y el programa deberá calcular cual es el resultado de su
			    división y el resto de esa división. 
		*/

		public static void Operaciones() 
		{
			int num1 = 0; 
			int num2 = 0;
			int residuo = 0;
			int dividir = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------------ [ Ejercicio 1 ] -------------------");
			Console.WriteLine("********************************************************");

			// Ingresamos los Datos
			Console.WriteLine("Ingresa el Primer Numero : ");
			num1 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			Console.WriteLine("Ingresa el Segundo Numero : ");
			num2 = int.Parse(Console.ReadLine());
			Console.WriteLine("********************************************************");

			// Reciduo de los Dos Numeros
			residuo = (num1 % num2);

			// Division 
			dividir = (num1 / num2);

			// Salida
			Console.WriteLine("********************************************************");
			Console.WriteLine("La Division de {0} entre {1} es igual a : {2}", num1, num2, dividir);
			Console.WriteLine("********************************************************");
			Console.WriteLine("El Residuo de {0} y {1} = {2}", num1, num2, residuo);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();


		}
	}
}
