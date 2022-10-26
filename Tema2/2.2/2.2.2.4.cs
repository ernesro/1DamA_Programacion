/*(2.2.2.4) Crea un programa que pida al usuario su identificador y su contraseña
(ambos numéricos), y no le permita seguir hasta que introduzca como
identificador "1234" y como contraseña "1111".*/
	using System;
	
		class Ej_02_02_02_04
		{
			static void Main()
			{ 
				int ident, contra;
				
				do{
					Console.WriteLine("Introduce el identificador");
					ident = Convert.ToInt32(Console.ReadLine());
					Console.WriteLine("Introduce la contraseña");
					contra = Convert.ToInt32(Console.ReadLine());
				}while (ident != 1234 || contra != 1111);
			}
		} 
