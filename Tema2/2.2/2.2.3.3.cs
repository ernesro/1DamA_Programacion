/*(Crea un programa que muestre los números del 100 al 200 (ambos
incluidos) que sean divisibles entre 7 y a la vez entre 3.*/
	using System;
	
		class Ej_02_02_03_03
		{
			static void Main()
			{ 
				int contador;
				
				for (contador = 100; contador <= 200; contador++)
					if (contador % 3 ==0 && contador % 7 == 0)
						Console.Write("{0} ", contador);
			}
		} 
