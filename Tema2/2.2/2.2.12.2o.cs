	/*(2.2.12.2) Crea un programa que escriba los números pares del 20 al 10, 
descendiendo, excepto el 14, primero con "for" y luego con "while"*/
	using System;
		class Ej_2_2_12_2{
			static void Main(){
			
				 int a, b=20;
				
				for(a=20; a>=10; a-=2){
					if(a != 14)
						Console.Write(a + " ");
				}
				Console.WriteLine("");
				while(b >= 10){
					if(b != 14){
						Console.Write(b + " ");
					}
				b-=2;
				}
			}
		}
