/* (2.1.9.5) Repite el ejercicio 2.1.9.2, empleando "if" en lugar de "switch" (pista: como
las cifras numéricas del 0 al 9 están ordenadas, no hace falta comprobar los 10
valores, sino que se puede hacer con "if ((simbolo >= '0') && (simbolo <='9'))")..*/	
	using System;
	
		class Ej_02_01_09_05
		{
			static void Main()
			{ 
				char caracter;
				
				Console.WriteLine("Introduzca un caracter");
				caracter = Convert.ToChar(Console.ReadLine());
				
				if ((caracter >= '0') && (caracter <='9'))
					Console.WriteLine("Numero");
				if(caracter == '.')
					Console.WriteLine("Signo de puntuacion");
				if(caracter == ',')
					Console.WriteLine("Signo de puntuacion");
				if(caracter == ':')
					Console.WriteLine("Signo de puntuacion");
				if(caracter == ';')
					Console.WriteLine("Signo de puntuacion");
				if ((caracter >= 'a') && (caracter <='z') || (caracter >= 'A') && (caracter <='Z'))
					Console.WriteLine("Letra");
			}
		} 
