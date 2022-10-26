	
	class Ej_01_10_01
	{
		static void Main()
		{
			int primerNumero;
			int segundoNumero;
			int producto;
			
				System.Console.WriteLine("Introduce el primer número");
				primerNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				System.Console.WriteLine("Introduce el segundo número");
				segundoNumero = System.Convert.ToInt32(System.Console.ReadLine());
					
				producto = primerNumero + segundoNumero;
				System.Console.WriteLine("El producto de {0} y {1} es {2}", primerNumero, segundoNumero, producto);
		}
	} 
