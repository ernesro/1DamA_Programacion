/* (2.1.3.2) Crea un programa que pida al usuario dos números enteros. Si el
segundo no es cero, mostrará el resultado de dividir el primero entre el segundo.
Por el contrario, si el segundo número es cero, escribirá "Error: No se puede dividir
entre cero".*/	
	using System;
	
		class Ej_02_01_03_02
		{
			static void Main()
			{ 
				int num1, num2, prod;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduce otro numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num2 == 0)
				{	 
					Console.WriteLine("Error: No se puede dividir entre cero");
				
				}
				if (num2 > 0)
				{	 
					prod = num1/num2;
					Console.WriteLine("La division tiene como resultado " + prod);
				
				}
			}
		} 
