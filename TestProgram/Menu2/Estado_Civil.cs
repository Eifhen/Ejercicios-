using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Estado_Civil
	{
		public void Operaciones() 
		{
			char Estado_Civil;
			string linea;
			Console.Clear();
			Console.WriteLine("***************************************************************");
			Console.WriteLine("Estado Civil");
			Console.WriteLine("***************************************************************");
			Console.WriteLine("Digita C, D, S, V, segun sea tu estado (Digita las letras en mayusculas)");
			Console.WriteLine("C = Casado");
			Console.WriteLine("D = Divorciado");
			Console.WriteLine("S = Soltero");
			Console.WriteLine("V = Viudo");
			Console.WriteLine("***************************************************************");
			Console.WriteLine("");
			linea = Console.ReadLine();
			Estado_Civil = char.Parse(linea);

			switch (Estado_Civil) 
			{
				case 'C':
					Console.WriteLine("Tu Estado Civil es : Casado/a");
					break;
				case 'D':
					Console.WriteLine("Tu Estado Civil es : Divorciado/a");
					break;
				case 'S':
					Console.WriteLine("Tu Estado Civil es : Soltero/a");
					break;
				case 'V':
					Console.WriteLine("Tu Estado Civil es : Viudo/a");
					break;
				default:
					Console.WriteLine("NO EXISTE");
					break;

			}
			Console.WriteLine("");
			Console.WriteLine("Pulsa para volver al menu.");
			Console.ReadLine();
		}
	}
}
