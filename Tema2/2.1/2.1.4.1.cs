/* (2.1.4.1) Mejora la solución al ejercicio 2.1.3.1, usando "else".*/	
	using System;
	
		class Ej_02_01_04_01
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num1 == 0){	 
					Console.WriteLine("Multiplicar por 0 es cero");
				}
				else{	 
					Console.WriteLine("Introduce otro numero");
					num2 = Convert.ToInt32(System.Console.ReadLine());
					Console.WriteLine(" El resultado de " + num1 + " * " + num2 + " es " + num1*num2);
				}
				
			}
		} 
