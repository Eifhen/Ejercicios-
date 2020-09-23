using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram.Menu2
{
	class Ejercicio_Propuesto3
	{

		public void Operaciones()
		{
			string linea;
			char tecla;
			Console.Clear();
			Console.WriteLine("******************************************************************");
			Console.WriteLine("*  Escribe una Letra : el programa determinara                   *");
			Console.WriteLine("*  Si se trata de una vocal, de una consonante                   *");
			Console.WriteLine("*  o de un numero.                                               *");
			Console.WriteLine("******************************************************************");
			
			linea = Console.ReadLine();
			linea.ToLower();			
			tecla = char.Parse(linea);
			
			if (Char.IsLetter(tecla))
			{	
				
				switch (tecla)
				{
					case 'a':
						Console.WriteLine("La tecla que ingresaste es una Vocal y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'e':
						Console.WriteLine("La tecla que ingresaste es una Vocal y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'i':
						Console.WriteLine("La tecla que ingresaste es una Vocal y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'o':
						Console.WriteLine("La tecla que ingresaste es una Vocal y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'u':
						Console.WriteLine("La tecla que ingresaste es una Vocal y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'q':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'w':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'r':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;
					case 't':

						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'y':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'p':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 's':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'd':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'f':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'g':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'h':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'j':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'k':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'l':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'z':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'x':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'c':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'v':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'b':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'n':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'm':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;

					case 'ñ':
						Console.WriteLine("La tecla que ingresaste es una Consonante y su valor es : {0}", tecla);
						Console.ReadLine();
						break;
				}
			}
			else if (Char.IsDigit(tecla))
			{
				Console.WriteLine("La tecla que ingresaste es un Numero y su valor es : {0}",linea);
				Console.ReadLine();
			}
			else
			{
				Console.WriteLine("No Precionaste ni una tecla ni un numero");
				Console.ReadLine();
			}

			Console.WriteLine("Pulsa para volver al Menu");
			Console.ReadLine();

		}
	}
}
