/*(2.2.1.1.2) Crea un "calculador de cuadrados": pedirá al usuario un número y
mostrará su cuadrado. Se repetirá mientras el número introducido no sea cero
(usa "while" para conseguirlo).*/	
	using System;
	
		class Ej_02_02_01_01_02
		{
			static void Main()
			{ 
				int num = 1;
				
				while (num != 0){
					
					Console.WriteLine("Introduce un numero");
					num = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("El cuadrdo de " + num + " es " + num * num);
				}
			}
		} 
