	/*(2.2.11.4) Crea una versión alternativa del ejercicio 2.2.11.2, que no emplee 
"continue" sino el "if" contrario.*/
	using System;
		class Ej_2_2_11_4{
			static void Main(){
			
				for(int i=2; i<=106; i+=2){
					if(i % 10 != 0)
						Console.Write(i + " ");
				}
			}
		}
