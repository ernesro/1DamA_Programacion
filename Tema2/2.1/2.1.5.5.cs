/* (2.1.5.5) Crea un programa que pida al usuario dos números enteros y diga si
ambos son pares.*/	
	using System;
	
		class Ej_02_01_05_06
		{
			static void Main()
			{ 
				int num1;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
			
				if((num1 % 2 == 0) && (num2 % 2 == 0)){
					Console.WriteLine("Ambos son pares");
				}
			}
		} 
