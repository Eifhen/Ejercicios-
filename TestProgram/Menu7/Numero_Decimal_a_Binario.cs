using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Numero_Decimal_a_Binario
	{

		public static void Operaciones() 
		{
			
			string linea;
			int numero = 0;
			int AUX = 0;
			int indice = 0;
			const int BASE = 2;
			int[] arreglo_1 = new int[21];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- Numero Decimal a Binario ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite un Numero : ");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			numero = int.Parse(linea);
			indice = 1;
			
			while((numero >= BASE)) 
			{
				AUX = numero % BASE;
				arreglo_1[indice] = AUX;
				indice++;
				numero = numero / BASE;

			}
			arreglo_1[indice] = numero;

			// SALIDA

			for(int i = indice; i >= 1; i+= -1) 
			{
				Console.Write("{0} ",arreglo_1[i]);
			}

			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.WriteLine("********************************************************");
			Console.ReadLine();

		}
	}
}
