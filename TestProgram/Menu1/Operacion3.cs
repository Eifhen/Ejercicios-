using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Operacion3
	{

		int num1, num2, result;
		string linea;
		public void Operacion() 
		{
			Console.WriteLine("**************************************");
			Console.WriteLine("Ingresa el Primer Numero");
			Console.WriteLine("**************************************");
			linea = Console.ReadLine();
			num1 = int.Parse(linea);

			Console.WriteLine("**************************************");
			Console.WriteLine("Ingresa el segundo Numero");
			Console.WriteLine("**************************************");
			linea = Console.ReadLine();
			num2 = int.Parse(linea);

			result = num1 + num2;
			Console.WriteLine("La Suma Es {0} : ", result);
			
			result = num1 - num2;
			Console.WriteLine("La Resta Es : "+num1+" - "+num2+" = " + result);

			result = num1 * num2;
			Console.WriteLine("La Multiplicacion es : " + result);

			result = num1 / num2;
			Console.WriteLine("La Division es : " + result);

			result = num1 % num2;
			Console.WriteLine("El residuo es : " + result);
			Console.WriteLine("**************************************");
			Console.WriteLine("Pulsa para volver al Menu");
			Console.WriteLine("**************************************");
			Console.ReadLine();


		}


	}
}
