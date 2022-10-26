/*(2.2.9.1) Crea un programa que pida un número al usuario y escriba los múltiplos 
de 9 que haya entre 1 y ese número. Debes usar llaves en todas las estructuras de 
control, aunque sólo incluyan una sentencia.*/

	using System;
		class Ej_2_2_9_1{
			static void Main(){
				
				int num;
				
				Console.WriteLine("Introduce un numero");
				num = Convert.ToInt32(Console.ReadLine());
				
				for(int i = 1; i <= num; i++){
					if(i % 9 == 0){
					Console.WriteLine("El "+ i + " es multiplo de 9");
					}
				}
			}
		}
