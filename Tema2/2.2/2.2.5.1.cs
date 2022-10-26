/* (2.2.5.1) Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "for": 12345123451234512345.*/

	using System;
		
		class Ej_2_2_5_1{
		
			static void Main(){
				
				int i;
				
				for(i=1; i<5 ; i++){
					for(int j=1; j <= 5 ;j++)
						Console.Write(j);
				}
			}	
		}		
