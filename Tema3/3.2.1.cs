
	using System;
		
		class Ej_3_2_1{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.1.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.1.2");
							Console.WriteLine("Opcion 0 -----------> Salir");
							Console.Write("Que ejercicio quieres ver ? : ");
							num= Convert.ToByte(Console.ReadLine());
							
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
			(3.2.1.1) Crea un programa que muestre el resultado de dividir 3 entre 4, primero
			usando números enteros y luego usando números de coma flotante.
			*/
			
			static void Opc1(){
				
				int result = 3/4;
				float result2 = 3/4f;
				
				Console.WriteLine("3 / 4 = " + result);
				Console.WriteLine("3 / 4 = " + result2);
				
				Console.WriteLine();
			}
			
			/*
			(3.2.1.2) ¿Cuál sería el resultado de las siguientes operaciones, usando números 
			reales? a=5; a/=2; a+=1; a*=3; --a;
			*/
			
			static void Opc2(){
				
				float a=5;
				
				Console.WriteLine(a/=2);
				Console.WriteLine(a+=1);
				Console.WriteLine(a*=3);
				Console.WriteLine(--a);
				
				Console.WriteLine();
			}
		}		

		

