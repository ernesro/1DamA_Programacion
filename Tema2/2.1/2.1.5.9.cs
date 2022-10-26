/* (2.1.5.9) Crea un programa que pida al usuario tres números y muestre cuál es el
mayor de los tres.*/
	using System;
	
		class Ej_02_01_05_09
		{
			static void Main()
			{ 
				int num1, num2, num3;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num3 = Convert.ToInt32(System.Console.ReadLine());
				
				if((num1 > num2) && (num1 > num3)){
					Console.WriteLine("El mayor es " + num1);
				}
				else if((num2 > num1) && (num2 > num3)){
						Console.WriteLine("El mayor es " + num2);
				}
					else{
						Console.WriteLine("El mayor es " + num3);
					}	
			}
		} 
