using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Hospital
	{

		public void Operaciones() 
		{
			string linea,area;
			double total, porcentaje,presupuesto;
			byte calculos;

			Console.Clear();
			Console.WriteLine("************************************************************************");
			Console.WriteLine("-------- PRESUPUESTO ANUAL EN AREAS DE HOSPITAL --------");
			Console.WriteLine("************************************************************************");

			Console.WriteLine("Cuantos Calculos?");
			linea = Console.ReadLine();
			calculos = byte.Parse(linea);
			Console.WriteLine("************************************************************************");
			Console.WriteLine("Digite el total del presupuesto");
			linea = Console.ReadLine();
			presupuesto = double.Parse(linea);
			for (int i = 1; i < calculos; i++) 
			{
				Console.WriteLine("*********************************************************************");
				Console.WriteLine("Digite el Nombre del Area.");
				Console.WriteLine("las Areas disponibles son : Ginecologia, Traumatologia, Pediatria.");
				Console.WriteLine("**********************************************************************");
				area = Console.ReadLine();
				switch (area.ToUpper()) 
				{
					case "GINECOLOGIA":
						porcentaje = 40;
						break;
					case "TRAUMATOLOGIA":
						porcentaje = 30;
						break;
					case "PEDIATRIA":
						porcentaje = 30;
						break;
					default:	
						porcentaje = 0;
						break;
				}

				total = (porcentaje * presupuesto) / 100;
				Console.WriteLine("**********************************************************************");
				Console.WriteLine("El Area : {0} recibe {1:C}",area,total);
			}
			Console.WriteLine("*************************************************************************");
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();
		}
	}
}
