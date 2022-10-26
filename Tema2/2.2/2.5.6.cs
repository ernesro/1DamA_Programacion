	/*((2.5.6) Crea un programa que calcule un número elevado a otro, usando 
multiplicaciones sucesivas*/
	using System;
		class Ej_2_5_6{
			static void Main(){
			
				int num, expo, total;
				
				Console.Write("Escribe un número: "); 
				num = Convert.ToInt32(Console.ReadLine());
				Console.Write(num + " ^ ");
				expo=Convert.ToInt32(Console.ReadLine());
				total = num;
				
				for(int i=expo; i>1; i--){
					total = total * num;
				}
				Console.Write(num + "^"+expo+" = "+total);
			}
		}
