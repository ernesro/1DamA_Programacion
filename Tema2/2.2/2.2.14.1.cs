	/*((2.2.14.1) Crea un programa que escriba los números del 1 al 10, separados por un 
espacio, sin avanzar de línea. No puedes usar "for", ni "while", ni "do..while", sólo 
"if" y "goto".*/
	using System;
		class Ej_2_2_14_1{
			static void Main(){
			
				int num =1;
				
				repetir:
				Console.Write(" prueba "+num+ " ");
				if(num <= 10){ 
					Console.Write(num + " ");
					num++;
					goto repetir;
				}
				
			}
		}
