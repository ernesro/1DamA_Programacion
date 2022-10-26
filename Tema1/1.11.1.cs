	
	// Esto acorta las ordenes, ya no hace falta poner "System."
	using System;
	
		class Ej_01_11_01
		{
			static void Main()
			{
				int primerNumero;
				int segundoNumero;
				int producto;
			
					Console.WriteLine("Introduce el primer número");
					primerNumero = Convert.ToInt32(Console.ReadLine());
					
					Console.WriteLine("Introduce el segundo número");
					segundoNumero = Convert.ToInt32(Console.ReadLine());
					
					producto = primerNumero * segundoNumero;
					Console.WriteLine("El producto de {0} y {1} es {2}", primerNumero, segundoNumero, producto);
			}
		} 
