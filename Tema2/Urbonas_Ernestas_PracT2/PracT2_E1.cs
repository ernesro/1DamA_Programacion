/*
Urbonas, Ernestas
Practica Evaluable  Tema 2
Ejercicio 1		si
*/

	using System;
		
		class PracT2_E1{
		
			static void Main(){
				
				//Año y mes actual/Nacimiento , edad
				int anioAct=0, anioN=1, mesAct=0, mesN=0, edad;
				
				//Contadores
				int i=1, jov=0, mad=0, may=0;
				
				string nombre , mesStr="";
				
				
				//Comprobamos que el mes actual es correcto
				
				do{		
					
					try{
						
						Console.Write("Introduce el mes actual : ");
						mesAct = Convert.ToInt32(Console.ReadLine());
						
					}
					catch (FormatException){
						Console.WriteLine("No es un numero valido");
					}
					
				}while(mesAct<=0 || mesAct>12);
				
				//Comprobamos que el año actual es correcto
				
				do{
					
					try{
						
						Console.Write("Introduce el año actual : ");
						anioAct = Convert.ToInt32(Console.ReadLine());
					}
					catch (FormatException){
						Console.WriteLine("No es un numero valido");
					}
					
				}while(anioAct<1800);
				
				Console.WriteLine();
				
				//Bucle para pedir los datos de los empleados
				
				do{
					
					//La variable nombre no puede estar vacia
					
					nombre = "";
					
					do{
						
						Console.Write("Introduce el nombre de la personas " + i + " : ");
						nombre = (Console.ReadLine());

					}while(nombre == "");
					
					//Comprobamos que el mes de nacimiento es correcto
					
					do{
					
						try{
						
							Console.Write("Introduce el mes de nacimiento de " + nombre + " : ");
							mesN = Convert.ToInt32(Console.ReadLine());
						}
						catch (FormatException){
							Console.WriteLine("No es un numero valido");
						}
					
					}while(mesN<=0 || mesN>12);
					
					//Comprobamos que el año de nacimiento es correcto 
					
					do{
					
						try{
						
							Console.Write("Introduce el año de nacimiento : ");
							anioN = Convert.ToInt32(Console.ReadLine());
						}
						catch (FormatException){
							Console.WriteLine("No es un numero valido");
						}
					
					}while(anioN<0);
					
					//Calculamos las edades
					
					if(anioN != 0){		//Pero si es 0 el bucle se saltaestos calculos porque se termina
						
						edad = (mesAct > mesN) ? (anioAct - anioN)-1 : anioAct - anioN;
						
						//Cambiamos de mes de nacimiento en 'Int' a tipo 'string'
						
							switch(mesN){	
								
								case 1:mesStr = "Enero" ;
									break;
								case 2:mesStr = "Febrero" ;
									break;
								case 3:mesStr = "Marzo" ;
									break;
								case 4:mesStr = "Abril" ;
									break;
								case 5:mesStr = "Mayo" ;
									break;
								case 6:mesStr = "Junio" ;
									break;
								case 7:mesStr = "Julio" ;
									break;
								case 8:mesStr = "Agosto" ;
									break;
								case 9:mesStr = "Septiembre" ;
									break;
								case 10:mesStr = "Octubre" ;
									break;
								case 11:mesStr = "Noviembre" ;
									break;
								case 12:mesStr = "Diciembre" ;
									break;
								}
									
						Console.WriteLine(nombre + " nacio en " + mesStr + " el año " + anioN + ". Tiene " + edad + " años." );
					
						//Sumamos a que rango pertenece de edad
						
						if(anioAct-anioN < 25)
							jov++;
							
							else if(anioAct-anioN >= 50)
								may++;
							
							else
								mad++;
							
						Console.WriteLine();
					
						i++;
					
					}
					
				}while(anioN != 0);
				
				Console.WriteLine();
				
				//Comprobamos cuantos hay de cada rango
				
				Console.WriteLine("Hay " + jov + " jovenes, " + mad + " maduros y " + may + " mayores.");
				
				if(jov == 0 && mad == 0)
					Console.Write("Todos tienen 50 años o mas.");
					
					else if(may == 0)
						Console.Write("Nadie a llegado a los 50 años.");
						
					else
						Console.Write("Hay algunos menores de 50 y otros mayores.");
					
			}	
		}		
		
