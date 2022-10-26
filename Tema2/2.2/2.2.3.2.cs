/*(2.2.3.2) Crea un programa que escriba en pantalla los números del 1 al 50 que
sean múltiplos de 3 (pista: habrá que recorrer todos esos números y ver si el resto
de la división entre 3 resulta 0)...*/
	using System;
	
		class Ej_02_02_03_02
		{
			static void Main()
			{ 
				int contador;
				
				for (contador = 1; contador <= 50; contador++)
					if (contador % 3 ==0)
						Console.Write("{0} ", contador);
			}
		} 
