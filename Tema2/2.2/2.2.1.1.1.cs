/*(2.2.1.1.1) Crea un programa que pida al usuario su contraseña (numérica).
Deberá terminar cuando introduzca como contraseña el número 1111, pero
volvérsela a pedir tantas veces como sea necesario.*/	
	using System;
	
		class Ej_02_02_01_01_01
		{
			static void Main()
			{ 
				int contra = 0;
				
				while (contra != 1111){
				
					Console.WriteLine("Introduce la contraseña");
					contra = Convert.ToInt32(Console.ReadLine());
				}
			}
		} 
