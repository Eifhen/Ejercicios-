using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Cantidad_Vocales_Cerradas
	{

		public static void Operaciones()
		{
			string linea, LE;
			int suma;

			Console.WriteLine("**************************************************");
			Console.WriteLine("-----------Cantidad de Volcales Cerradas ---------");
			Console.WriteLine("**************************************************");

			Console.WriteLine("Digite una Frase : ");
			Console.WriteLine("");
			linea = Console.ReadLine();
			Console.WriteLine("***************************************************");
			suma = 0;
			linea = linea.ToUpper();
			Console.WriteLine(linea);
			for(int i = 0; i < linea.Length; i++) 
			{
				LE = Mid(linea, i, 1);
				if(LE.Contains("U") || LE.Contains("I")) 
				{
					suma = suma + 1;
				}		
			}
			Console.WriteLine("****************************************************");
			Console.WriteLine("Existen {0} Vocales Cerradas. ", suma);
			Console.WriteLine("****************************************************");
			Console.WriteLine("Pulsa una tecla para volver al menu."); Console.ReadLine();
		} //End Method 

		public static string Mid(string parametro, int startIndex, int length)
		{
			string result = parametro.Substring(startIndex, length);
			return result;
		}
		public static string Mid(string parametro, int startIndex)
		{
			string result = parametro.Substring(startIndex);
			return result;
		}

	}//Class
} //NameSpace
