using System;
class Ej_4_1_3{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 4.1.3.1 ");
			Console.WriteLine("Opcion 2 --> Ej 4.1.3.2");
			Console.WriteLine("Opcion 3 --> Ej 4.1.3.3");
			Console.WriteLine("Opcion 4 --> Ej 4.1.3.4");
			Console.WriteLine("Opcion 5 --> Ej 4.1.3.5");
			Console.WriteLine("Opcion 6 --> Ej 4.1.3.6");
			Console.WriteLine("Opcion 7 --> Ej 4.1.3.7");
			Console.WriteLine("Opcion 8 --> Ej 4.1.3.8");
			Console.WriteLine("Opcion 9 --> Ej 4.1.3.9");
			Console.WriteLine("Opcion 10 --> Ej 4.1.3.10");
			Console.WriteLine("Opcion 11 --> Ej 4.1.3.11");
			Console.WriteLine("Opcion 0 --> SALIR");
			Console.WriteLine();
			do{
				try{
					Console.Write("Que Ejercicio quieres ver ? : ");
					opcion = Convert.ToInt32(Console.ReadLine());
					if(opcion >= 0 && opcion <12)
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
				case 7:Opc7();break;
				case 8:Opc8();break;
				case 9:Opc9();break;
				case 10:Opc10();break;
				case 11:Opc11();break;	
			}
		}while(opcion !=0);
	}

	static void Opc1(){
		/*
		(4.1.3.1) Crea un programa que pida al usuario 6 números enteros cortos y luego 
		los muestre en orden inverso (pista: usa un array para almacenarlos y "for" para 
		mostrarlos).
		*/
		int[] num = new int[6];
		for(int i = 0 ; i < 6 ; i++)
			num[i] = pedirInt();
		for(int i = 5 ; i >= 0 ; i--)
			Console.Write(num[i] + " ");
		Console.WriteLine();
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(4.1.3.2) Crea un programa que pregunte al usuario cuántos números enteros va a 
		introducir (por ejemplo, 10), le pida todos esos números, los guarde en un array y 
		finalmente calcule y muestre la media de esos números.
		*/
		int cantNum = 0;
		double media = 0.0, suma = 0;
		Console.Write("Intoroduce la cantidad de numeros :");
		cantNum = pedirInt();
		double[] num = new double[cantNum];
		
		for(int i = 0 ; i < cantNum ; i++){
			Console.Write("Intoroduce un numero :");
			num[i] = pedirInt();
		}
		for(int i = 0 ; i < cantNum ; i++)
			suma = suma + num[i];
		media = suma / cantNum;
		Console.WriteLine("La media es : " + media);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc3(){
		/*
		(4.1.3.3) Un programa que pida al usuario 10 reales de doble precisión, calcule su 
		media y luego muestre los que están por encima de la media. 
		*/
		double media = 0.0, suma = 0;
		double[] num = new double[10];
		
		for(int i = 0 ; i < 10 ; i++){
			Console.Write("Intoroduce un numero :");
			num[i] = pedirInt();
		}
		for(int i = 0 ; i < 10 ; i++)
			suma = suma + num[i];
		media = suma / 10;
		Console.WriteLine("La media es : " + media);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc4(){	
		/*
		(4.1.3.4) Un programa que almacene en una tabla el número de días que tiene 
		cada mes (de un año no bisiesto), pida al usuario que le indique un mes (ej. 2 para 
		febrero) y un día (ej. el día 15) y diga qué número de día es dentro del año (por
		ejemplo, el 15 de febrero sería el día número 46, el 31 de diciembre sería el día 
		365).
		*/	
		int[] diasMes = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int mes, dia, suma = 0;
		do{
			Console.Write("Introduce un mes Enero = 1 ...  Diciembre = 12 :  ");
			mes = pedirInt();
		}while(mes < 1 || mes > 12);
		do{
			Console.Write("Introduce un dia del mes : ");
			dia = pedirInt();
		}while(dia < 1 || dia > diasMes[mes-1]);
		if(mes > 0){
		for(int i = 0 ; i < mes-1 ; i++)
			suma = suma + diasMes[i];
		}
		suma = suma + dia;
		Console.WriteLine("Es el dia : " + suma);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc5(){
		/*
		(4.1.3.5) A partir del ejercicio anterior, crea otro que pida al usuario que le indique 
		la fecha, formada por día (1 al 31) y el mes (1=enero, 12=diciembre), y como 
		respuesta muestre en pantalla el número de días que quedan hasta final de año.
		*/
		int[] diasMes = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		int mes, dia, suma = 0;
		do{
			Console.Write("Introduce un mes Enero = 1 ...  Diciembre = 12 :  ");
			mes = pedirInt();
		}while(mes < 1 || mes > 12);
		do{
			Console.Write("Introduce un dia del mes : ");
			dia = pedirInt();
		}while(dia < 1 || dia > diasMes[mes-1]);
		if(mes > 0){
		for(int i = 0 ; i < mes-1 ; i++)
			suma = suma + diasMes[i];
		}
		suma = suma + dia;
		Console.WriteLine("Es el dia : " + suma + " del año.");
		Console.WriteLine("Faltan " + (365-suma) + " dias.");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc6(){
		/*
		(4.1.3.6) Un programa que pida 10 nombres y los memorice (pista: esta vez se 
		trata de un array de "string"). Después deberá pedir que se teclee un nombre y 
		dirá si se encuentra o no entre los 10 que se han tecleado antes. Volverá a pedir 
		otro nombre y a decir si se encuentra entre ellos, y así sucesivamente hasta que se 
		teclee "fin". En el siguiente apartado verás detalles de cómo hacer ese tipo de 
		búsquedas.
		*/
		string[] nombresA = new string[10];
		string nombre = "";
		for(int i = 0 ; i < 10 ; i++){
			Console.WriteLine("Introduce el nombre " + (i+1));
			nombresA[i] = pedirString();
		}
		do{
			Console.WriteLine("Que nombre quieres comprobar? :");
			nombre = pedirString();
			if(nombre == "fin")
				break;
			for(int i = 0 ; i < 10 ; i++){
				if(nombre == nombresA[i]){
					Console.WriteLine(nombre + " se encuentra en la base de datos.");
					break;
				}
				if(i == 9 && nombre != nombresA[9])
				Console.WriteLine(nombre + " no se encuentra en la base de datos.");
			}
		}while(nombre != "fin");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc7(){ 
		/*
		 (4.1.3.7) Un programa que prepare espacio para guardar un máximo de 100 
		nombres. El usuario deberá ir introduciendo un nombre cada vez, hasta que se 
		pulse Intro sin teclear nada, momento en el que dejarán de pedirse más nombres 
		y se mostrará en pantalla la lista de los nombres que se han introducido.
		*/
		string[] nombresA = new string[100];
		int contador = 0;
		for(int i = 0 ; i < 100 ; i++){
			Console.WriteLine("Introduce el nombre " + (i+1));
			nombresA[i] = pedirString();
		if(nombresA[i] == "")
			break;
		contador++;
		}
			for(int i = 0 ; i < contador ; i++){
					Console.WriteLine((i+1) + ".-" + nombresA[i]);
			}
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc8(){
		/*
		(4.1.3.8) Un programa que reserve espacio para un vector de 3 componentes, pida 
		al usuario valores para dichas componentes (por ejemplo [2, -5, 7]) y muestre su 
		módulo (la raíz cuadrada de la suma de sus componentes al cuadrado; por 
		ejemplo, para [2, -5, 7] el resultado sería la raíz cuadrada de 78, aproximadamente 
		8,83).
		*/
		int[] vector = new int[3];
		double modulo = 0;
		for(int i = 0 ; i < 3 ; i++){
			Console.WriteLine("Introduce el componente " + (i+1) + " del vector ");
			vector[i] = pedirInt();
			modulo = modulo + Math.Pow(vector[i], 2);
		}
		modulo = Math.Sqrt(modulo);
		Console.Write("El modulo del vector [ ");
		for(int i = 0 ; i < 3 ; i++)
			Console.Write(vector[i] + " ");
		Console.WriteLine("] = " + modulo);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc9(){		
		/*
		(4.1.3.9) Un programa que reserve espacio para dos vectores de 3 componentes, 
		pida al usuario sus valores y calcule la suma de ambos vectores (su primera 
		componente será x1+y1, la segunda será x2+y2 y así sucesivamente).
		*/
		int[] vectorA = new int[3];
		int[] vectorB = new int[3];
		int[] suma = new int[3];
		
		for(int i = 0 ; i < 3 ; i++){
			Console.Write("Introduce el componente " + (i+1) + " del vectorA ");
			vectorA[i] = pedirInt();
			Console.Write("Introduce el componente " + (i+1) + " del vectorB ");
			vectorB[i] = pedirInt();
			suma[i] = vectorA[i] + vectorB[i];
		}
		Console.Write("El vector resultante es = [ ");
		for(int i = 0 ; i < 3 ; i++)
			Console.Write(suma[i] + " ");
		Console.WriteLine("] ");
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc10(){		
		/*
		(4.1.3.10) Un programa que reserve espacio para dos vectores de 3 componentes, 
		pida al usuario sus valores y calcule su producto escalar (x1·y1+ x2·y2 + z1·z2).
		*/
		int[] vectorA = new int[3];
		int[] vectorB = new int[3];
		int pdEscalar = 0;
		
		for(int i = 0 ; i < 3 ; i++){
			Console.Write("Introduce el componente " + (i+1) + " del vectorA ");
			vectorA[i] = pedirInt();
			Console.Write("Introduce el componente " + (i+1) + " del vectorB ");
			vectorB[i] = pedirInt();
			pdEscalar = pdEscalar + (vectorA[i] * vectorB[i]);
		}
		Console.WriteLine("El producto escalar de estos vectores es : " + pdEscalar);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc11(){	
		/*
		(4.1.3.11) Un programa que pida al usuario 4 números enteros y calcule (y 
		muestre) cuál es el mayor de ellos. Nota: para calcular el mayor valor de un array, 
		hay que comparar cada uno de los valores que tiene almacenados el array con el 
		que hasta ese momento es el máximo provisional. El valor inicial de este máximo 
		provisional no debería ser cero (porque el resultado sería incorrecto si todos los 
		números son negativos), sino el primer elemento del array. Si no lo consigues, en 
		el próximo apartado tienes más detalles sobre cómo resolver este problema. 
		*/
		int[] num = new int[4];
		int numMay = 0;
		for(int i = 0 ; i < 4 ; i++){
			Console.Write("Introduce el numero " + (i+1) + " : ");
			num[i] = pedirInt();
			numMay = num[0];
			numMay = (numMay > num[i]) ? numMay : num[i];
		}
		Console.WriteLine("El numero mayor es " + numMay);
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
