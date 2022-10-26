	
	using System;
		
		class Ej_3_2_6{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.6.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.6.2");
							Console.WriteLine("Opcion 3 -----------> 3.2.6.3");
							Console.WriteLine("Opcion 4 -----------> 3.2.6.4");
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
			(3.2.6.1) Crea un programa que pida números (en base 10) al usuario y muestre su 
			equivalente en sistema binario y en hexadecimal. Debe repetirse hasta que el 
			usuario introduzca el número 0.
			*/
			
			static void Opc1(){
				
				int num=1, verdad=0;
				
				do{
					do{
						try{
							Console.Write("Introduce un numero : ");
							num = Convert.ToInt32(Console.ReadLine());
							
							if(num >= 0)
								verdad = 1;
							else
								Console.WriteLine("Error: No es un numero valido");
						}
						
						catch(FormatException){
							Console.WriteLine("Error: No es un numero valido");
						}
					}while(verdad == 0);
					
					if(num == 0)
						break;
							
					Console.WriteLine("En binario es " + Convert.ToString(num,2));
					Console.WriteLine("En hexadecimal es " + Convert.ToString(num,16));
					Console.WriteLine();
					
				}while(num != 0);
				
				Console.WriteLine("---------------------------------");

			}
			
			
			/*
			(3.2.6.2) Crea un programa que pida al usuario la cantidad de rojo (por ejemplo, 
			255), verde (por ejemplo, 160) y azul (por ejemplo, 0) que tiene un color, y que 
			muestre ese color RGB en notación hexadecimal (por ejemplo, FFA000).
			*/
			
			static void Opc2(){
				
				int verdad=0;
				byte rojo=0, verde=0, azul=0; 
				
				do{
					try{
						Console.Write("Introduce la cantidad de rojo : ");
						rojo = Convert.ToByte(Console.ReadLine());
						
						if(rojo >= 0)
							verdad = 1;
						else
						Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(Exception){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				verdad = 0;
				do{
					try{
						Console.Write("Introduce una cantidad de verde: ");
						verde = Convert.ToByte(Console.ReadLine());
						
						if(verde >= 0)
							verdad = 1;
						else
						Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(Exception){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				verdad = 0;
				do{
					try{
						Console.Write("Introduce una cantidad de azul : ");
						azul = Convert.ToByte(Console.ReadLine());
						
						if(azul >= 0)
							verdad = 1;
						else
						Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(Exception){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				Console.Write("#");
				if(rojo>=0 && rojo<16)
					Console.Write("0");
				Console.Write(Convert.ToString(rojo,16));
				if(verde>=0 && verde<16)
					Console.Write("0");
				Console.Write(Convert.ToString(verde,16));
				if(azul>=0 && azul<16)
					Console.Write("0");
				Console.Write(Convert.ToString(azul,16));
				
				Console.WriteLine();
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.6.3) Crea un programa para mostrar los números del 0 a 255 en hexadecimal, 
			en 16 filas de 16 columnas cada una (la primera fila contendrá los números del 0 al 
			15 –decimal-, la segunda del 16 al 31 –decimal- y así sucesivamente).
			*/
			
			static void Opc3(){
			
				int j=0;
				
				for(int i=0 ; i<256 ; i++){
					Console.Write(Convert.ToString(i,16) + "   ");
					j++;
					if(i<16)
						Console.Write(" ");
					if(j==16){
						Console.WriteLine();
						j=0;
					}
				}
			
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.6.4) Crea un programa que pida números binarios al usuario y muestre su 
			equivalente en sistema hexadecimal y en decimal. Debe repetirse hasta que el 
			usuario introduzca la palabra "fin"
			*/
			
			static void Opc4(){
				
				string bin;
				do{
					
					Console.Write("Introduce numero binario : ");
					bin = Console.ReadLine();
					
					if(bin =="fin")
						break;
					
					int dec = Convert.ToInt32(bin, 2);
					Console.WriteLine("En decimal : "+dec);
					Console.WriteLine("En hexadecimal : "+Convert.ToString(dec,16));
					Console.WriteLine("En octal : "+Convert.ToString(dec,8));

				}while(bin != "fin");
				
				Console.WriteLine("---------------------------------");
			}
		}		

		

