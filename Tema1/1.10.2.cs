	
	class Ej_01_10_02
	{
		static void Main()
		{
			int primerNumero;
			int segundoNumero;
			int division;
			
				System.Console.WriteLine("Introduce el primer número");
				primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				System.Console.WriteLine("Introduce el segundo número");
				segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				division = primerNumero / segundoNumero;
				System.Console.WriteLine("La division de {0} y {1} es igual a {2}", primerNumero, segundoNumero, division);
		}
	} 
