	using System;
		
		class Ej_3_2_2{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.2.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.2.2");
							Console.WriteLine("Opcion 0 -----------> Salir");
							Console.Write("Que ejercicio quieres ver ? : ");
							num= Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine();
							
							if(num >= 0 && num <3)
								verdad = 1;
						}
						
						catch(Exception){
							Console.WriteLine("Error. Introduce un numero valido.");
						}
						
					}while(verdad == 0);
						
					switch(num){
						
						case 1:Opc1();
							break;
						case 2:Opc2();
							break;
						case 0 :break;
						
					}
				}while(num != 0);
			}
			
			
			/*
			(3.2.2.1) Crea un programa que muestre el resultado de dividir 13 entre 6 usando 
			números enteros, luego usando números de coma flotante de simple precisión y 
			luego con números de doble precisión.
			*/
			
			static void Opc1(){
				
				float result1 = 13/6f;
				double result2 = 13/6f;
				
				Console.WriteLine("13 / 6 = " + result1);
				Console.WriteLine("13 / 6 = " + result2);
				
				Console.WriteLine();
			}
			
			/*
			(3.2.2.2) Calcula el área de un círculo, dado su radio, que será un número entero
			(área = pi * radio al cuadrado). Usa datos de doble precisión
			*/
			
			static void Opc2(){
				
				int verdad = 0;
				float radio =0;
				float pi = 3.141592653589793238f;
				
				do{
			
						try{
							Console.WriteLine("Introduce el radio de una circunferencia : ");
							radio= Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine();
							
							if(radio >= 0)
								verdad = 1;
						}
						
						catch(Exception){
							Console.WriteLine("Error. Introduce un numero valido.");
						}
						
					}while(verdad == 0);
					
					float area = pi * (radio*radio);
					
					Console.WriteLine("El area del circulo es : " + area);
				
				Console.WriteLine();
			}
		}		

		

