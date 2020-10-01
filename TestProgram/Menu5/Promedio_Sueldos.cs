using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Promedio_Sueldos
	{
		public static void Operaciones() 
		{
			string linea;
			int cantidad = 0;
			int numero_empleados = 0;
			int i = 0;
			double sueldo_total = 0;
			double sueldo = 0;
			double promedio = 0;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------------- Promedio Sueldos --------------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Digite el Numero de Empleados");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			numero_empleados = int.Parse(linea);

			do 
			{
				Console.WriteLine("Digite un Sueldo");
				linea = Console.ReadLine();
				Console.WriteLine("********************************************************");
				sueldo = double.Parse(linea);
				if(sueldo > 0) 
				{
					sueldo_total = sueldo_total + sueldo;
					cantidad++;
					i++;
				}
			
			} while (i < numero_empleados);

			promedio = sueldo_total / cantidad;
			Console.WriteLine();
			Console.WriteLine("********************************************************");
			Console.WriteLine("Total Sueldos : {0}",sueldo_total);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Empleados : {0}",cantidad);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Promedio : {0}", promedio);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
