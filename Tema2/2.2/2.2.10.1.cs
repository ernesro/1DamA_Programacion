/*(2.2.10.1) Crea un programa que pida al usuario dos números y escriba su máximo 
común divisor (pista: una solución lenta pero sencilla es probar con un "for" todos 
los números descendiendo a partir del menor de ambos, hasta llegar a 1; cuando 
encuentres un número que sea divisor de ambos, interrumpe la búsqueda con 
"break").
*/

	using System;
		class Ej_2_2_10_1{
			static void Main(){
				
				int num1, num2, i;
				
				Console.WriteLine("Introduce el primer numero");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo numero");
				num2 = Convert.ToInt32(Console.ReadLine());
				
				int menor = num2 > num1 ? num1 : num2;

				for(i = menor; i > 0; i--){
					if(num1 % i == 0 && num2 % i == 0){
						break;
					}
				}
				Console.Write("El maximo comun divisor es el " + i);
			}
		}
