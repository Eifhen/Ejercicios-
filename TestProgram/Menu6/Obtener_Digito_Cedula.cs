using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu6
{
	class Obtener_Digito_Cedula
	{

		public static void Operaciones() 
		{
			string linea;
			bool IsValid = false;
			int suma_pares = 0, suma_impares = 0, indice = 0, ST = 0, Dv = 0;
			int[] array = new int[10];

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------ Obtener Digito Verificador de la Cedula --------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Ingresa 10 Numeros : ");
			Console.WriteLine("");
			//Ingreso de Datos
			for ( int i = 0; i < 10; i++) 
			{
				Console.Write("Indice {0} --> ", i);
				linea = Console.ReadLine();
				array[i] = int.Parse(linea);
			}

			//Sumatoria de Pares e Impares
			for( int i = 1; i < 10; i++) 
			{
				if ((array[i] % 2) == 0)
					suma_pares = suma_pares + array[i];
				else
					suma_impares = suma_impares + array[i];
			}
			// Obtencion de Digito Verificador
			ST = suma_pares + suma_impares;
			Dv = 10 - (ST % 10);
			if (Dv == 10) Dv = 0;

			Console.WriteLine("");
			Console.WriteLine("********************************************************");
			Console.WriteLine("El Digitor Verificador es {0} ", Dv);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

;		}
	}
}
