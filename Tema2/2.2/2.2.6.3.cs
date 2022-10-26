/* (2.2.6.3) Haz un programa que dibuje un cuadrado de asteriscos, cuyo ancho (y 
alto, que tendrá el mismo valor) será introducido por el usuario..*/

	using System;
		
		class Ej_2_2_6_3{
		
			static void Main(){
				
				int i, j, lado;
				
				Console.WriteLine("Introduce el lado");
				lado = Convert.ToInt32(Console.ReadLine());
					
				for(i=1; i<=lado; i++){
					for(j=1; j<=lado; j++)
						Console.Write("* ");
					Console.WriteLine();
				}
			}	
		}		
