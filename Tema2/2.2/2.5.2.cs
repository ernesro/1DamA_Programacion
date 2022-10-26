	/*((2.5.2) Crea un programa en el que el usuario deba adivinar un número del 1 al 
100 (prefijado en el programa). En cada pasada deberá avisar de si se ha pasado o 
se ha quedado corto.*/
	using System;
		class Ej_2_5_2{
			static void Main(){
			
				int num1 = 15, num2;
				
				Console.Write("Adivina el número del 1 al 100:	"); 
				
				do{
					num2 =Convert.ToInt32(Console.ReadLine());
					if(num2>num1)
						Console.WriteLine("Te pasaste");
					if(num2<num1)
						Console.WriteLine("Te quedaste corto");
				}while(num2 != num1);
				
				Console.WriteLine("Acertaste!");
			}
		}
