/* (2.2.1.2.2) Crea un programa que escriba en pantalla los números pares del 26 al
10 (descendiendo), usando "while".*/
	using System;
	
		class Ej_02_02_01_02_02
		{
			static void Main()
			{ 
				int num = 26;
				
				while (num >= 10){
					if(num % 2 == 0)
						Console.Write(num + " ");
					num--;
				}
			}
		} 
