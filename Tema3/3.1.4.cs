
	using System;
		
		class Ej_3_1_4{
		
			static void Main(){
				
				// MENU
				
				int opcion=0, verdad=0;
				
				do{
				
					Console.WriteLine("Opcion 1 --> Ej 3.1.4.1 ");
					Console.WriteLine();
					Console.WriteLine("Opcion 2 --> Ej 3.1.4.2");
					Console.WriteLine();
					Console.WriteLine("Opcion 0 --> SALIR");
					Console.WriteLine();
					
					
					do{
						try{
							Console.Write("Que Ejercicio quieres ver ? : ");
							opcion = Convert.ToInt32(Console.ReadLine());
							
							if(opcion >= 0 && opcion < 3)
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
						
				}
				
				}while(opcion !=0);
			}
	
	
	
			/*
			(3.1.4.1) Crea un programa que use tres variables x,y,z. Sus valores iniciales serán 
			15, -10, 214. Deberás incrementar el valor de estas variables en 12, usando el 
			formato abreviado. ¿Qué valores esperas que se obtengan? Contrástalo con el 
			resultado obtenido por el programa.
			*/
	
			static void Opc1(){
				
				
				int x = 15, y = -10;
				long z = 214;
				
				x+=12;
				y+=12;
				z+=12;	
				
				Console.WriteLine("x=" + x + " y=" + y + " z=" + z);
				
				Console.WriteLine("---------------------------------");
			}
			
			
			/*
			(3.1.4.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=a+2; b-=3; 
			c=-3; c*=2; ++c; a*=b; Crea un programa que te lo muestre.
			 */
			
			static void Opc2(){
				
				int a = 5, b, c;
				
				b = a+2;
				Console.WriteLine(" 'b = a+2'  = " + b);
				b -= 3;
				Console.WriteLine(" 'b -= 3'  = " + b);
				c = -3;
				Console.WriteLine(" 'c = -3'  = " + c);
				c *= 2;
				Console.WriteLine(" 'c *= 2'  = " + c);
				++c;
				Console.WriteLine(" '++c'  = " + c);
				a *= b;
				Console.WriteLine(" 'a *= b'  = " + a);
				
				Console.WriteLine("---------------------------------");
			}
		}		

		
