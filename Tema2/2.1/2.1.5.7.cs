/* (2.1.5.7) Crea un programa que pida al usuario dos números enteros y diga si uno
y sólo uno es par.*/	
	using System;
	
		class Ej_02_01_05_07
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if(((num1 % 2 == 0) && (num2 % 2 != 0)) || ((num1 % 2 != 0) && (num2 % 2 == 0))){
					Console.WriteLine("Uno y solo uno es par");
				}
			}
		} 
