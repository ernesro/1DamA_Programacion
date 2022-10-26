/* (2.1.5.10) Crea un programa que pida al usuario dos números enteros y diga si son
iguales o, en caso contrario, cuál es el mayor de ellos*/	
	using System;
	
		class Ej_02_01_05_010
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if(num1 == num2){
					Console.WriteLine("Los numeros son iguales");
				}
				else if(num1 > num2){
					Console.WriteLine("El mayor es " + num1);
				}
				else{
					Console.WriteLine("El mayor es " + num2);
				}	
			}
		} 
