using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class FormatoSalida
	{

		public void Operacion() 
		{
			double Base, Altura, Resultado;
			string linea;

			Console.WriteLine("***********************************");
			Console.WriteLine("Digite la BASE : ");
			Console.WriteLine("***********************************");
			linea = Console.ReadLine();
			Base = double.Parse(linea);

			Console.WriteLine("***********************************");
			Console.WriteLine("Digite la Altura : ");
			Console.WriteLine("***********************************");
			linea = Console.ReadLine();
			Altura= double.Parse(linea);
			Resultado = (Base * Altura) / 2;

			Console.WriteLine("***********************************");
			Console.WriteLine("");
			Console.WriteLine("El Area del TRIANGULO ES : " + Resultado);
			Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:####.00}", Resultado));
			Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:c}", Resultado));
			Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:f}", Resultado));
			Console.WriteLine("AREA TRIANGULO :" + String.Format("{0:g}", Resultado));
			Console.WriteLine("");
			Console.WriteLine("***********************************");

			Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:F}", DateTime.Now));
			Console.WriteLine("HOY ES: " + String.Format("MES ES {0:MMMM} {0:dd/MM/yyy}", DateTime.Now));
			Console.WriteLine("HOY ES: " + String.Format("AÑO ES  {0:yyy} {0:dd/MM/yyy}", DateTime.Now));
			Console.WriteLine("HOY ES: " + String.Format("Hoy es {0:dddd} {0:dd/MM/yyy}", DateTime.Now));
			Console.Write("Pulse una Tecla:"); Console.ReadLine();



		}
	}
}
