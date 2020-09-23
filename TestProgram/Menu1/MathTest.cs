using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class MathTest
	{

		public void Operacion() 
		{
			Console.WriteLine("***************************************");
			Console.WriteLine("OPERACIONES CON LA LIBRERIA MATH");
			Console.WriteLine("***************************************");

			int numero;
			string linea;
			long resultado;
			double numero_decimal;

			Console.WriteLine("Introduce un numero");
			Console.WriteLine("");
			linea = Console.ReadLine();
			numero = int.Parse(linea);

			Console.WriteLine("Introduce un numero decimal");
			Console.WriteLine("");
			linea = Console.ReadLine();
			numero_decimal = double.Parse(linea);
			Console.WriteLine("***********************************************************");

			Console.WriteLine("El Valor Absoluto de : " +numero+" es : " + Math.Abs(numero));
			Console.WriteLine("El Valor del numero : "+numero+ " elevado al cuadrado es : "+ Math.Pow(numero,2));
			Console.ReadLine();
			Console.WriteLine("La Raiz Cuadrada del numero : "+numero+" es : "+Math.Sqrt(numero));
			Console.WriteLine("El SENO del numero : " + numero + " es : " + Math.Sin(numero * Math.PI / 180));
			Console.ReadLine();
			Console.WriteLine("El COSENO del numero : " + numero + " es : " + Math.Cos(numero * Math.PI / 180));
			Console.WriteLine("El numero Maximo entre " + numero + " y 50 es : " + Math.Max(numero, 50));
			Console.ReadLine();
			Console.WriteLine("El numero Minimo entre " + numero + " y 60 es : " + Math.Min(numero, 60));
			Console.WriteLine("La Parte Entera de : "+numero_decimal+ " es : "+Math.Truncate(numero_decimal));
			Console.ReadLine();
			Console.WriteLine("El Redondeo de : "+numero_decimal+" es : "+Math.Round(numero_decimal));
			Console.WriteLine("Pulsa para volver al Menu");
			Console.ReadLine();
			
		}


	}
}
