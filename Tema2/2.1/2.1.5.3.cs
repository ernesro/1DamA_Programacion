/*(2.1.5.3) Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 pero no de 3. */
	using System;
	
		class Ej_02_01_05_03
		{
			static void Main()
			{ 
				int num1;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				
				if((num1 % 2 == 0) && (num1 % 3 != 0)){
					Console.WriteLine("Es multiplo de 2 y no de 3");
				}
			}
		} 
