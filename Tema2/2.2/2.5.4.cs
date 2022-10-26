	/*(2.5.4) Crea un programa que pida un número al usuario y diga si es primo 
(divisible sólo entre 1 y él mismo).*/
	using System;
		class Ej_2_5_4{
			static void Main(){
			
				int num, primo = 0;
				
				Console.Write("Escribe un número : "); 
				num = Convert.ToInt32(Console.ReadLine());
				
				for(int i=2; i<num; i++){
					if(num % i ==0){
					primo = 1;
				}
			
				}
				if(primo == 0 )
					Console.Write("es primo"); 	
				else
					Console.Write("no es primo "); 
			}
		}
