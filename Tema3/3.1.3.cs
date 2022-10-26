
	using System;
		
		class Ej_3_1_3{
		
			static void Main(){
				
				// MENU
				
				int opcion=0, verdad=0;
				
				do{
				
					Console.WriteLine("Opcion 1 --> Ej 3.1.3.1 ");
					Console.WriteLine();
					Console.WriteLine("Opcion 2 --> Ej 3.1.3.2");
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
			(3.1.3.1) Crea un programa que use tres variables enteras x,y,z. Sus valores 
			iniciales serán 15, -10, 2.147.483.647. Se deberá incrementar el valor de estas 
			variables. ¿Qué valores esperas que se obtengan? Contrástalo con el resultado 
			obtenido por el programa.
			*/
	
			static void Opc1(){
				
				
				int x = 15, y = -10;
				long z = 2147483647;
				
				x++;
				y++;
				z++;	
				
				Console.WriteLine("x=" + x + " y=" + y + " z=" + z);
				
				Console.WriteLine("---------------------------------");
			}
			
			
			/*
			(3.1.3.2) ¿Cuál sería el resultado de las siguientes operaciones? a=5; b=++a; c=a++; 
			b=b*5; a=a*2; Calcúlalo a mano y luego crea un programa que lo resuelva, para 
			ver si habías hallado la solución correcta.
			 */
			
			static void Opc2(){
				
				int a = 5, b, c;
				
				b = ++a;
				Console.WriteLine("' b = ++a'  = " + b);
				c = a++;
				Console.WriteLine(" 'c = a++'  = " + c);
				b = b*5;
				Console.WriteLine(" 'b = b*5'  = " + b);
				a = a*2;
				Console.WriteLine(" 'a = a*2'  = " + a);
				
				Console.WriteLine("---------------------------------");
			}
		}		

		
