	/*
	(3.1.6.1) Crea un programa que pida al número del 0 al 255 y muestre el resultado 
	de hacer un XOR con un cierto dato prefijado (y también en ese rango). 
	Comprueba que la operación es reversible (por ejemplo, 131 xor 5 = 134, y 134 xor 
	5 = 131).
	 */
	

	using System;
		
		class Ej_3_1_6{
		
			static void Main(){
				
				byte num=0, xor = 5;
				int verdad=0;
				
				do{
					try{
						Console.Write("Introduce un numerodel 0 al 255 : ");
						num= Convert.ToByte(Console.ReadLine());
						
						if(num >= 0 && num <=255)
							verdad = 1;
					}
					
					catch(Exception){
						Console.WriteLine("Error. Introduce un numero valido.");
					}
					
					if(verdad==1)
					Console.WriteLine(num + " xor " + xor + " = " + (num^xor));
					
				}while(verdad == 0);
			}
		}		

		
