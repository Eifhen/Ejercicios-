using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu11
{
	class Trasformar_Decimal_a_Binario
	{
		private string ToBinary(int numero) 
		{
			int k = 0;
			int auxiliar = 0;
			string resultado = null;
			string binario = null;

			resultado = "";
			while(numero >= 2) 
			{
				auxiliar = numero % 2;
				resultado = resultado + auxiliar.ToString();
				numero = numero / 2;
			}

			resultado = resultado + numero.ToString();
			binario = "";

			for (k = resultado.Length; k >= 1; k+= -1) 
			{
				binario = binario + resultado.Substring(k - 1, 1);
			}

			return binario;
		}

		public static void Operaciones() 
		{
			int numero = 0;
			string result = null;
			string cadena;
			Trasformar_Decimal_a_Binario objeto = new Trasformar_Decimal_a_Binario();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" -------- Transformar Numero Decimal a Binario ---------");
			Console.WriteLine("********************************************************");

			// Ingresamos Datos
			Console.WriteLine("Ingrese un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);

			// Operacion
			result = objeto.ToBinary(numero);

			// Salida
			Console.WriteLine("El Resultado es : {0}", result);

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
