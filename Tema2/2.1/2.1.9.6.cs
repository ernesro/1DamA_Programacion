/*(2.1.9.6) Repite el ejercicio 2.1.9.3, empleando "if" en lugar de "switch".*/
	using System;
	
		class Ej_02_01_09_06
		{
			static void Main()
			{ 
				char caracter;
				
				Console.WriteLine("Introduzca un caracter");
				caracter = Convert.ToChar(Console.ReadLine());
				
				if ((caracter >= '0') && (caracter <='9'))
					Console.WriteLine("Numero");
				else if(caracter == 'a' || caracter == 'e' || caracter == 'i' || caracter == 'o' || caracter == 'u')
					Console.WriteLine("Vocal");
					else
						Console.WriteLine("Consonante");
			}
		} 
