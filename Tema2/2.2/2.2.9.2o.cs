/*(2.2.9.2) Crea un programa que pida al usuario dos números y escriba sus 
divisores comunes. Debes usar llaves en todas las estructuras de control, aunque 
sólo incluyan una sentencia.*/

	using System;
		class Ej_2_2_9_2{
			static void Main(){
				
				int num1, num2;
				
				Console.WriteLine("Introduce el primer numero");
				num1 = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("Introduce el segundo numero");
				num2 = Convert.ToInt32(Console.ReadLine());
				
				int mayor =num1 > num2 ? num1 : num2;
			
				Console.WriteLine("El {0} y el {1} tienen en comun el divisor", num1, num2);
				for(int i = 1; i <= mayor; i++){
					if(num1 % i == 0 && num2 % i == 0){
					Console.Write(i + " - ");
					}
				}
			}
		}
