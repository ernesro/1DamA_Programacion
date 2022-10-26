	
	// Esto acorta las ordenes, ya no hace falta poner "System."
	using System;
	
		class Ej_01_12_02
		{
			static void Main()
			{
				int num;
			
					Console.WriteLine("Introduce el número para ver su tabla");
					num = Convert.ToInt32(System.Console.ReadLine());
					
					Console.Write("{0}x 0 = ", num);
					Console.WriteLine(num*0);
					Console.Write("{0}x 1 = ", num);
					Console.WriteLine(num*1);
					Console.Write("{0}x 2 = ", num);
					Console.WriteLine(num*2);
					Console.Write("{0}x 3 = ", num);
					Console.WriteLine(num*3);
					Console.Write("{0}x 4 = ", num);
					Console.WriteLine(num*4);
					Console.Write("{0}x 5 = ", num);
					Console.WriteLine(num*5);
					Console.Write("{0}x 6 = ", num);
					Console.WriteLine(num*6);
					Console.Write("{0}x 7 = ", num);
					Console.WriteLine(num*7);
					Console.Write("{0}x 8 = ", num);
					Console.WriteLine(num*8);
					Console.Write("{0}x 9 = ", num);
					Console.WriteLine(num*9);
					Console.Write("{0}x 10 = ", num);
					Console.WriteLine(num*10);
			}
		} 
