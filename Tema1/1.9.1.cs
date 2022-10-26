	
	class Ej_01_09_01
	{
		static void Main()
		{
			int metros = 30000;								//El valor en metros que queremos convertir a millas
			int milla = 1609;									// 1 milla son 1609 metros
			int conversion = metros / milla;             // Almacenamos la coversion de metros a millas
			
			System.Console.WriteLine("La conversion de {0} metros es igual a {1} millas " ,metros , conversion);
			
		}	

	}
