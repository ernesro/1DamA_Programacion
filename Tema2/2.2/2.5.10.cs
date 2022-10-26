	/*(2.5.9) Crea un programa que devuelva el cambio de una compra, utilizando 
monedas (o billetes) del mayor valor posible. Supondremos que tenemos una 
cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay 
decimales. La ejecución podría ser algo como::*/
	using System;
		class Ej_2_5_10{
			static void Main(){
			
				int num;
				
				do{
					
					Console.Write("Introduce un numero menor o igual que 9 : "); 
					num = Convert.ToInt32(Console.ReadLine());
						
				}while(num > 9);
				
					for(int i = num; i > 0; i--){
						for(int j = 1; j <= num; j++)
							Console.Write(j);
						Console.WriteLine();
					}
			}
		}
