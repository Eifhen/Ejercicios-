using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Mayor_3_Numeros
	{

		private int MayorDeTres(int numero1, int numero2, int numero3) 
		{
			int mayor = numero1;
			if (numero2 > mayor) mayor = numero2;
			if (numero3 > mayor) mayor = numero3;
			return mayor;
		}
		public static void Operaciones() 
		{
			Mayor_3_Numeros objeto = new Mayor_3_Numeros();
			int num1 = 0;
			int num2 = 0;
			int num3 = 0;
			int result = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- [ Mayor de 3 Numeros ] ----------------");
			Console.WriteLine("********************************************************");
			
			// Ingresamos los Datos
			Console.WriteLine("Digite el Primer Numero : ");
			cadena = Console.ReadLine();
			num1 = int.Parse(cadena);

			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite el Segundo Numero : ");
			cadena = Console.ReadLine();
			num2 = int.Parse(cadena);

			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite el Tercer Numero : ");
			cadena = Console.ReadLine();
			num3 = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Operacion
			result = objeto.MayorDeTres(num1, num2, num3);

			//Salida
			Console.WriteLine("El Numero Mayor es : {0}", result);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
