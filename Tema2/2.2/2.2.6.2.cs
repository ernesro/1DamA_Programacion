/* (2.2.6.2) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto 
(por ejemplo, 3) y escriba un rectángulo formado por esa cantidad de asteriscos:
****
****
****
*/
	using System;
		
		class Ej_2_2_6_2{
		
			static void Main(){
				
				int i, j, alto, ancho;
				
				Console.WriteLine("Introduce el alto");
				alto = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el ancho");
				ancho = Convert.ToInt32(Console.ReadLine());
					
				for(i=1; i<=alto; i++){
					for(j=1; j<=ancho; j++)
						Console.Write("*");
					Console.WriteLine();
				}
			}	
		}		
