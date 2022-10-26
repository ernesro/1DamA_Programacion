/*(2.1.8.2) Usa el operador condicional para calcular el menor de dos números*/	
	using System;
	
		class Ej_02_01_08_02
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduce dos números");
				num1 = Convert.ToInt32(Console.ReadLine());
				num2 = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine(num1 < num2 ? num1 : num2);
			}
		} 
