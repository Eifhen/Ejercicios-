using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Adivina_Numero
	{


		public static void Operaciones ()
		{

			const int oportunidades = 4;
			int numero, adivina;
			byte sw = 0;
			byte I = 1;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ----------------- Adivina un Numero -------------------");
			Console.WriteLine("********************************************************");

			// generamos numero aleatorio entre 1 y 20

			Random numero_aleatorio = new Random();
			do 
			{
				numero = Convert.ToInt32(numero_aleatorio.Next(100));
			} while (!(numero >= 1 && numero <= 20));

			do 
			{
				Console.WriteLine("Adivina el Numero que fue generado por el sistema");
				linea = Console.ReadLine();
				Console.WriteLine("********************************************************");
				adivina = int.Parse(linea);
				if (adivina == numero)
				{
					Console.WriteLine("Imposible!! Adivinaste!!!");
					sw = 1;
				}
				else 
				{
					if (adivina > numero) Console.WriteLine("Te Pasaste!");
					else Console.WriteLine("Estas ABAJO!");
				}

				I++;
			} while ((I <= oportunidades) && (sw == 0));

			Console.WriteLine("********************************************************");
			if (sw == 0) Console.WriteLine("El Numero Fue {0} ", numero);

			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulse para volver al Menu.");
			Console.ReadLine();

		}
	}
}
