/* (2.1.3.1) Crea un programa que multiplique dos números enteros de la siguiente
forma: pedirá al usuario un primer número entero. Si el número que se que teclee
es 0, escribirá en pantalla "El producto de 0 por cualquier número es 0". Si se ha
tecleado un número distinto de cero, se pedirá al usuario un segundo número y se
mostrará el producto de ambos.*/	
	using System;
	
		class Ej_02_01_03_01
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				
				if (num1 == 0){	 
					Console.WriteLine("Multiplicar por 0 es cero");
				}
				else{	 
					Console.WriteLine("Introduce otro numero");
					num2 = Convert.ToInt32(System.Console.ReadLine());
					Console.WriteLine(" El resultado de " + num1 + " * " + num2 + " es " + num1*num2);
				}
				
			}
		} 
