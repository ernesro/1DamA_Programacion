/*((2.2.2.2) Crea un programa que escriba en pantalla los números del 1 al 10,
usando "do..while". */
	using System;
	
		class Ej_02_02_02_02
		{
			static void Main()
			{ 
				int num = 1;
				
				do{
					Console.Write(num + " ");
					num++;
				}while (num <= 10);
			}
		} 
