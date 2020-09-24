using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Suma_Numeros_Pares_Impares
	{

		public void Operaciones() 
		{
			string linea;
			byte numero;
			int suma_numero_impar = 0;
			int suma_numero_par = 0;

			Console.Clear();
			Console.WriteLine("**********************************************************************");
			Console.WriteLine("----------------Suma de Numeros Pares e Impares ----------------------");
			Console.WriteLine("**********************************************************************");
			Console.WriteLine("***  Digita un numero y te dare la suma de numeros pares e impares");
			Console.WriteLine("**********************************************************************");

			linea = Console.ReadLine();
			numero = byte.Parse(linea);

			for(int i = 1; i <= numero; i+=2) 
			{
				suma_numero_par = suma_numero_par + i;
			}
			for(int i = 2; i <= numero; i += 2) 
			{
				suma_numero_impar = suma_numero_impar + i;
			}

			Console.WriteLine("**********************************************************************");
			Console.WriteLine("Total de numeros pares : {0}", suma_numero_par);
			Console.WriteLine("**********************************************************************");
			Console.ReadLine();
			Console.WriteLine("**********************************************************************");
			Console.WriteLine("Total de numeros impares : {0}", suma_numero_impar);
			Console.WriteLine("**********************************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
