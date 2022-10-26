/* (2.1.5.6) Crea un programa que pida al usuario dos números enteros y diga si (al
menos) uno es par.*/	
	using System;
	
		class Ej_02_01_05_06
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if((num1 % 2 == 0) && (num2 % 2 == 0)){
					Console.WriteLine("Ambos son pares");
				}
					else if((num1 % 2 == 0) || (num2 % 2 == 0)){
						Console.WriteLine("Al menos uno es par");
				}
			}
		} 
