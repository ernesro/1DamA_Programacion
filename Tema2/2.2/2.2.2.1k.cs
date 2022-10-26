/*(2.2.2.1) Crea un programa que pida números positivos al usuario, y vaya
calculando y mostrando la suma de todos ellos (terminará cuando se teclea un
número negativo o cero). */
	using System;
	
		class Ej_02_02_02_01
		{
			static void Main()
			{ 
				int num, suma = 0;
				
				do{
					Console.WriteLine("Introduzca un numero");
					num = Convert.ToInt32(System.Console.ReadLine());
					suma = suma + num;
					if(num > 0)
					Console.WriteLine("Su suma es " + suma);
				}while (num > 0);
			}
		} 
