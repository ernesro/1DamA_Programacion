	
	class Ej_01_10_03
	{
		static void Main()
		{
			int primerNumero;
			int segundoNumero;
			int tercerNumero;
			int suma;
			
				System.Console.WriteLine("Introduce el primer número");
				primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				System.Console.WriteLine("Introduce el segundo número");
				segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
				
				System.Console.WriteLine("Introduce el tercer número");
				tercerNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				suma = primerNumero + segundoNumero + tercerNumero;
;
				System.Console.WriteLine("La suma de {0} + {1} + {2} es igual a {3}", primerNumero, segundoNumero, tercerNumero, suma);
		}
	} 
