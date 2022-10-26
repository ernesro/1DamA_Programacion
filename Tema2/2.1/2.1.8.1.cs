/*(2.1.8.1) Crea un programa que use el operador condicional para mostrar el valor
absoluto de un número de la siguiente forma: si el número es positivo, se
mostrará tal cual; si es negativo, se mostrará cambiado de signo.*/	
	using System;
	
		class Ej_02_01_08_01
		{
			static void Main()
			{ 
				int numero;
				
				Console.WriteLine("Introduce un número");
				numero = Convert.ToInt32(Console.ReadLine());
				
				Console.WriteLine(numero >= 0 ? numero : numero * -1);
			}
		} 
