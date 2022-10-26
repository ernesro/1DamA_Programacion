	
	using System;
		
		class Ej_3_2_7{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.7.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.7.2");
							Console.WriteLine("Opcion 3 -----------> 3.2.7.3");
							Console.WriteLine("Opcion 4 -----------> 3.2.7.4");
							Console.WriteLine("Opcion 0 -----------> Salir");
							Console.Write("Que ejercicio quieres ver ? : ");
							num= Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine();
							
							if(num >= 0 && num <5)
								verdad = 1;
						}
						
						catch(Exception){
							Console.WriteLine("Error. Introduce un numero valido.");
						}
						
					}while(verdad == 0);
						
					switch(num){
						
						case 0 :
							break;
						case 1:Opc1();
							break;
						case 2:Opc2();
							break;
						case 3:Opc3();
							break;
						case 4:Opc4();
							break;
						
					}
				}while(num != 0);
			}
			
			
			/*
			(3.2.7.1) Crea un programa que halle (y muestre) la raíz cuadrada del número que 
			introduzca el usuario. Se repetirá hasta que introduzca 0.
			*/
			
			static void Opc1(){
				
				int num=1, verdad=0;
				
				do{
					do{
						try{
							Console.Write("Introduce un numero : ");
							num = Convert.ToInt32(Console.ReadLine());
							
							if(num >= 0)
							verdad=1;
							else
							Console.WriteLine("Error: No es un numero valido");
						}
							
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
						}
					}while(verdad == 0);
					
					if(num == 0)
						break;
							
					Console.WriteLine(Math.Sqrt(num));
					
				}while(num != 0);
				
				Console.WriteLine("---------------------------------");

			}
			
			
			/*
			(3.2.7.2) Diseña un programa que calcule cualquier raíz (de cualquier orden) de un 
			número. El usuario deberá indicar el número (por ejemplo, 2) y el índice de la raíz 
			(por ejemplo, 3 para la raíz cúbica). Pista: hallar la raíz cúbica de 2 es lo mismo que 
			elevar 2 a 1/3.
			*/
			
			static void Opc2(){
				
				float num=0, raiz=0, verdad=0; 
								
				do{
						try{
							Console.Write("Introduce un numero : ");
							num = Convert.ToInt32(Console.ReadLine());
							
							if(num >= 0)
							verdad=1;
							else
							Console.WriteLine("Error: No es un numero valido");
						}
							
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
						}
					}while(verdad == 0);
					verdad=0;
					do{
						try{
							Console.Write("Introduce el indice de la raiz : ");
							raiz = Convert.ToInt32(Console.ReadLine());
							
							if(raiz > 0)
							verdad=1;
							else
							Console.WriteLine("Error: No es un numero valido");
						}
							
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
						}
					}while(verdad == 0);
				
				raiz=(1/raiz);
				Console.WriteLine(num+"="+Math.Pow(num,raiz));
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.7.3) Crea un programa que calcule la distancia entre dos puntos (x1,y1) y (x2,y2), 
			usando la expresión d = raíz [ (x1-x2)2+ (y1-y2)2].*/
			
			static void Opc3(){
			
				int x1 = 13, x2 = 3;
				int y1 = 5, y2 = 11;
				
				double resultado = Math.Sqrt((Math.Pow((x1-y1), 2))+(Math.Pow((x2-y2), 2)));
				Console.WriteLine(resultado);
			
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.7.4) Crea un programa que pida al usuario un ángulo (en grados) y muestre su 
			seno, coseno y tangente. Recuerda que las funciones trigonométricas esperan que 
			el ángulo se indique en radianes, no en grados. La equivalencia es que 180 grados 
			= PI radianes.
			*/
			
			static void Opc4(){
				
				int num=0, verdad=0;
				
				do{
						try{
							Console.Write("Introduce grados : ");
							num = Convert.ToInt32(Console.ReadLine());
							
							if(num >= 0 && num <= 360)
							verdad=1;
							else
							Console.WriteLine("Error: No es un numero valido");
						}
							
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
						}
					}while(verdad == 0);
					
				double radianes = (num * 3.141592)/180;
				Console.WriteLine(radianes);
				Console.WriteLine("seno = "+Math.Sin(radianes));
				Console.WriteLine("coseno = "+Math.Cos(radianes));
				Console.WriteLine("tangente = "+Math.Tan(radianes));
					
				Console.WriteLine("---------------------------------");
			}
		}		

		

