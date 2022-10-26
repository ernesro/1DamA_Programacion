using System;
class Ej_3_3_1{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 3.3.1.1 ");
			Console.WriteLine();
			Console.WriteLine("Opcion 2 --> Ej 3.3.1.2");
			Console.WriteLine();
			Console.WriteLine("Opcion 3 --> Ej 3.3.1.3");
			Console.WriteLine();
			Console.WriteLine("Opcion 0 --> SALIR");
			Console.WriteLine();
			do{
				try{
					Console.Write("Que Ejercicio quieres ver ? : ");
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion >= 0 && opcion <4)
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
			}
		}while(opcion !=0);
	}

	static void Opc1(){	
		/*
		(3.3.1.1) Crea un programa que pida una letra al usuario y diga si se trata de una vocal.
		*/	
		char letra;
		letra = pedirChar();
		switch(letra){
			case 'a':Console.WriteLine("es vocal");break;
			case 'e':Console.WriteLine("es vocal");break;
			case 'i':Console.WriteLine("es vocal");break;
			case 'o':Console.WriteLine("es vocal");break;
			case 'u':Console.WriteLine("es vocal");break;
			case 'A':Console.WriteLine("es vocal");break;
			case 'E':Console.WriteLine("es vocal");break;
			case 'I':Console.WriteLine("es vocal");break;
			case 'O':Console.WriteLine("es vocal");break;
			case 'U':Console.WriteLine("es vocal");break;
			default:Console.WriteLine("es consonante");break;
		}	
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){		
		/*
		 (3.3.1.2) Crea un programa que muestre letras alternas (una sí y una no) entre la 
		que teclee el usuario y la "z". Por ejemplo, si el usuario introduce una "a", se escribirá "aceg...".
		 */
		char letra;
		letra = pedirChar();
		for(int i = letra ; i <= 'z'; i+=2){
			Console.Write(letra);
			letra++;
			letra++;
		}
		Console.WriteLine();
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc3(){	
		/*
		(3.3.1.3) Crea un programa que pida al usuario el ancho (por ejemplo, 4) y el alto 
		(por ejemplo, 3) y una letra (por ejemplo, X) y escriba un rectángulo formado por 
		esa cantidad de letras:
		*/	
		int num; char letra;
		num = pedirInt();
		letra = pedirChar();
		for(int i = num; i > 0; i--){
			for(int j = num; j >= 0; j--){
			Console.Write(letra);
			}
		Console.WriteLine();
		}
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
