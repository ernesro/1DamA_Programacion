	
	class Ej_01_10_04
	{
		static void Main()
		{
			float metros, conversion;
			int millaN = 1852;
			
			System.Console.WriteLine("Introduce los metros que quieres convertir a millas nauticas");
			metros = System.Convert.ToInt32(System.Console.ReadLine());
				
			conversion = metros / millaN;
			
			System.Console.WriteLine("La conversion de {0} metros es igual a {1} millas nauticas " ,metros , conversion);
			
		}	

	}
