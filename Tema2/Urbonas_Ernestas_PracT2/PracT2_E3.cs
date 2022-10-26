/*
Urbonas, Ernestas
Practica Evaluable  Tema 2
Ejercicio 3		si
*/

	using System;
		
		class PracT2_E3{
		
			static void Main(){
				
				int i, j, alto=0;
				
				//Comprobamos que ponen un numero valido
					
				try{	
					
					Console.Write("Introduce el alto, tiene que ser impar, mayor que nueve y menor de 26 : ");
					alto = Convert.ToInt32(Console.ReadLine());
		
					Console.WriteLine();
				}
					
				catch(FormatException){
					
					Console.WriteLine("Error: Valor introducido no valido.");
				}
				
				//Si se cumple la condicion no dibujamos nada
				
				if(alto < 9 || alto >= 26 || alto%2 == 0){	
					Console.Write("Valor introducido en alto no es valido.");		
				}
				
				//Si no se culple lo dibujamos
				
				else{
				
					for (i = 0; i < alto; i++){
						
						for(j = 0; j < alto; j++){
							
							if(i == j || j == 0 || i == 0 || j == alto-1 || i == alto-1 || (i+j) == alto-1)
								Console.Write("* ");
								
							else
								Console.Write("  ");
						}
						Console.WriteLine();
					}
				}
			}	
		}		

		
