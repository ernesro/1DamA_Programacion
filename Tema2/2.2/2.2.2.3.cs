/*(2.2.2.3) Crea un programa que escriba en pantalla los números pares del 26 al 10
(descendiendo), usando "do..while".*/
	using System;
	
		class Ej_02_02_02_03
		{
			static void Main()
			{ 
				int num = 26;
				
				do{
					Console.Write(num + " ");
					num = num - 2;
				}while (num >= 10);
			}
		} 
