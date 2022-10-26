/* (2.2.6.1) Crea un programa que escriba 4 líneas de texto, cada una de las cuales
estará formada por los números del 1 al 5.*/

	using System;
		
		class Ej_2_2_6_1{
		
			static void Main(){
				
				int i, j;
				
				for(i=1; i<=4; i++){
					for(j=1; j<=5; j++)
						Console.Write(j);
					Console.WriteLine();
				}
			}	
		}		
