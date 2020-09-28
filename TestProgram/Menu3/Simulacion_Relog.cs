using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Simulacion_Relog
	{

		public static void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("************************************************************************");
			Console.WriteLine(" -------------------- Simulacion Relog Digital -------------------------");
			Console.WriteLine("************************************************************************");

			byte Horas, Minutos, Segundos;
			Console.SetCursorPosition(15,2);
			for(Horas = 0; Horas <= 24; Horas++) 
			{
				for(Minutos = 0; Minutos <= 59; Minutos++) 
				{

					for (Segundos = 0; Segundos <= 59; Segundos++)
					{
						Console.SetCursorPosition(20, 10);
						Console.WriteLine("{0} : {1} : {2} ", Horas, Minutos, Segundos);
					}
				}
			}
			Console.SetCursorPosition(25, 15);
			Console.WriteLine("Pulsa Para volver al menu.");
			Console.ReadLine();
		}
	}
}
