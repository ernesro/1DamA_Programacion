/* (2.1.5.8) Crea un programa que pida al usuario dos números enteros y diga "Uno
de los números es positivo", "Los dos números son positivos" o bien "Ninguno de
los números es positivo", según corresponda.*/	
	using System;
	
		class Ej_02_01_05_08
		{
			static void Main()
			{ 
				int num1, num2;
				
				Console.WriteLine("Introduzca el primer numero");
				num1 = Convert.ToInt32(System.Console.ReadLine());
				Console.WriteLine("Introduzca el primer numero");
				num2 = Convert.ToInt32(System.Console.ReadLine());
				
				if(((num1 % 2 == 0) && (num2 % 2 != 0)) || ((num1 % 2 != 0) && (num2 % 2 == 0))){
					Console.WriteLine("Solo uno es par");
				}
				else if((num1 % 2 == 0) && (num2 % 2 == 0)){
					Console.WriteLine("Ambos son par");
				}
					else{	 
						Console.WriteLine("Ninguno es par");
					}	
			}
		} 
