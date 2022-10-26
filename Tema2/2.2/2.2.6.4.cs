/*(2.2.6.4) Crea un triángulo de asteriscos, que mostrará uno en la primera fila, dos 
en la segunda, tres en la tercera y así sucesivamente, hasta llegar al tamaño 
indicado por el usuario.*/

	using System;
		
		class Ej_2_2_6_4{
		
			static void Main(){
				
				int i, j, alto, c=0;
				
				Console.WriteLine("Introduce el alto");
				alto = Convert.ToInt32(Console.ReadLine());
					
				for(i=1; i<=alto; i++){
					for(j=0; j<=c; j++){
						
						Console.Write("*");
					}
					c++;
					Console.WriteLine();
				}
			}	
		}		
