/*(2.2.1.1.3) Crea un programa que pida de forma repetitiva pares de números al
usuario. Tras introducir cada par de números, responderá si el primero es múltiplo
del segundo. Se repetirá mientras los dos números sean distintos de cero
(terminará cuando uno de ellos sea cero).*/	
	using System;
	
		class Ej_02_02_01_01_03{
			
			static void Main(){
				 
				int num1 = 1;
				int num2 = 1;
				
				while (num1 != 0 && num2 != 0){
					
					Console.WriteLine("Introduce el primer numero");
					num1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce el segundo numero");
					num2 = Convert.ToInt32(Console.ReadLine());
					
					if (num1 != 0 && num2 != 0){
						if(num1 % num2 == 0)
							Console.WriteLine("El numero " + num1 + " es multiplo de " + num2);
						else
							Console.WriteLine("El numero " + num1 + " no es multiplo de " + num2);
					}
				}
			}
		} 
