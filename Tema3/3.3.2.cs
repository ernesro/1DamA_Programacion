/*
(3.3.2.1) Crea un programa que pida al usuario que teclee cuatro letras y las 
muestre en pantalla juntas, pero en orden inverso, y entre comillas dobles. Por 
ejemplo si las letras que se teclean son a, l, o, h, escribiría "hola". 
 */
using System;
class Ej_3_3_2{
	static void Main(){
		char letra1, letra2, letra3, letra4;
		Console.WriteLine("Introduce 4 letras: ");
		letra1 = Convert.ToChar(Console.ReadLine());
		letra2 = Convert.ToChar(Console.ReadLine());
		letra3 = Convert.ToChar(Console.ReadLine());
		letra4 = Convert.ToChar(Console.ReadLine());
		Console.WriteLine("\"" + letra4 + letra3 + letra2 + letra1 + "\"");
	}
}
