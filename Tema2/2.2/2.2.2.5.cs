/*(2.2.2.5) Crea un programa que pida al usuario su identificador y su contraseña, y
no le permita seguir hasta que introduzca como nombre "Pedro" y como
contraseña "Peter".*/
	using System;
	
		class Ej_02_02_02_05
		{
			static void Main()
			{ 
				string ident, contra;
				
				do{
					Console.WriteLine("Introduce el identificador");
					ident = (Console.ReadLine());
					Console.WriteLine("Introduce la contraseña");
					contra = (Console.ReadLine());
				}while (ident != "Pedro" || contra != "Peter");
			}
		} 
