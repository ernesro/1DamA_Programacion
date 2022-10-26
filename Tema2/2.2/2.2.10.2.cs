/*(2.2.10.2) Crea un programa que pida al usuario dos números y escriba su mínimo 
común múltiplo (pista: una solución lenta pero sencilla es probar con un "for" 
todos los números a partir del mayor de ambos, de forma creciente; cuando 
encuentres un número que sea múltiplo de ambos, interrumpes la búsqueda con 
"break").
*/

	using System;
		class Ej_2_2_10_2{
			static void Main(){
				
				int num1, num2, i, mcd, mcm;
				
				Console.WriteLine("Introduce el primer numero");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo numero");
				num2 = Convert.ToInt32(Console.ReadLine());
				
				int menor = num2 > num1 ? num1 : num2;

				for(i = menor; i > 0; i--){
					if(num1 % i == 0 && num2 % i == 0){
						mcd=i;
						break;
					}
				}
				mcd=i;
				mcm = (num1 * num2) / mcd;
				Console.Write("El minimo comun multiplo es el " + mcm);
			}
		}
