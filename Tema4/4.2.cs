using System;
class Ej_4_2{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 4.2.1 ");
			Console.WriteLine();
			Console.WriteLine("Opcion 2 --> Ej 4.2.2");
			Console.WriteLine();
			Console.WriteLine("Opcion 3 --> Ej 4.2.3");
			Console.WriteLine();
			Console.WriteLine("Opcion 4 --> Ej 4.2.4");
			Console.WriteLine();
			Console.WriteLine("Opcion 5 --> Ej 4.2.5");
			Console.WriteLine();
			Console.WriteLine("Opcion 6 --> Ej 4.2.6");
			Console.WriteLine();
			Console.WriteLine("Opcion 7 --> Ej 4.2.7");
			Console.WriteLine();
			Console.WriteLine("Opcion 0 --> SALIR");
			Console.WriteLine();
			do{
				try{
					Console.Write("Que Ejercicio quieres ver ? : ");
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion >= 0 && opcion <8)
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
		(4.2.1) Un programa que pida al usuario dos bloques de 10 números enteros 
		(usando un array de dos dimensiones). Después deberá mostrar el mayor dato 
		que se ha introducido en cada uno de ellos
		*/
		int[,] num = new int[2,10];
		int numMay = 0;
		for(int i = 0 ; i < 2 ; i++){
			for(int j = 0 ; j < 10 ; j++){
				Console.Write("Introduce el numero (" + (i) + "," + (j) + ") : ");
				num[i,j] = pedirInt();
				if(i == 0 && j == 0) numMay = num[0,0];
				numMay = numMay > num[i,j] ? numMay : num[i,j];
			}
		}
		Console.WriteLine("El numero mayor es : " + numMay);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(4.2.2) Un programa que pida al usuario dos bloques de 6 cadenas de texto. 
		Después pedirá al usuario una nueva cadena y comprobará si aparece en alguno 
		de los dos bloques de información anteriores. 
		*/
		string[,] nombre = new string[2,6];
		string nomPreg;
		bool esta = false;
		
		for(int i = 0 ; i < 2 ; i++){
			for(int j = 0 ; j < 6 ; j++){
				Console.Write("Introduce el nombre (" + (i) + "," + (j) + ") : ");
				nombre[i,j] = pedirString();
			}
		}
		Console.Write("Que nombre quieres buscar en la lista? : ");
		nomPreg = pedirString();
		for(int i = 0 ; i < 2 ; i++){
			for(int j = 0 ; j < 6 ; j++){
				if(nombre[i,j] == nomPreg)
					esta = true;
			}
		}
		if(esta)
			Console.WriteLine("El nombre " + nomPreg + " está en la lista.");
		else
			Console.WriteLine("El nombre " + nomPreg + " no está en la lista.");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc3(){
	/*
	(4.2.3) Un programa que pregunte al usuario el tamaño que tendrán dos bloques 
	de números enteros (por ejemplo, uno de 10 elementos y otro de 12). Luego 
	pedirá los datos para ambos bloques de datos. Finalmente deberá mostrar el 
	mayor dato que se ha introducido en cada uno de ellos.
	*/
		int[][] num = new int[2][];
		int max0, max1, numMay = 0;

		Console.Write("Que cantidad de datos quieres introducier en el primer bloque? : ");
		max0 = pedirInt();
		num[0] = new int [max0];
		Console.Write("Que cantidad de datos quieres introducier en el segundo bloque? : ");
		max1 = pedirInt();
		num[1] = new int [max1];
		
		for(int i = 0 ; i < num.Length ; i++){
			for(int j = 0 ; j < num[i].Length ; j++){
				Console.Write("Introduce el numero (" + (i) + "," + (j) + ") : ");
				num[i][j] = pedirInt();
				if(i == 0 && j == 0) numMay = num[0][0];
				numMay = numMay > num[i][j] ? numMay : num[i][j];
			}
		}
		Console.WriteLine("El numero mayor es : " + numMay);
		Console.WriteLine("---------------------------------");
	}
	
	static int pedirInt(){
		bool ok = false; int num = 0;
		do{
			try{
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
				num = Convert.ToDouble(Console.ReadLine());
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
		bool ok = false;
		do{
			cadena = Convert.ToString(Console.ReadLine());
			if(cadena != "")
				ok=true;
			else Console.Write("Error: Vuelse a introducirlo : ");
		}while(!ok);
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
