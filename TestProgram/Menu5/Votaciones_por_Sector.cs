using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Votaciones_por_Sector
	{

		public static void Operaciones() 
		{

			int Cantidad_Norte = 0;
			int Cantidad_Centro = 0;
			int Cantidad_Sur = 0;
			string linea, zona;
			char operacion;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" --------------- Votaciones por Sector -----------------");

			do 
			{
				Console.WriteLine("********************************************************");
				Console.WriteLine("Sectores : Norte, Centro, Sur");
				Console.WriteLine("********************************************************");
				Console.WriteLine("Digita el Nombre del Sector :");
				Console.WriteLine("********************************************************");
				zona = Console.ReadLine();
				zona = zona.ToUpper();
				switch (zona) 
				{
					case "NORTE":
						Cantidad_Norte++;
						break;
					case "CENTRO":
						Cantidad_Centro++;
						break;
					case "SUR":
						Cantidad_Sur++;
						break;
					default:
						Console.WriteLine("Opcion Fuera de Rango");
						Console.ReadLine();
						break;
				}

				Console.WriteLine("Hay Mas Personas? S / N");
				linea = Console.ReadLine();
				operacion = char.Parse(linea.ToUpper());

			} while (operacion.ToString().Contains("S"));
			Console.WriteLine("********************************************************");
			Console.WriteLine("Votos de la Zona Norte : {0}",Cantidad_Norte);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Votos de la Zona Sur : {0}", Cantidad_Sur);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Votos del Centro : {0}", Cantidad_Centro);
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
	}
}
