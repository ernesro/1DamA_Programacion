/* (2.1.9.2) Crea un programa que lea una letra tecleada por el usuario y diga si se
trata de un signo de puntuación (. , ; :), una cifra numérica (del 0 al 9) o algún otro
carácter, usando "switch" (pista: necesitarás que usar un dato de tipo "char").*/	
	using System;
	
		class Ej_02_01_09_02
		{
			static void Main()
			{ 
				char caracter;
				
				Console.WriteLine("Introduzca ");
				caracter = Convert.ToChar(System.Console.ReadLine());
				
				switch (caracter)
				{
					case '1' :
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
					case '.':
					case ',':
					case ';':
					case ':':Console.WriteLine("Signo de puntuacion");
						break;
					default: Console.WriteLine("Letra");
						break;
				}
			}
		} 
