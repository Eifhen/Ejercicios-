using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu5
{
	class Numero_Aleatorio
	{

		public static void Operaciones() 
		{
			string linea;
			int numero;
			Random numero_random = new Random();
			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ---------- Numero Aleatorio entre 10 y 30 ------------");
			Console.WriteLine("********************************************************");


			do 
			{
				do  
				{ 
					numero = Convert.ToInt32(numero_random.Next(100)); 
				} 
				while (!((numero >= 10) & (numero <= 30))) ;


				Console.WriteLine("Se Genero el numero : {0}", numero);
				Console.WriteLine("********************************************************");
				Console.WriteLine("Genera Otro Numero : S/N");
				linea = Console.ReadLine();
				linea = linea.ToUpper();
				Console.WriteLine("********************************************************");

			}  while (linea == "S");
			
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
	
		}
	}
}
