/*(2.2.3.5) Crea un programa que muestre los primeros ocho números pares: 2 4 6 8
10 12 14 16 (pista: en cada pasada habrá que aumentar de 2 en 2, o bien mostrar
el doble del valor que hace de contador).*/
	using System;
	
		class Ej_02_02_03_05
		{
			static void Main()
			{ 
				int contador;
				
				for (contador = 2; contador <= 16; contador+=2)
						Console.Write(contador + " ");
			}
		} 
