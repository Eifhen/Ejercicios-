using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Calificacion
	{
		public void Operaciones()
		{
			string linea;
			int calificacion = 0;

			Console.Clear();
			Console.WriteLine("****************************************");
			Console.WriteLine("Ingrese la Calificacion");
			Console.WriteLine("La Calificacion debe estar comprendida entre el 10 y el 6.");
			Console.WriteLine("****************************************");
			linea = Console.ReadLine();
			calificacion = int.Parse(linea);

			switch (calificacion) 
			{
				case 10:
					Console.WriteLine("Tu Calificacion es Excelente.");
					Console.ReadLine();
					break;
				case 9:
					Console.WriteLine("Tu Calificacion es Muy Buena.");
					Console.ReadLine();
					break;
				case 8:
					Console.WriteLine("Tu Calificacion es Buena ");
					Console.ReadLine();
					break;
				case 7:
					Console.WriteLine("Tu Calificacion es Regular");
					Console.ReadLine();
					break;
				case 6:
					Console.WriteLine("Tu Calificacion es Mala");
					Console.ReadLine();
					break;
				default:
					Console.WriteLine("Estas Fuera de Rango");
					Console.ReadLine();
					break;
			}
			Console.WriteLine("Pulsa Para volver al Menu");
			Console.ReadLine();

		}
	}//End Class
}// End NameSpace
