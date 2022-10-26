	/*((2.4.1) Crea un programa que cuente cuantas veces aparece la letra 'a' en una 
frase que teclee el usuario, utilizando "foreach"..*/
	using System;
		class Ej_2_4_1{
			static void Main(){
			
				Console.Write("Escribe algo y contare las letras 'a': "); 
				string nombre = Console.ReadLine();
				int num=0;
				
				foreach(char letra in nombre){
					if(letra == 'a' || letra == 'A')
						num++;
				}
				Console.WriteLine(num); 
			}
		}
