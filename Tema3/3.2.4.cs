	
	using System;
		
		class Ej_3_2_4{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.4.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.4.2");
							Console.WriteLine("Opcion 0 -----------> Salir");
							Console.Write("Que ejercicio quieres ver ? : ");
							num= Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine();
							
							if(num >= 0 && num <8)
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

						
					}
				}while(num != 0);
			}
			
			
			/*
			(3.2.4.1) Crea un programa que calcule la raíz cuadrada del número que 
			introduzca el usuario. La raíz se deberá calcular como "double", pero el resultado 
			se mostrará como "float". (Recuerda: como viste al hacer el ejercicio 3.2.3.3, la raíz 
			cuadrada de un número x se calcula con Math.Sqrt(x)).
			*/
			
			static void Opc1(){
				
				int verdad=0;
				double num=0, raiz;
				float resultado;
				
				do{
					try{
						Console.Write("Introduce un numero para calcular su raiz : ");
						num = Convert.ToDouble(Console.ReadLine());
						
						if(num >=0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				raiz = Math.Sqrt(num);
				resultado = (float) raiz;
				
				Console.WriteLine("La raiz cuadrada de  " + num + " es igual a " + resultado);
				Console.WriteLine("---------------------------------");
			}
						
			/*
			(3.2.4.2) Crea una nueva versión del programa que calcula una aproximación de PI 
			mediante la expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 (...) con tantos 
			términos como indique el usuario. Debes hacer todas las operaciones con 
			"double", pero mostrar el resultado como "float".
			*/
			
			static void Opc2(){
				
				int  verdad=0;
				double num=0, pi=0;
				float resultadof;
				
				do{
					try{
						Console.Write("Introduce las iteraciones: ");
						num = Convert.ToDouble(Console.ReadLine());
					}
					catch(FormatException){
						Console.WriteLine("Error. Número introducido no valido: ");
					}
					if(num > 0)
						verdad=1;
				}while(verdad==0);
				
				double fraccion=1;
				for(int i=1; i<=num; i++){
					if(i%2 == 0)
						pi = pi - (1/fraccion);
					else
						pi = pi + (1/fraccion);
					fraccion+=2;
					}
					
					pi = pi * 4;
					
					resultadof = (float) pi;
				Console.WriteLine("pi = " + resultadof);
				Console.WriteLine("---------------------------------");
			}
		}		

		

