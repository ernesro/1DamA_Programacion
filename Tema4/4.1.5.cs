using System;
class Ej_4_1_5{
	static void Main(){
		int opcion=0, verdad=0;	// MENU
		do{
			Console.WriteLine("Opcion 1 --> Ej 4.1.5.1 ");
			Console.WriteLine();
			Console.WriteLine("Opcion 2 --> Ej 4.1.5.2");
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
		(4.1.5.1) Crea un programa que contenga un array con los nombres de los meses 
		del año. El usuario podrá elegir entre verlos en orden natural (de Enero a 
		Diciembre) o en orden inverso (de Diciembre a Enero). Usa constantes para el 
		valor máximo del array en ambos recorridos.
		*/
		const int NUMMES = 12;
		string[] meses = new string[NUMMES] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio"
			 , "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		char orden;
			 
		Console.Write("Orden Natural (N) o Inverso (I): " );
		orden = pedirChar();
		
		switch(orden){
			case 'N':
				for(int i = 0 ; i < NUMMES ; i++){
					Console.WriteLine(i+1 + (". ") + meses[i]);
				}
				break;
			case 'I':
				for(int i = NUMMES-1 ; i  >= 0 ; i--){
					Console.WriteLine(i+1 + (". ") + meses[i]);
				}
				break;
		}	
		Console.WriteLine("---------------------------------");
	}
	
	static void Opc2(){
		/*
		(4.1.5.2) Crea una nueva versión del ejercicio 4.1.5.1, usando ".Length" en vez de 
		una constante.
		*/
		string[] meses = new string[12] {"Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio"
			 , "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre"};
		char orden;
			 
		Console.Write("Orden Natural (N) o Inverso (I): " );
		orden = pedirChar();
		
		switch(orden){
			case 'N':
				for(int i = 0 ; i < meses.Length ; i++){
					Console.WriteLine(i+1 + (". ") + meses[i]);
				}
				break;
			case 'I':
				for(int i = meses.Length-1 ; i  >= 0 ; i--){
					Console.WriteLine(i+1 + (". ") + meses[i]);
				}
				break;
		}	
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
		Console.Write("Introduce una cadena: ");
		cadena = Convert.ToString(Console.ReadLine());
		return cadena;
	}
	
	static char pedirChar(){
		char letra;
		do{
			letra = Convert.ToChar(Console.ReadLine());
		}while(letra != 'N' && letra != 'I');
		return letra;
	}
}		
