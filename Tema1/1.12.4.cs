	
	// Esto acorta las ordenes, ya no hace falta poner "System."
	using System;
	
		class Ej_01_12_03
		{
			static void Main()
			{ 
				float C, K, F;
			
				Console.WriteLine("Que temperatura quieres convertir a kelvin y a fahreinheit");
				C = Convert.ToInt32(System.Console.ReadLine());
				
				K = C +273;				//Convertimos grados celsius en kelvins
				F= C * 18 / 10 + 32;	//Convertimos los celsius en fahrenheit
				
				Console.Write(C);
				Console.Write("ºC convertidos en kelvins son ");
				Console.Write(K);
				Console.Write(" K y en fahrenheit son ");
				Console.Write(F);
				Console.Write("ºF");
					
			}
		} 
