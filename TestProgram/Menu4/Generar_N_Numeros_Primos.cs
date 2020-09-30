using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu4
{
	class Generar_N_Numeros_Primos
	{

		public static void Operaciones() 
		{
			int numero = 1;
			int x = 0;
			int residuo, cantidad, k, sw;
			string linea;

			Console.Clear();
			Console.WriteLine("********************************************************");
			Console.WriteLine(" ------------- Generar n Numeros Primos ----------------");
			Console.WriteLine("********************************************************");
			Console.WriteLine("Cuantos Numeros ? ");
			linea = Console.ReadLine();
			Console.WriteLine("********************************************************");
			cantidad = int.Parse(linea);

			while (x < cantidad) 
			{
				k = 2;
				sw = 0;
				while((k < numero) && (sw == 0)) 
				{
					residuo = numero % k;
					if (residuo == 0)  sw = 1;
					else k++;
				}
				if(sw == 0) 
				{
					Console.WriteLine("{0} ", numero);
					x++;
				}
				numero++;
			}
			Console.WriteLine("********************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		} 
	} // End Class;
}
