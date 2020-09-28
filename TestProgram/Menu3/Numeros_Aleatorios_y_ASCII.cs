using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Numeros_Aleatorios_y_ASCII
	{
		public void Operaciones() 
		{
			byte cantidad, k;
			int numero;
			string linea,codigo;
			Console.Clear();
			Console.WriteLine("************************************************************************");
			Console.WriteLine(" ------------------- NUMEROS Aleatorios y ASCII ------------------------");
			Console.WriteLine("************************************************************************");
			Console.WriteLine("¿Cuantos Numeros vas a ingresar?");
			
			linea = Console.ReadLine();
			cantidad = byte.Parse(linea);

			// Inicializa el generador de aleatorios.
			Random random = new Random();

			for(k = 1; k < cantidad; k++) 
			{
				numero = Convert.ToInt32(random.Next(100));
				codigo = Convert.ToString((char)numero);
				Console.WriteLine("***********************************************************************");
				Console.WriteLine("El numero Generado Aleatoreamente es el : {0}", numero);
				Console.WriteLine("***********************************************************************");
				if ((numero < 256) & (numero > 0))
					Console.WriteLine("El Codigo del numero : {0} es : {1} ",numero,codigo);
			}
			Console.WriteLine("Pulsa para volver al menu");
			Console.ReadLine();
		}
	}
}
