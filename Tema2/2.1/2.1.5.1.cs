/* (2.1.5.1) Crea un programa que pida al usuario un número entero y responda si es
múltiplo de 2 o de 3.*/	
	using System;
	
		class Ej_02_01_05_01
		{
			static void Main()
			{ 
				int num1;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				
				if((num1 % 2 == 0) && (num1 % 3 == 0)){
					Console.WriteLine("Es multiplo de 2 y de 3");
				}
				else{	 
					if(num1 % 2 == 0){
						Console.WriteLine("Es multiplo de 2");
					}
					else{
						if(num1 % 3 == 0){
							Console.WriteLine("Es multiplo de 3");
						}
					}
				}
			}
		} 
