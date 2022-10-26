/*(2.2.1.2.1) Crea un programa que escriba en pantalla los números del 1 al 10,
usando "while"*/
	using System;
	
		class Ej_02_02_01_02_01
		{
			static void Main()
			{ 
				int cont = 1;
				
				while (cont <= 10){
					Console.Write(cont + " ");
					cont++;
				}
			}
		} 
