/*(2.1.1.3) Crea un programa que pida al usuario dos números enteros y diga si el
primero es múltiplo del segundo (pista: igual que en el ejercicio 2.1.1.1, habrá que
ver si el resto de la división es cero: a % b == 0).*/	
	using System;
	
		class Ej_02_01_01_03
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el segundo numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num1 % num2 == 0) 
					Console.WriteLine("El número {1} es multiplo del número {0}", num1, num2);
					
				if (num1 % num2 != 0) 
					Console.WriteLine("El número {1} no es multiplo del número {0}", num1, num2);
			}
		} 
