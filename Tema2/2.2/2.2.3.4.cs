/*(2.2.3.4) Crea un programa que muestre la tabla de multiplicar del 9*/
	using System;
	
		class Ej_02_02_03_04
		{
			static void Main()
			{ 
				int contador;
				
				for (contador = 0; contador <= 10; contador++)
						Console.WriteLine("9 x " + contador + " = " + 9 * contador);
			}
		} 
