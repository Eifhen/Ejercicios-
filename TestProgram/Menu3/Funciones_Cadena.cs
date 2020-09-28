using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu3
{
	class Funciones_Cadena
	{
		public void Operaciones() 
		{
			Console.Clear();
			Console.WriteLine("*******************************************************************");
			Console.WriteLine(" -------------------- Funciones de Cadena -------------------------");
			Console.WriteLine("*******************************************************************");

			string nombre;

			Console.WriteLine("*******************************************************************");
			Console.WriteLine("Ingresa tu Nombre.");
			Console.WriteLine("*******************************************************************");
			nombre = Console.ReadLine();

			Console.WriteLine("Longitud de la Cadena {0}", nombre.Length);
			Console.WriteLine("Encontrar la palabra VERDAD dentro de una cadena {0} ",nombre.Contains("VERDAD"));
			Console.WriteLine();

			Console.WriteLine("*******************************************************************");
			Console.WriteLine("Reemplazar una letra : ");
			Console.WriteLine("Reemplazar vocal A : {0} ", nombre.Replace('A','X'));
			Console.WriteLine("*******************************************************************");
			Console.WriteLine("Pasar a Minusculas : {0}", nombre.ToLower());
			Console.WriteLine("Capitalizar : {0}", nombre.ToUpper());
			Console.WriteLine("Remover 4 Letras : {0} ", nombre.Remove(3,4));
			Console.WriteLine("Extraer 4 Letras : {0} ", nombre.Substring(3,4));
			Console.WriteLine("Izquierda 4 Letras {0} ",Left(nombre,4)) ;
			Console.WriteLine("Derecha 4 Letras {0} ", Right(nombre,4));
			Console.WriteLine("********************************************************************");

			Console.WriteLine("Pulsa una tecla.");  Console.ReadLine(); Console.WriteLine("");
			Console.WriteLine("********************************************************************");
			Console.WriteLine("Desde la Izquierda");
			for( int i = 0; i <= nombre.Length; i++) 
			{
				Console.WriteLine(Left(nombre, i));
			}
			Console.WriteLine("********************************************************************");
			Console.WriteLine("Desde la Derecha");
			for(int i = 0; i <= nombre.Length; i++) 
			{
				Console.WriteLine(Right(nombre, i));
			}
			Console.WriteLine("********************************************************************");
			Console.WriteLine("Pulsa para volver al Menu.");
			Console.ReadLine();
		}
		public static string Left(string parametro, int longitud) 
		{
			string resultado = parametro.Substring(0, longitud);
			return resultado;
		}
		public static string Right(string parametro, int longitud) 
		{
			int value = parametro.Length - longitud;
			string resultado = parametro.Substring(value, longitud);
			return resultado;

		}

	}
}
