/*
Urbonas, Ernestas
Practica Evaluable  Tema 2
Ejercicio 2		si
*/

	using System;
		
		class PracT2_E2{
		
			static void Main(){
				
				int num=1, numMayor=0, numMenor=0, numRepetido=0, c=1, c2=0, numAnterior=0;
				
				
				do{		
					
					//Comprobamos que el numero introducido es correcto
					
					try{
						
						Console.Write("Introduce un numero entero positivo o negativo: ");
						num = Convert.ToInt32(Console.ReadLine());
						
						if(num == 0)
							break;
						
						//Como estan declaradas a 0 las igual al numero introducido
						
						if(numMenor == 0){
							
							numMenor = num;
							numRepetido = 1;
							numMayor = num;
							//numAnterior=num;
						}
						
						numMayor = (num > numMayor) ? num : numMayor;	//Comprobamos cual es el mayor y lo guardamos
						
						numMenor = (num < numMenor) ? num : numMenor;	//Comprobamos cual es el menor y lo guardamos
						
						//Comprobamos cual es el que se repite mas y lo guardamos
						
						if(numAnterior == num){
							c++;
							
						//Console.WriteLine(c+"eeeeeeeeeeeeeeeee");
						}
						 else{
							numRepetido= (c2 < c) ? numAnterior : numRepetido;
							c2=c;
							c=1;
						}
						
						numAnterior=num;
						
					}
			
					catch (FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(num != 0);
				
				Console.WriteLine();
				
				Console.Write("El numero que has repetido mas veces es el " + numRepetido);
				Console.Write(" , el menor es el " + numMenor);
				Console.Write(" y el mayor es el " + numMayor);
			}
		}
				
	
