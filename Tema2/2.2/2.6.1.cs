	/*(2.6.1) Crea un programa que pregunte al usuario su edad y su año de nacimiento. 
Si la edad que introduce no es un número válido, mostrará un mensaje de aviso y 
se detendrá. Lo mismo ocurrirá si el año de nacimiento no es un número válido:*/
	using System;
		class Ej_2_6_1{
			static void Main(){
			
				int edad, anio;
									
				try{
				
					Console.Write("Edad ? : "); 
					edad = Convert.ToInt32(Console.ReadLine());
					
					Console.Write("Año de nacimiento ? : "); 
					anio = Convert.ToInt32(Console.ReadLine());
						
				}
				catch (FormatException){
					
					Console.WriteLine("No es un número válido");
 
				}
			}
		}
