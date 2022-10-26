/*
(3.7.1) Crea un programa que pida al usuario una cantidad de kilómetros y 
muestre su equivalencia en millas. El valor de conversión debe estar en una 
variable definida con "var". 
 */
using System;
class Ej_3_7{
	const double METROS = 1609.344;
	static void Main(){
	double kilom;
	var result = 0.0;
	kilom = pedirInt();
	kilom = kilom*1000;
	result = kilom/METROS;
	Console.WriteLine(result);
	}
	
	static int pedirInt(){
		bool ok = false; int num = 0;
		do{
			try{
				Console.Write("Introduce kilometros: ");
				num = Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException){
				Console.WriteLine("Error: Has introducido un numero que no es valido");
			}
		}while(!ok);
		return num;
	}
}		
