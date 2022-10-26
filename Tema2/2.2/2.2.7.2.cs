/* (2.2.7.2) Crea un programa que muestre 5 veces las letras de la L (mayúscula) a la 
N (mayúscula), en la misma línea, empleando dos "for" anidados)*/

	using System;
		class Ej_2_2_7_2{
			static void Main(){
			
				char letras = 'L';
				int i, j;
				
				for(i=0; i<5; i++){
					for(j=76; j<=78; j++){
					Console.Write(letras + " ");
					letras++;
					}
					Console.Write( "  -  ");
					letras='L';
				}
			}
		}
		
		
				
