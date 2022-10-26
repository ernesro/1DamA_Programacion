
	using System;
		
		class Ej_3_1_2{
		
			static void Main(){
				
				// MENU
				
				int opcion=0, verdad=0;
				
				do{
				
					Console.WriteLine("Opcion 1 --> Ej 3.1.2.1 ");
					Console.WriteLine();
					Console.WriteLine("Opcion 2 --> Ej 3.1.2.2");
					Console.WriteLine();
					Console.WriteLine("Opcion 3 --> Ej 3.1.2.3");
					Console.WriteLine();
					Console.WriteLine("Opcion 0 --> SALIR");
					Console.WriteLine();
					
					
					do{
						try{
							Console.Write("Que Ejercicio quieres ver ? : ");
							opcion = Convert.ToInt32(Console.ReadLine());
							
							if(opcion >= 0 && opcion <5)
								verdad=1;
							else{
								Console.WriteLine("Error: No es un numero valido");
								verdad=0;
							}
						}
					
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
							verdad=0;
						}
					
					}while(verdad==0);
					
				switch(opcion){
					case 0: 
						break;	
						
					case 1:Opc1();
						break;	
						
					case 2:Opc2();
						break;	
						
					case 3:Opc3();
						break;	
				}
				
				}while(opcion !=0);
			}
	
	
	
			/*
			(3.1.2.1) Pregunta al usuario su edad, que se guardará en un "byte". A 
			continuación, le deberás decir que no aparenta tantos años (por ejemplo, "No 
			aparentas 20 años").
			*/
	
			static void Opc1(){
				
				byte edad=0;
				int verdad = 0;
				
				do{
					try{
						Console.Write("Introduce tu edad : ");
						edad = Convert.ToByte(Console.ReadLine());
						
						if(edad >0 && edad < 150)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				Console.WriteLine("No aparentas " + edad + " años.");
				Console.WriteLine("---------------------------------");
			}
			
			
			/*
			(3.1.2.2) Pide al usuario dos números de dos cifras ("byte"), calcula su 
			multiplicación, que se deberá guardar en un "int", y muestra el resultado en 
			pantalla.
			 */
			
			static void Opc2(){
				
				int verdad=0, resultado;
				byte num1=0, num2=0;
				
				do{
					try{
						Console.Write("Introduce el primer numero de solo 2 cifras: ");
						num1 = Convert.ToByte(Console.ReadLine());
						Console.Write("Introduce el segunto numero de solo 2 cifras: ");
						num2 = Convert.ToByte(Console.ReadLine());
						
						if(num1 >= 0 && num1 < 100 && num2 >= 0 && num2 < 100)
							verdad=1;
					}
					
					catch(Exception){
						Console.WriteLine("Error: Has introducido un numero que no es valido");
					}
					
					}while(verdad==0);
					
					resultado = Convert.ToInt32(num1) * Convert.ToInt32(num2);
					Console.WriteLine(num1 + " * " + num2 + " = " + resultado);		
					Console.WriteLine("---------------------------------");
			}
			
			
			/*
			(3.1.2.3) Pide al usuario dos números enteros largos ("long") y muestra su suma, 
			su resta y su producto.
			 */
			
			static void Opc3(){
				
				int verdad=0;
				long num1=0, num2=0;
				
					do{
						try{
							Console.Write("Introduce el primer numero: ");
							num1 = Convert.ToInt64(Console.ReadLine());
							Console.Write("Introduce el segunto numero: ");
							num2 = Convert.ToInt64(Console.ReadLine());
							verdad=1;
						}
						
						catch(Exception){
							Console.WriteLine("Error: Has introducido un numero que no es valido");
						}

					}while(verdad==0);
				
					Console.WriteLine(num1 + " + " + num2 + " = " + (num1+num2));
					Console.WriteLine(num1 + " - " + num2 + " = " + (num1-num2));
					Console.WriteLine(num1 + " * " + num2 + " = " + (num1*num2));
					Console.WriteLine("---------------------------------");
			}
		}		

		
