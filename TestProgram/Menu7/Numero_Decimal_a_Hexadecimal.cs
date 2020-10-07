using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu7
{
	class Numero_Decimal_a_Hexadecimal
	{

		public static void Operaciones()
		{
			const int base_numerica = 16;
			int numero = 0;
			int residuo = 0;
			int indice = 0;

			string linea;
			string data;
			string[] arreglo = new string[21];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------- Numero Decimal a Hexadecimal --------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite un Numero");
			linea = Console.ReadLine();
			numero = int.Parse(linea);

			// Proceso
			indice = 1;
			while ((numero >= base_numerica)) 
			{
				residuo = numero % base_numerica;
				switch (residuo) 
				{
					case 10:
						data = "A";
						break;
					case 11:
						data = "B";
						break;
					case 12:
						data = "C";
						break;
					case 13:
						data = "D";
						break;
					case 14:
						data = "E";
						break;
					case 15:
						data = "F";
						break;
					default:
						data = residuo.ToString();
						break;
				}

				arreglo[indice] = data;
				indice++;
				numero = numero / base_numerica;
			}
			// end while

			switch (numero) 
			{
				case 10:
					data = "A";
					break;
				case 11:
					data = "B";
					break;
				case 12:
					data = "C";
					break;
				case 13:
					data = "D";
					break;
				case 14:
					data = "E";
					break;
				case 15:
					data = "F";
					break;
				default:
					data = Convert.ToString(numero);
					break;
			}

			arreglo[indice] = data;

			//salida
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
