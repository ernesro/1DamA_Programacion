	/*(2.2.11.3) Crea una versión alternativa del ejercicio 2.2.11.1, que no utilice 
"continue" sino el "if" contrario..*/
	using System;
		class Ej_2_2_11_3{
			static void Main(){
			
				for(int i=20; i>=10; i--){
					if(i != 13)
						Console.Write(i + " ");
				}
			}
		}
