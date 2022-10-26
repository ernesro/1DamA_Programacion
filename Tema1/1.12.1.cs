	
	// Esto acorta las ordenes, ya no hace falta poner "System."
	using System;
	
		class Ej_01_12_01
		{
			static void Main()
			{
				int a, b;
				int op1;
				double op2;
			
					Console.WriteLine("Introduce el primer número");
						a = Convert.ToInt32(System.Console.ReadLine());
					
					Console.WriteLine("Introduce el segundo número");
						b = Convert.ToInt32(System.Console.ReadLine());
					
					op1 = (a + b) * (a - b);
					op2 = Math.Pow(a, 2) - Math.Pow(b, 2);

					Console.WriteLine("El resultado de  ( {0} + {1} ) * ( {0} - {1} ) con los numeros introducidos es {2} y el resultado de  {0}^2 - {1}^2  es igual a {3} ", a, b, op1, op2);

			}
		} 
