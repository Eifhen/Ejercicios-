using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Triangulos
	{
		public void Operaciones() 
		{
			int lado1, lado2, lado3;
			string linea;

			Console.WriteLine("****************************************");
			Console.WriteLine("Triangulos");
			Console.WriteLine("****************************************");
			Console.WriteLine("Digite el Lado 1");
			linea = Console.ReadLine();
			lado1 = int.Parse(linea);

			Console.WriteLine("Digite el lado 2");
			linea = Console.ReadLine();
			lado2 = int.Parse(linea);

			Console.WriteLine("Digite el lado 3");
			linea = Console.ReadLine();
			lado3 = int.Parse(linea);
			Console.WriteLine("***********************************************************************");
			if ((lado1 == lado2) & (lado2 == lado3))
				Console.WriteLine("El Triangulo es Equilatero, Todos sus lados son iguales.");
			else
				if ((lado1 != lado2) & (lado2 != lado3) & (lado1 != lado3))
					Console.WriteLine("El Triangulo es ESCALENO, ninguno de sus lados son iguales.");
				else
					Console.WriteLine("Triangulo es ISOCELES, dos de sus lados son iguales");

			Console.WriteLine("***********************************************************************");
			Console.WriteLine("Pulsa una tecla para volver al menu.");
			Console.ReadLine();
			
		}
	}
}
