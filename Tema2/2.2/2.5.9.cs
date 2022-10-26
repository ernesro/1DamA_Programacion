	/*(2.5.9) Crea un programa que devuelva el cambio de una compra, utilizando 
monedas (o billetes) del mayor valor posible. Supondremos que tenemos una 
cantidad ilimitada de monedas (o billetes) de 100, 50, 20, 10, 5, 2 y 1, y que no hay 
decimales. La ejecución podría ser algo como::*/
	using System;
		class Ej_2_5_9{
			static void Main(){
			
				int precio, pagado=0;
				
				Console.Write("Precio ? : "); 
				precio = Convert.ToInt32(Console.ReadLine());
				
				do{
					
					Console.Write("Pagado ? : "); 
					pagado = Convert.ToInt32(Console.ReadLine());
					
					if(pagado<precio)
						Console.WriteLine("Introduce un precio adecuado.");
						
				}while(pagado<precio);
				
				int cambio = pagado - precio;
				
				Console.Write("Su cambio es de : ");
				
				do{
					
					if(cambio >= 100){
						cambio-=100;
						Console.Write("100 ");
					}
					
					else if (cambio >= 50){
							cambio-=50;
							Console.Write("50 ");
					}
					
					else if (cambio >= 20){
						cambio-=20;
						Console.Write("20 ");
					}
					
					else if (cambio >= 10){
						cambio-=10;
						Console.Write("10 ");
					}
					
					else if (cambio >= 5){
						cambio-=5;
						Console.Write("5 ");
					}
					
					else if (cambio >= 2){
						cambio-=2;
						Console.Write("2 ");
					}
					
					else if (cambio >= 1){
					Console.Write("1 ");
						cambio-=1;
					}
					
				}while(cambio > 0);
			}
		}
