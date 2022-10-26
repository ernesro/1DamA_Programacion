	/*(2.1.9.4) Repite el ejercicio 2.1.9.1, empleando "if" en lugar de "switch".*/
	using System;
	
		class Ej_02_01_09_04
		{
			static void Main()
			{ 
				int numero;
				
				Console.WriteLine("Introduzca un numero del 1 al 10");
				numero = Convert.ToInt32(System.Console.ReadLine());
				
					if(numero == 1)Console.WriteLine("Uno");
					if(numero == 1)Console.WriteLine("Dos");
					if(numero == 1)Console.WriteLine("Tres");
					if(numero == 1)Console.WriteLine("Cuatro");
					if(numero == 1)Console.WriteLine("Cinco");
					if(numero == 1)Console.WriteLine("Seis");
					if(numero == 1)Console.WriteLine("Siete");
					if(numero == 1)Console.WriteLine("Ocho");
					if(numero == 1)Console.WriteLine("Nueve");
					if(numero == 1)Console.WriteLine("Diez");
			}
		} 
