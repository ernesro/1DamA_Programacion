	/*(2.5.8) Crea un programa que "dibuje" un triángulo creciente, alineado a la 
derecha, con la altura que indique el usuario. Por ejemplo, si el usuario dice que 
desea 4 caracteres de alto, el triángulo sería así::*/
	using System;
		class Ej_2_5_8{
			static void Main(){
			
				int alto;
				
				Console.Write("Escribe el alto: "); 
				alto = Convert.ToInt32(Console.ReadLine());
				
				for(int i=0; i<alto; i++){
					for(int j=i; j<alto-1; j++)
						Console.Write("0");
					for(int j=0; j<=i; j++)
						Console.Write("*");
				Console.WriteLine();
				}
			}
		}
