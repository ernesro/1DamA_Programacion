using System;
class Ej_3_4{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 3.4.1 ");
			Console.WriteLine();
			Console.WriteLine("Opcion 2 --> Ej 3.4.2 ");
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
		(3.4.1) Crea un programa que pida al usuario su nombre, y le diga "Hola" si se 
		llama "Juan", o bien le diga "No te conozco" si teclea otro nombre.
		*/
		string nombre;
		Console.WriteLine("Introduce un nombre :");
		nombre = Convert.ToString(Console.ReadLine()); 
		if(nombre != "Juan")
			Console.WriteLine("No te conozco.");
		else
			Console.WriteLine("Hola " + nombre);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(3.4.2) Crea un programa que pida al usuario un nombre y una contraseña. La 
		contraseña se debe introducir dos veces. Si las dos contraseñas no son iguales, se 
		avisará al usuario y se le volverán a pedir las dos contraseñas, tantas veces como 
		sea necesario hasta que coincidan. 
		*/
		string nombre, contra1, contra2;
		int intentos = 0;
		Console.WriteLine("Introduce un nombre :");
		nombre = pedirString();
		do{
			Console.WriteLine("Introduce una contarseña: ");
			contra1 = pedirString();
			Console.WriteLine("Vuelve a introducir la contraseña: ");
			contra2 = pedirString();
			intentos++;
		}while(contra1 != contra2 && intentos < 2);
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
	
	static string pedirString(){
		string cadena;
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
