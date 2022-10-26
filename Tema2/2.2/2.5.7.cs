	/*((2.5.7) Crea un programa que "dibuje" un rectángulo hueco, cuyo borde sea una 
fila (o columna) de asteriscos y cuyo interior esté formado por espacios en blanco, 
con el ancho y el alto que indique el usuario. Por ejemplo, si desea anchura 4 y 
altura 3, el rectángulo sería así:*/
	using System;
		class Ej_2_5_7{
			static void Main(){
			
				int alto, ancho;
				
				Console.Write("Escribe el alto: "); 
				alto = Convert.ToInt32(Console.ReadLine());
				Console.Write("Escribe el ancho: ");
				ancho=Convert.ToInt32(Console.ReadLine());
				
				for(int i=0; i<alto; i++){
					for(int j=0; j<ancho; j++){
						if(i==0 || j==0 || i==alto-1 || j==ancho-1)
							Console.Write("*");
						else Console.Write(" ");
					}
				Console.WriteLine();
				}
			}
		}
