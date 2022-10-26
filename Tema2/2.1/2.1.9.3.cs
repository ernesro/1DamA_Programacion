/*(2.1.9.3) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de una vocal, una cifra numérica o una consonante, usando "switch".*/
	using System;
	
		class Ej_02_01_09_03
		{
			static void Main()
			{ 
				char caracter;
				
				Console.WriteLine("Introduzca ");
				caracter = Convert.ToChar(System.Console.ReadLine());
				
				switch (caracter)
				{
					case '1':
					case '2':
					case '3':
					case '4':
					case '5':
					case '6':
					case '7':
					case '8':
					case '9':
					case '0':Console.WriteLine("Numero");
						break;
					case 'a':
					case 'e':
					case 'i':
					case 'o':
					case 'u':Console.WriteLine("vocal");
						break;
					default: Console.WriteLine("consonante");
						break;
				}
			}
		} 
