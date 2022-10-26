/* (2.1.1.1) Crea un programa que pida al usuario un número entero y diga si es par
(pista: habrá que comprobar si el resto que se obtiene al dividir entre dos es cero:
if (x % 2 == 0) …).*/	
	using System;
	
		class Ej_02_01_01_01
		{
			static void Main()
			{ 
				int numero;
				
				Console.WriteLine("Introduzca el numero");
				numero = Convert.ToInt32(System.Console.ReadLine());
				
				if (numero % 2 == 0) 
					Console.WriteLine("El número es par.");
				if (numero % 2 > 0) 
					Console.WriteLine("El número es impar.");
			}
		} 
