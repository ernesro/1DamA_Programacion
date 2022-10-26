/* (2.2.7.1) Crea un programa que muestre las letras de la Z (mayúscula) a la A 
(mayúscula, descendiendo)*/

	using System;
		class Ej_2_2_7_1{
			static void Main(){
			
				char letras = 'Z';
				int i;
				for(i=25; i>=0; i--){
					Console.Write(letras + " ");
					letras--;
				}
			}
		}
		
		
				
