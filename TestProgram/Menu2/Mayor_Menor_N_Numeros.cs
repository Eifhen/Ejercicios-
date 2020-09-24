using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Mayor_Menor_N_Numeros
	{
		public void Operaciones() 
		{
			byte cantidad;
			int numero_Mayor, numero_Menor, numero;
			string linea;
			Console.Clear();
			Console.WriteLine("******************************************************");
			Console.WriteLine("------------- Mayor o Menor de N NUMEROS -------------");
			Console.WriteLine("******************************************************");
			Console.WriteLine("Ingresa el Limite de numeros:");
			Console.WriteLine("******************************************************");
			linea = Console.ReadLine();
			cantidad = byte.Parse(linea);
			Console.WriteLine("******************************************************");
			Console.WriteLine("Digita un numero:");
			Console.WriteLine("******************************************************");
			linea = Console.ReadLine();
			numero_Mayor = int.Parse(linea);
			numero_Menor = numero_Mayor;
			for(int k = 2; k <= cantidad; k++) 
			{
				Console.WriteLine("******************************************************");
				Console.WriteLine("Digita un numero:");
				Console.WriteLine("******************************************************");
				linea = Console.ReadLine();
				numero = int.Parse(linea);
				if (numero > numero_Mayor) numero_Mayor = numero;
				if (numero < numero_Menor) numero_Menor = numero;
			}
			Console.WriteLine("***********************************************************");
			Console.WriteLine("La diferencia es : ");


		}
	}
}
