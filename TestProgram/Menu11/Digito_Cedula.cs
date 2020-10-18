using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu11
{
	class Digito_Cedula
	{
		private int D_Verificador(string cedula) 
		{
			int suma_pares = 0;
			int suma_impares = 0;
			int suma_total = 0;
			int auxiliar = 0;
			int digito = 0;

			// Suma de Pares
			for(int k = 2; k <= 8; k+=2) 
			{	
				// la variable cedula contiene una cadena de numeros, 
				// con esto evaluamos la cadena numero por numero
				suma_pares = suma_pares + int.Parse(cedula.Substring(k - 1, 1));
			}

			// Suma Impares
			for(int k = 1; k <= 9; k += 2) 
			{
				auxiliar = int.Parse(cedula.Substring(k - 1, 1)) * 2;
				if (auxiliar > 9) auxiliar = auxiliar - 9;
				suma_impares = suma_impares + auxiliar;
			}

			// Obtencion de Digito
			suma_total = suma_pares + suma_impares;
			digito = 10 - (suma_total % 10);
			if (digito == 10) digito = 0;

			return digito;
		}
		public static void Operaciones() 
		{
			
			string cedula = null;
			int Digito_Verificador = 0;
			Digito_Cedula objeto = new Digito_Cedula();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---- Obtener el Dígito Verificador para la Cédula. ----");
			Console.WriteLine("********************************************************");
			
			Console.WriteLine("DIGITE los Primeros 9 Dígitos de su Cédula : ");
			cedula = Console.ReadLine();
			Digito_Verificador = objeto.D_Verificador(cedula);

			Console.WriteLine("********************************************************");
			Console.WriteLine("El Digito Verificador es : {0}", Digito_Verificador);
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
