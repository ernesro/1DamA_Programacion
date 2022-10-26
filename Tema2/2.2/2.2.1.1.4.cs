/*(2.2.1.1.4) Crea una versión mejorada del programa anterior, que, tras introducir
cada par de números, responderá si el primero es múltiplo del segundo, o el
segundo es múltiplo del primero, o ninguno de ellos es múltiplo del otro..*/	
	using System;
	
		class Ej_02_02_01_01_04
		{
			static void Main()
			{ 
				int num1 = 1;
				int num2 = 1;
				
				while (num1 != 0 && num2 != 0){
					
					Console.WriteLine("Introduce el primer numero");
					num1 = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce el segundo numero");
					num2 = Convert.ToInt32(Console.ReadLine());
					
					if (num1 != 0 && num2 != 0){
						if(num1 % num2 != 0 && num2 % num1 != 0)
							Console.WriteLine("Ninguno es multiplo de otro");
						else if (num1 % num2 == 0)
							Console.WriteLine("El numero " + num1 + " es multiplo de " + num2);
							else
								Console.WriteLine("El numero " + num2 + " es multiplo de " + num1);
					}
					
				}
			}
		} 
