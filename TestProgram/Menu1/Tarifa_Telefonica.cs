using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Tarifa_Telefonica
	{
		public void Operaciones() 
		{
			int Cantidad_Kilovatios;
			double Costo_Kilovatios = 0;
			double Total;
			string linea;

			Console.WriteLine("*************************************");
			Console.WriteLine("       [ Tarifa Telefonica ]  ");
			Console.WriteLine("*************************************");
			Console.WriteLine("");
			Console.WriteLine("*************************************");
			Console.WriteLine("       [ Cantidad Kilovatios ]  ");
			Console.WriteLine("*************************************");
			linea = Console.ReadLine();
			Cantidad_Kilovatios = int.Parse(linea);
			if (Cantidad_Kilovatios <= 1000)
				Costo_Kilovatios = 0.14;
			if (Cantidad_Kilovatios > 1000 && Cantidad_Kilovatios <= 1800)
				Costo_Kilovatios = 0.12;
			if (Cantidad_Kilovatios > 1800)
				Costo_Kilovatios = 0.8;

			Total = Costo_Kilovatios * Cantidad_Kilovatios;
			Console.WriteLine("A Pagar : {0} ",Total);
			Console.WriteLine("Pulse para volver al menu.");
			Console.ReadLine();


		}
	}
}
