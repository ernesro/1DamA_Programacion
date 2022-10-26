/*(2.2.3.1) Crea un programa que muestre los números del 10 al 20, ambos
incluidos, usando "for"..*/
	using System;
	
		class Ej_02_02_03_01
		{
			static void Main()
			{ 
				int contador;
				
				for (contador = 10; contador <= 20; contador++)
					Console.Write("{0} ", contador);
			}
		} 
