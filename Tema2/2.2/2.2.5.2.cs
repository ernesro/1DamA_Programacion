/* (2.2.5.2) Crea un programa escriba 4 veces los números del 1 al 5, en una misma
línea, usando "while": 12345123451234512345.*/

	using System;
		
		class Ej_2_2_5_2{
		
			static void Main(){
				
				int i=0, j;
				
				while(i<4){
					i++;
					j=0;
					while(j < 5){
						j++;
						Console.Write(j);
					}
				}
			}	
		}		
