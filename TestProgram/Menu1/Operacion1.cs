using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Operacion1
	{
		
		public void Operacion() 
		{


			int NUM,AUX, DEC, UNI;
			String Linea;
			Console.WriteLine("Ingrese un numero de Dos Cifras");
			Linea = Console.ReadLine();
			NUM = int.Parse(Linea);
			DEC = NUM / 10;
			UNI = NUM % 10;
			AUX = (UNI * 10) + DEC;

			Console.WriteLine("El Valor ingresado es de : " + NUM);
			Console.WriteLine("Dividido entre 10 : " + DEC);
			Console.WriteLine("El Resto de la divicion es : " + UNI);
			Console.WriteLine("El numero invertido es : " + AUX);
			Console.WriteLine("**************************************");
			Console.WriteLine("Pulsa para volver al Menu");
			Console.WriteLine("**************************************");
			Console.ReadLine();
		

		}


	}
}
