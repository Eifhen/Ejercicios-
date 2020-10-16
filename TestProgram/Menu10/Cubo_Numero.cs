using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Cubo_Numero
	{
		private int CUBO(int numero)
		{
			int result = numero * numero * numero;
			return result;
		}

		public static void Operaciones() 
		{
			int numero = 0;
			int result = 0;
			string cadena;
			Cubo_Numero ob = new Cubo_Numero();


			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- [ Cubo de un Numero ] -----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			result = ob.CUBO(numero);


			Console.WriteLine("********************************************************");
			Console.WriteLine("El Cubo de {0} es : {1}", numero, result);
			Console.WriteLine("********************************************************");
			Console.WriteLine();


			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();



		}
	}
}
