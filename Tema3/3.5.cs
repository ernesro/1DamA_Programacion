using System;
class Ej_3_5{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 3.5.1 ");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 2 --> Ej 3.5.2");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 3 --> Ej 3.5.3");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 4 --> Ej 3.5.4");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 5 --> Ej 3.5.5");
			Console.WriteLine();                         
			Console.WriteLine("Opcion 6 --> Ej 3.5.6");
			Console.WriteLine();
			Console.WriteLine("Opcion 0 --> SALIR");
			Console.WriteLine();
			do{
				try{
					Console.Write("Que Ejercicio quieres ver ? : ");
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion >= 0 && opcion <7)
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
				case 3:Opc3();break;
				case 4:Opc4();break;
				case 5:Opc5();break;
				case 6:Opc6();break;	
			}
		}while(opcion !=0);
	}

	static void Opc1(){
		/*
		(3.5.1) Crea un programa que use el operador condicional para dar a una variable 
		llamada "iguales" (booleana) el valor "true" si los dos números que ha tecleado el 
		usuario son iguales, o "false" si son distintos.
		*/
		int n1, n2;	
		bool iguales = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1== n2)
			iguales = true;
		else iguales = false;
		if(iguales)
			Console.WriteLine("iguales");
		else Console.WriteLine("distintos");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(3.5.2) Crea una versión alternativa del ejercicio 3.5.1, que use "if" en vez del 
		operador condicional 
		 */
		int n1, n2;	
		bool iguales = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1== n2)
			iguales = true;
		else iguales = false;
		if(iguales)
			Console.WriteLine("iguales");
		else Console.WriteLine("distintos");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc3(){	
		/*
		(3.5.3) Crea una versión alternativa del ejercicio 3.5.1, que asigne directamente el 
		valor al booleano a partir de una comparación. 
		 */	
		int n1, n2;	
		bool iguales = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1== n2)
			iguales = true;
		else iguales = false;
		if(iguales)
			Console.WriteLine("iguales");
		else Console.WriteLine("distintos");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc4(){
		/*
		(3.5.4) Crea un programa que use el operador condicional para dar a una variable 
		llamada "ambosPares" (booleana) el valor "true" si dos números introducidos por 
		el usuario son pares, o "false" si alguno es impar. 
		 */
		int n1, n2;	
		bool ambosPares = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1 % 2 == 0 && n2 % 2 == 0)
			ambosPares = true;
		else ambosPares = false;
		if(ambosPares)
			Console.WriteLine("ambos pares");
		else Console.WriteLine("uno o los 2 impares");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc5(){
		/*
		(3.5.5) Crea una versión alternativa del ejercicio 3.5.4, que use "if" en vez del 
		operador condicional 
		 */	
		int n1, n2;	
		bool ambosPares = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1 % 2 == 0 && n2 % 2 == 0)
			ambosPares = true;
		else ambosPares = false;
		if(ambosPares)
			Console.WriteLine("ambos pares");
		else Console.WriteLine("uno o los 2 impares");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc6(){
		/*
		(3.5.6) Crea una versión alternativa del ejercicio 3.5.5, que asigne directamente el 
		valor al booleano a partir de una comparación. 
		 */
		int n1, n2;	
		bool ambosPares = true;
		n1 = pedirInt(); 
		n2 = pedirInt(); 
		if(n1 % 2 == 0 && n2 % 2 == 0)
			ambosPares = true;
		else ambosPares = false;
		if(ambosPares)
			Console.WriteLine("ambos pares");
		else Console.WriteLine("uno o los 2 impares");
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
