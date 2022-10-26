/*
 (4.1.4.5) Crea un programa que prepare espacio para un máximo de 10 nombres. 
Deberá mostrar al usuario un menú que le permita realizar las siguientes 
operaciones: 
Introducción a la programación con C#, por Nacho Cabanes
- Añadir un dato al final de los ya existentes.
- Insertar un dato en una cierta posición (como ya se ha comentado, los que 
queden detrás deberán desplazarse "hacia el final" para dejarle hueco); por 
ejemplo, si el array contiene "hola", "adiós" y se pide insertar "bien" en la 
segunda posición, el array pasará a contener "hola", "bien", "adiós".
- Borrar el dato que hay en una cierta posición (como se ha visto, lo que 
estaban detrás deberán desplazarse "hacia el principio" para que no haya 
huecos); por ejemplo, si el array contiene "hola", "bien", "adiós" y se pide 
borrar el dato de la segunda posición, el array pasará a contener "hola", 
"adiós"
- Mostrar los datos que contiene el array.
- Salir del programa.
 */
using System;
class Ej_4_1_4{
	static void Main(){
		int menu = 0, cantidad = 0, posic = 0;
		string[] nombres = new string[10];
		
		do{
			do{
				Console.WriteLine("1.- Añadir al final.");
				Console.WriteLine("2.- Insertar dato a una cierta posicion.");
				Console.WriteLine("3.- Borrar dato.");
				Console.WriteLine("4.- Mostrar los datos.");
				Console.WriteLine("0.- Finalizar.?");
				Console.Write("Que vas a hacer ? : ");
				menu = pedirInt();
				Console.WriteLine();
				
				switch(menu){
					case 1:	//Añadir un dato
						if(cantidad < 10){
							Console.Write("Introduce un nombre : ");
							nombres[cantidad] = pedirString();
							cantidad++;
						}
						else Console.WriteLine("La tabla está llena.");
						 Console.WriteLine();
					break;
					
					case 2:	//Insertar dato en cierta posicion 
						if(cantidad < 10){
							Console.Write("En que posicion quieres añadir el dato? : ");
							posic = pedirInt();
							for(int i = cantidad ; i > posic ; i--){
								nombres[i] = nombres[i-1];
							}
							Console.Write("Que nombre quieres introducir? : ");
							nombres[posic] = pedirString();
							cantidad++;
						}
						else Console.WriteLine("La tabla está llena.");
						 Console.WriteLine();
					break;
					
					case 3: 	//Borrar
						if(cantidad >= 0)
							Console.Write("En que posicion quieres borrar el dato : ");
							posic = pedirInt();
							for(int i = posic ; i < cantidad-1; i++)
								nombres[i] = nombres[i+1];
								Console.Write(posic);
						if(cantidad > 0)
							cantidad --;
					break;
					
					case 4:	//Mostrar los datos
						for(int i = 0 ; i < cantidad; i++)
							Console.WriteLine(nombres[i]);
							 Console.WriteLine();
					break;
					
					case 0: break;
				}
			}while(menu > 5 || menu < 0);
		}while(menu != 0);
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
	
	static string pedirString(){
		string cadena;
		cadena = Convert.ToString(Console.ReadLine());
		return cadena;
	}
}		

