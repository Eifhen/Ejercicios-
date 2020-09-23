using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Operacion2
	{
	
		public void Operacion() 
		{

			

			int NUMERO, UNIDAD, AUX, DECENA, CENTENA, RECIDUO;
			string linea;
			Console.WriteLine("Ingrese un numero de tres cifras");
			linea = Console.ReadLine();
			NUMERO = int.Parse(linea);
			CENTENA = NUMERO / 100;
			RECIDUO = NUMERO % 100;
			DECENA = RECIDUO / 10;
			UNIDAD = RECIDUO % 10;
			

			if (UNIDAD == 0)
			{
				AUX = (DECENA * 10) + CENTENA;		

				Console.WriteLine("La Centena es igual a : " + CENTENA);
				Console.WriteLine("El Reciduo es igual a : " + RECIDUO);
				Console.WriteLine("La Decena es igual a : " + DECENA);
				Console.WriteLine("La Unidad es igual a : " + UNIDAD);
				Console.WriteLine("El numero invertido es : " + UNIDAD + AUX);
				Console.WriteLine("**************************************");
				Console.WriteLine("Pulsa para volver al Menu");
				Console.WriteLine("**************************************");
				Console.ReadLine();
	
			}
			else 
			{
				AUX = (UNIDAD * 100) + (DECENA * 10) + CENTENA;
				Console.WriteLine("La Centena es igual a : " + CENTENA);
				Console.WriteLine("El Reciduo es igual a : " + RECIDUO);
				Console.WriteLine("La Decena es igual a : " + DECENA);
				Console.WriteLine("La Unidad es igual a : " + UNIDAD);
				Console.WriteLine("Numero Invertido es : " + AUX);
				Console.WriteLine("**************************************");
				Console.WriteLine("Pulsa para volver al Menu");
				Console.WriteLine("**************************************");
				Console.ReadLine();
			
			}
				

		

		}

	}
}
