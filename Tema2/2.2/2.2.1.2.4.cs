/* (2.2.1.2.4) Haz un programa que muestre tantos asteriscos (en la misma línea)
como indique el usuario.*/
	using System;
	
		class Ej_02_02_01_02_04
		{
			static void Main()
			{ 
				int num;
				
				Console.WriteLine("Introduzca un numero");
				num = Convert.ToInt32(System.Console.ReadLine());
				
				while (num >= 1){
					Console.Write("*");
					num--;
				}
			}
		} 
