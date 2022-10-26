

	using System;
		
		class Ej_obligatiorio{
		
			static void Main(){
				
				int i, j, alto, ancho=0;
			/*	
				Console.WriteLine("Introduce el alto");
				alto = Convert.ToInt32(Console.ReadLine());

				for (i = 1; i <= alto; i++){
					for (j = alto - i; j > 0; j--){
						Console.Write(" ");
					}
					for (j = 1; j < i; j++){
						Console.Write("**");
					}
					Console.WriteLine("*");
				}
				*/
				
				
					
				do{
					
					try{
						Console.WriteLine("Introduce el ancho, tiene que ser un numero mayor o igual a 3 e impar");
						ancho = Convert.ToInt32(Console.ReadLine());
					}
					catch (FormatException){
						Console.Write("No es un numero valido, ");
					}
					
				}while(ancho < 3 || ancho % 2 == 0);
				
			
			}	
		}		

		
