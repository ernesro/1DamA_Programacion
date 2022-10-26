/* (2.1.9.8) Pide al usuario el un número de mes y escribe su nombre (por ejemplo, si
escribe 3, la respuesta debería ser "Marzo"), usando "switch"...*/	
	using System;
	
		class Ej_02_01_09_08
		{
			static void Main()
			{ 
				int num;
				
				Console.WriteLine("Introduzca un numero(con if)");
				num = Convert.ToInt32(Console.ReadLine());
				
				if(num == 1)
					Console.WriteLine("Enero");
				if(num == 2)
					Console.WriteLine("Febrero");
				if(num == 3)
					Console.WriteLine("Marzo");
				if(num == 4)
					Console.WriteLine("Abril");
				if(num == 5)
					Console.WriteLine("Mayo");
				if(num == 6)
					Console.WriteLine("Junio");
				if(num == 7)
					Console.WriteLine("Julio");
				if(num == 8)
					Console.WriteLine("Agosto");
				if(num == 9)
					Console.WriteLine("Septiembre");
				if(num == 10)
					Console.WriteLine("Octubre");
				if(num == 11)
					Console.WriteLine("Noviembre");
				if(num == 12)
					Console.WriteLine("Diciembre");
					
				Console.WriteLine("Introduzca un numero(con switch)");
				num = Convert.ToInt32(Console.ReadLine());
				
				switch(num)
				{	
				case 1:Console.WriteLine("Enero");
					break;
				case 2:Console.WriteLine("Febrero");
					break;
				case 3:Console.WriteLine("Marzo");
					break;
				case 4:Console.WriteLine("Abril");
					break;
				case 5:Console.WriteLine("Mayo");
					break;
				case 6:Console.WriteLine("Junio");
					break;
				case 7:Console.WriteLine("Julio");
					break;
				case 8:Console.WriteLine("Agosto");
					break;
				case 9:Console.WriteLine("Septiembre");
					break;
				case 10:Console.WriteLine("Octubre");
					break;
				case 11:Console.WriteLine("Noviembre");
					break;
				case 12:Console.WriteLine("Diciembre");
					break;
				}
			}
		} 
