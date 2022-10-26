	
	// Esto acorta las ordenes, ya no hace falta poner "System."
	using System;
	
		class Ej_01_11_02
		{
			static void Main()
			{
				int primerNumero;
				int segundoNumero;
				int division;
				int resto;
			
					Console.WriteLine("Introduce el primer número");
					primerNumero = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("Introduce el segundo número");
					segundoNumero = Convert.ToInt32(Console.ReadLine());
					
					division = primerNumero / segundoNumero;
					resto = primerNumero % segundoNumero;

					Console.WriteLine("La division de {0} entre {1} es {2} y el resto es {3}", primerNumero, segundoNumero, division, resto);
			}
		} 
