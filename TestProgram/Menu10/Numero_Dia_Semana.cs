using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu10
{
	class Numero_Dia_Semana
	{

		private string DiaSemana(int numero) 
		{
			string resultado;
			switch (numero) 
			{
				case 1:
					resultado = "Domingo";
					break;
				case 2:
					resultado = "Lunes";
					break;
				case 3:
					resultado = "Martes";
					break;
				case 4:
					resultado = "Miercoles";
					break;
				case 5:
					resultado = "Jueves";
					break;
				case 6:
					resultado = "Viernes";
					break;
				case 7:
					resultado = "Sabado";
					break;
				default:
					resultado = "No hay un Dia de la semana que corresponda con ese numero.";
					break;
			}

			return resultado;
		}
		public static void Operaciones() 
		{

			int numero = 0;
			string result = null;
			string cadena;
			Numero_Dia_Semana objeto = new Numero_Dia_Semana();

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----- Numero a Que Dia de la Semana Corresponde. ------");
			Console.WriteLine("********************************************************");
			
			// Input Data
			Console.WriteLine("Digite un Numero : ");
			cadena = Console.ReadLine();
			numero = int.Parse(cadena);
			Console.WriteLine("********************************************************");

			// Operation
			result = objeto.DiaSemana(numero);

			// Output Data
			Console.WriteLine("********************************************************");
			Console.WriteLine("Resultado es : {0}", result);
			Console.WriteLine("********************************************************");

			Console.WriteLine();
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();

		}
	}
}
