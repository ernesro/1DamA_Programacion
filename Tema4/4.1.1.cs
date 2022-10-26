using System;
class Ej_4_1_1_1{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 4.1.1.1 ");
			Console.WriteLine();
			Console.WriteLine("Opcion 2 --> Ej 4.1.1.2");
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
		double[] num = new double[4];
		double media = 0;
		for(int i = 0 ; i < 4 ; i++)
			num[i] = pedirInt();
		media = (num[0] + num[1] + num[2] + num[3])/4;
		Console.WriteLine("La media de: " + num[0] + ", " + num[1] + ", " + num[2] + ", " + num[3] + " = " + media);
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		double[] num = new double[5];
		for(int i = 0 ; i < 5 ; i++)
			num[i] = pedirDouble();
		for(int i = 4 ; i >= 0 ; i--){
			Console.Write(" " + num[i] + " ");
			if( i > 0)
				Console.Write("-");
		}
		Console.WriteLine();
		Console.WriteLine("---------------------------------");
	}
	
	static int pedirInt(){
		bool ok = false; int num = 0;
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
	
	static double pedirDouble(){
		bool ok = false; double num = 0;
		do{
			try{
				Console.Write("Introduce un numero: ");
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
		Console.Write("Introduce una cadena: ");
		cadena = Console.ReadLine();
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
