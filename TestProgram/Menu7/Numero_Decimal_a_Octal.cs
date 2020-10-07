using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Numero_Decimal_a_Octal
	{

		public static void Operaciones() 
		{
			string linea;
			const int base_numerica = 8;
			int numero = 0;
			int residuo = 0;
			int indice = 1;
			int[] arreglo = new int[20];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- Numero Decimal a Octal ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Introduce un Numero");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			numero = int.Parse(linea);

			while((numero >= base_numerica)) 
			{
				residuo = numero % base_numerica;
				arreglo[indice] = residuo;
				numero = numero / base_numerica;
				indice++;
			}
			arreglo[indice] = numero;

			// Salida
			for(int i = indice; i >= 1; i += -1) 
			{
				Console.Write("{0} ", arreglo[i]);
			}
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
