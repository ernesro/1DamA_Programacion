/* (2.2.5.3) Crea un programa que, para los números entre el 10 y el 20 (ambos
incluidos) diga si son divisibles entre 5, si son divisibles entre 6 y si son divisibles
entre 7, usando dos bucles anidados..*/

	using System;
		
		class Ej_2_2_5_3{
		
			static void Main(){
				
				int i, j;
				
				for(i=10; i<=20; i++){
					for(j=5; j<=7; j++)
						if(i % j == 0)
							Console.WriteLine(i + " es divisible entre " + j);
				}
			}	
		}		
