	/*(2.5.3) Haz un programa que dé al usuario la oportunidad de adivinar un número 
del 1 al 100 (prefijado en el programa) en un máximo de 6 intentos. En cada 
pasada deberá avisar de si se ha pasado o se ha quedado corto.*/
	using System;
		class Ej_2_5_3{
			static void Main(){
			
				int num1 = 15, num2=0, intentos = 0;
				
				Console.Write("Adivina el número del 1 al 100:	"); 
				
				while(num2 != num1 && intentos != 6){
					num2 =Convert.ToInt32(Console.ReadLine());
					if(num2>num1)
						Console.WriteLine("Te pasaste");
					if(num2<num1)
						Console.WriteLine("Te quedaste corto");
					intentos++;
				}
				
				if(num2 == num1)
				Console.WriteLine("Acertaste!");
				else
				Console.WriteLine("Te quedaste sin intentos :(");
			}
		}
