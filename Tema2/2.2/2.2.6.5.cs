/*(2.2.6.5) Dibuja un triángulo de asteriscos descendente. Por ejemplo, si el usuario 
escoge "4" como tamaño, la primera fila tendrá 4 asteriscos, la segunda tendrá 3, 
la siguiente tendrá 2 y la última tendrá 1.*/

	using System;
		
		class Ej_2_2_6_5{
		
			static void Main(){
				
				int i, j, alto, c=0;
				
				Console.WriteLine("Introduce el alto");
				alto = Convert.ToInt32(Console.ReadLine());
				c=alto;
				
				for(i=alto; i>=1; i--){
					for(j=1; j<=c; j++){
						
						Console.Write("*");
					}
					c--;
					Console.WriteLine();
				}
			}	
		}		
