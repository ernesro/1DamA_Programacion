/* (2.1.9.1) Crea un programa que pida un número del 1 al 10 al usuario, y escriba el
nombre de ese número, usando "switch" (por ejemplo, si introduce "1", el
programa escribirá "uno").*/	
	using System;
	
		class Ej_02_01_09_01
		{
			static void Main()
			{ 
				int numero;
				
				Console.WriteLine("Introduzca un numero del 1 al 10");
				numero = Convert.ToInt32(System.Console.ReadLine());
				
				switch (numero)
				{
					case 1 :Console.WriteLine("Uno");
						break;
					case 2:Console.WriteLine("Dos");
						break;
					case 3:Console.WriteLine("Tres");
						break;
					case 4:Console.WriteLine("Cuatro");
						break;
					case 5:Console.WriteLine("Cinco");
						break;
					case 6:Console.WriteLine("Seis");
						break;
					case 7:Console.WriteLine("Siete");
						break;
					case 8:Console.WriteLine("Ocho");
						break;
					case 9:Console.WriteLine("Nueve");
						break;
					case 10: Console.WriteLine("Diez");
						break;
				}
			}
		} 
