/* (2.2.1.2.3) Crea un programa calcule cuantas cifras tiene un número entero
positivo (pista: se puede hacer dividiendo varias veces entre 10)..*/
	using System;
	
		class Ej_02_02_01_02_03
		{
			static void Main()
			{ 
				int num, cont =1;
				
				Console.WriteLine("Introduzca un numero");
				num = Convert.ToInt32(System.Console.ReadLine());
				num = (num > 0) ? num : -num;
				
				while (num >= 9){
					num = num /10;
					cont++;
				}
				Console.WriteLine("Tiene " + cont + " cifras");
			}
		} 
