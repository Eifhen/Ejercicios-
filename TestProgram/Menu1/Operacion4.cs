using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgram
{
	class Operacion4
	{

		public void Operacion() 
		{

				double Monto_Apagar;
				byte Cantidad_Hamburguesas, Cantidad_Papas, Cantidad_Bebidas;
				string pedido;
				int numero_pedido = 0;
				const double precio_hamburguesa = 100;
				const double precio_papas = 50;
				const double precio_bebidas = 25;

				Console.WriteLine("********************************************************");
				Console.WriteLine("BIENVENIDO AL RESTAURANTE DE COMIDA RAPIDA");
				Console.WriteLine("********************************************************");
				Console.WriteLine("");
				Console.WriteLine("PRECIOS");
				Console.WriteLine(" 1 *  Hamburguesas = " + precio_hamburguesa);
				Console.WriteLine("");
				Console.WriteLine(" 2 * Papas Fritas = " + precio_papas);
				Console.WriteLine("");
				Console.WriteLine(" 3 * Bebidas = " + precio_bebidas);
				Console.WriteLine("");
				Console.WriteLine(" 4 * No quiero nada mas.");

				Console.WriteLine("********************************************************");
				Console.WriteLine("Proseguiremos con tu orden : ");
				Console.WriteLine("********************************************************");
				Console.WriteLine("[Hamburguesas]");
				Console.WriteLine("Cuantas Hamburguesas quieres?");
				pedido = Console.ReadLine();
				Cantidad_Hamburguesas = byte.Parse(pedido);

				Console.WriteLine(" [Papas Fritas]");
				Console.WriteLine("Cuantas Papas Fritas quieres?");
				pedido = Console.ReadLine();
				Cantidad_Papas = byte.Parse(pedido);

				Console.WriteLine("Seleccionaste Bebidas");
				Console.WriteLine("Cuantas Bebidas quieres?");
				pedido = Console.ReadLine();
				Cantidad_Bebidas = byte.Parse(pedido);

				Monto_Apagar = (Cantidad_Hamburguesas * precio_hamburguesa) +
							   (Cantidad_Papas * precio_papas) +
							   (Cantidad_Bebidas * precio_bebidas);

				Console.WriteLine("********************************************");
				Console.WriteLine("Gracias por su compra");
				Console.WriteLine("El monto a pagar es de :" + Monto_Apagar);
				Console.WriteLine("********************************************");
				Console.ReadLine();
		}
			
		
	}
}
