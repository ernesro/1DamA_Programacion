/* (2.1.9.7) Pide al usuario el número de un día de la semana y escribe su nombre
(por ejemplo, si escribe 2, la respuesta debería ser "Martes"). Hazlo primero con
"if" y después con "switch"..*/	
	using System;
	
		class Ej_02_01_09_07
		{
			static void Main()
			{ 
				int num;
				
				Console.WriteLine("Introduzca un numero(con if)");
				num = Convert.ToInt32(Console.ReadLine());
				
				if(num == 1)
					Console.WriteLine("Lunes");
				if(num == 2)
					Console.WriteLine("Martes");
				if(num == 3)
					Console.WriteLine("Miercoles");
				if(num == 4)
					Console.WriteLine("Jueves");
				if(num == 5)
					Console.WriteLine("Viernes");
				if(num == 6)
					Console.WriteLine("Sabado");
				if(num == 7)
					Console.WriteLine("Domingo");
					
				Console.WriteLine("Introduzca un numero(con switch)");
				num = Convert.ToInt32(Console.ReadLine());
				
				switch(num)
				{	
				case 1:Console.WriteLine("Lunes");
					break;
				case 2:Console.WriteLine("Martes");
					break;
				case 3:Console.WriteLine("Miercoles");
					break;
				case 4:Console.WriteLine("Jueves");
					break;
				case 5:Console.WriteLine("Viernes");
					break;
				case 6:Console.WriteLine("Sabado");
					break;
				case 7:Console.WriteLine("Domingo");
					break;
	
				}
			}
		} 
