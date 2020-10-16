using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Valor_Absoluto
	{	

		private int Absoluto(int numero) 
		{
			if (numero < 0) numero = numero * -1;
			return numero;
		}
		public static void Operaciones() 
		{

			Valor_Absoluto objeto = new Valor_Absoluto();
			int numero = 0;
			int result = 0;
			string cadena;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------ [ Valor Absoluto de un Numero ]-----------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Operacion
			result = objeto.Absoluto(numero);

			// Salida
			Console.WriteLine("El Valor Absoluto de : {0} es {1} ", numero, result);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
