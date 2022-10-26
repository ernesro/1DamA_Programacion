/* (2.1.2.1) Crea un programa que pida al usuario un número entero. Si es múltiplo
de 10, informará al usuario y pedirá un segundo número, para decir a
continuación si este segundo número también es múltiplo de 10.*/	
	using System;
	
		class Ej_02_01_02_01
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num1 % 10 == 0)
				{
					Console.WriteLine("El número {0} es multiplo del número 10", num1); 
					 
					Console.WriteLine("Introduce otro numero");
					num2 = Convert.ToInt32(System.Console.ReadLine());
					
					if (num1 % 10 == 0)
						Console.WriteLine("El número {0} es multiplo del número 10", num2);
				}
			}
		} 
