/* (2.1.4.2) Mejora la solución al ejercicio 2.1.3.2, usando "else".*/	
	using System;
	
		class Ej_02_01_04_02
		{
			static void Main()
			{ 
				int num1, num2, prod;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduce otro numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num2 == 0){	 
					Console.WriteLine("Error: No se puede dividir entre cero");
				}
				else{	 
					prod = num1/num2;
					Console.WriteLine("La division tiene como resultado " + prod);
				}
			}
		} 
