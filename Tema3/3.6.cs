using System;
class Ej_3_6{
	const double METROS = 1609.344; 
	enum mesesAnio { ENERO, FEBRERO, MARZO, ABRIL, MAYO, JUNIO, JULIO, AGOSTO, SEPTIEMBRE, OCTUBRE,
			NOVIEMBRE, DICIEMBRE};
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 3.6.1 ");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 2 --> Ej 3.6.2");
			Console.WriteLine();                 
			Console.WriteLine("Opcion 0 --> SALIR");
			Console.WriteLine();
			do{
				try{
					Console.Write("Que Ejercicio quieres ver ? : ");
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion >= 0 && opcion <3)
						verdad=1;
					else{
						Console.WriteLine("Error: No es un numero valido");
						verdad=0;
					}
				}
				catch(FormatException){
					Console.WriteLine("Error: No es un numero valido");
					verdad=0;
				}
			}while(verdad==0);

			switch(opcion){
				case 0: break;	
				case 1:Opc1();break;	
				case 2:Opc2();break;	
			}
		}while(opcion !=0);
	}

	static void Opc1(){
		/*
		(3.6.1) Crea un programa que permita convertir de millas a metros. El valor 
		necesario para la conversión debe estar almacenado en una constante. 
		 */
		int millas;
		double result;	
		millas = pedirInt(); 
		result = METROS*millas;
		Console.WriteLine(result + " metros");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(3.6.2) Crea una enumeración para los meses del año, desde ENERO (con valor 1) 
		hasta DICIEMBRE (con valor 12). Muestra el valor numérico correspondiente a 
		OCTUBRE. 
		 */
		const int ENERO = 1, FEBRERO = 2, MARZO = 3, ABRIL = 4, MAYO = 5, JUNIO = 6, JULIO = 7, AGOSTO = 8,
		SEPTIEMBRE = 9, OCTUBRE = 10, NOVIEMBRE = 11, DICIEMBRE = 12;
		Console.WriteLine(OCTUBRE);
		Console.WriteLine("---------------------------------");
	}
	
	static int pedirInt(){
		bool ok = false; int num = 0;
		do{
			try{
				Console.Write("Introduce el primer numero: ");
				num = Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException){
				Console.WriteLine("Error: Has introducido un numero que no es valido");
			}
		}while(!ok);
		return num;
	}
	
	static double pedirDouble(){
		bool ok = false; double num = 0;
		do{
			try{
				Console.Write("Introduce un numero: ");
				num = Convert.ToInt32(Console.ReadLine());
				ok=true;
			}
			catch(FormatException){
				Console.WriteLine("Error: Has introducido un numero que no es valido");
			}
		}while(!ok);
		return num;
	}
	
	static string pedirString(){
		string cadena;
		Console.WriteLine("Error: Has introducido un numero que no es valido");
		cadena = Convert.ToString(Console.ReadLine());
		return cadena;
	}
	
	static char pedirChar(){
		char letra;
		do{
			Console.Write("Introduce una letra: ");
			letra = Convert.ToChar(Console.ReadLine());
		}while(letra < 'A' && letra < 'z');
		return letra;
	}
}		
