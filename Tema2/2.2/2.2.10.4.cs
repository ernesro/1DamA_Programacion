/*(2.2.10.4) Crea una versión alternativa del ejercicio 2.2.10.2 (mínimo común 
múltiplo) usando "while", en vez de "for" y "break".
*/

	using System;
		class Ej_2_2_10_4{
			static void Main(){
				
				int num1, num2, mcm;
				
				Console.WriteLine("Introduce el primer numero");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo numero");
				num2 = Convert.ToInt32(Console.ReadLine());
				
				int menor = num2 > num1 ? num1 : num2;
				int i = menor, mcd =0;

				while(i > 1){
					 i--;
					 if(num1 % i == 0 && num2 % i == 0){
						mcd = i;
						i=0;
					}
				}
				mcm = (num1 * num2) / mcd;
				Console.Write("El minimo comun multiplo es el " + mcm);
			}
		}
