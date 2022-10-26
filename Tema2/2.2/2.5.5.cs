	/*(2.5.5) Crea un programa que descomponga un número (que teclee el usuario) 
como producto de su factores primos. Por ejemplo, 60 = 2 · 2 · 3 · 5 (pista: como 
primera aproximación, puedes escribir siempre un "punto" después de cada 
Introducción a la programación con C#, por Nacho Cabanes
Revisión 2019.1 – Página 112
número y luego terminar con la cifra uno, así: 60 = 2 · 2 · 3 · 5 · 1; cuando lo 
consigas, piensa cómo harías para eliminar ese "• 1" del final).*/
	using System;
		class Ej_2_5_5{
			static void Main(){
			
				int num, div=2;
				
				Console.Write("Escribe un número : "); 
				num = Convert.ToInt32(Console.ReadLine());

				Console.Write(num + " = ");
			
				do{
					if(num % div == 0){	
						Console.Write(div);
						num = num / div;
						if(num != 1)
							Console.Write(" · ");
					}
					else
						div++;
				}while(num != 1);
			}
		}
