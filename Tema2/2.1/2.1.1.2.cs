/*(2.1.1.2) Crea un programa que pida al usuario dos números enteros y diga cuál es
el mayor de ellos.*/	
	using System;
	
		class Ej_02_01_01_02
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el segundo numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num1 < num2) 
					Console.WriteLine("El número {1} es mayor que el número {0}", num1, num2);
				if (num1 > num2) 
					Console.WriteLine("El número {0} es mayor que el número {1}", num1, num2);
			}
		} 
