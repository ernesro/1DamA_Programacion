	/*(2.2.12.1) Crea un programa que escriba los números del 100 al 200, separados 
por un espacio, sin avanzar de línea, usando "for". En la siguiente línea, vuelve a 
escribirlos usando "while".*/
	using System;
		class Ej_2_2_12_1{
			static void Main(){
			
				 int a, b=100;
				
				for(a=100; a<=200; a++){
					Console.Write(a + " ");
				}
				Console.WriteLine("");
				while(b <= 200){
					Console.Write(b + " ");
					b++;
				}
			}
		}
