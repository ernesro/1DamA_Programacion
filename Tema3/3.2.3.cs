	
	using System;
		
		class Ej_3_2_3{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.3.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.3.2");
							Console.WriteLine("Opcion 3 -----------> 3.2.3.3");
							Console.WriteLine("Opcion 4 -----------> 3.2.3.4");
							Console.WriteLine("Opcion 5 -----------> 3.2.3.5");
							Console.WriteLine("Opcion 6 -----------> 3.2.3.6");
							Console.WriteLine("Opcion 7 -----------> 3.2.3.7");
							Console.WriteLine("Opcion 0 -----------> Salir");
							Console.Write("Que ejercicio quieres ver ? : ");
							num= Convert.ToInt32(Console.ReadLine());
							
							Console.WriteLine();
							
							if(num >= 0 && num <8)
								verdad = 1;
						}
						
						catch(Exception){
							Console.WriteLine("Error. Introduce un numero valido.");
						}
						
					}while(verdad == 0);
						
					switch(num){
						
						case 1:Opc1();
							break;
						case 2:Opc2();
							break;
						case 3:Opc3();
							break;
						case 4:Opc4();
							break;
						case 5:Opc5();
							break;
						case 6:Opc6();
							break;
						case 7:Opc7();
							break;
						case 0 :break;
						
					}
				}while(num != 0);
			}
			
			
			/*
			(3.2.3.1) Calcula el volumen de una esfera, dado su radio, que será un número de
			doble precisión (volumen = pi * radio al cubo * 4/3)
			*/
			
			static void Opc1(){
				
				double radio = 5;
				double volumen;
				double pi = 3.141592653589793238;
				
				volumen = (pi * (radio * radio * radio) * 4)/3;
				
				Console.WriteLine("El volumen de la esfera con radio " + radio + " es igual a " + volumen);
				Console.WriteLine("---------------------------------");
			}
			
			
			/*
			(3.2.3.2) Crea un programa que pida al usuario a una distancia (en metros) y el 
			tiempo necesario para recorrerla (como tres números: horas, minutos, segundos), 
			y muestre la velocidad, en metros por segundo, en kilómetros por hora y en millas 
			por hora (pista: 1 milla = 1.609 metros).
			*/
			
			static void Opc2(){
				
				int horas=0, min=0, metros=0, milla = 1609, verdad = 0;
				float velocidad, sec=0, tiempoTotal;
				
				//Control de errores en metros
				
				do{
					try{
						Console.Write("Introduce una distancia en metros : ");
						metros = Convert.ToInt32(Console.ReadLine());
						
						if(metros >0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				//Control de errores en horas
				
				do{
					try{
						Console.Write("Introduce las horas que tardas en recorrerlo: ");
						horas = Convert.ToInt32(Console.ReadLine());
						
						if(horas >= 0)
							verdad = 1;
						else{
							Console.WriteLine("Error: No es un numero valido");
							verdad = 0;
						}
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}	
				}while(verdad == 0);
				
				//Control de errores en min
				
				do{
					try{
						Console.Write("Introduce los minutos  que tardas en recorrerlo: ");
						min = Convert.ToInt32(Console.ReadLine());
						
						if(min >= 0 && min <= 60)
							verdad = 1;
						else{
							Console.WriteLine("Error: No es un numero valido");
								verdad = 0;
						}
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				//Contros de errores de segundos
				
				do{
					try{
						Console.Write("Introduce los segundos  que tardas en recorrerlo: ");
						sec = Convert.ToInt32(Console.ReadLine());
						
						if(sec >= 0 && sec <= 60)
							verdad = 1;
						else{
							Console.WriteLine("Error: No es un numero valido");
								verdad = 0;
						}
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				Console.WriteLine();
				
				tiempoTotal = (horas * 3600) + (min * 60) + sec;
				
				velocidad = metros/tiempoTotal;
				Console.WriteLine("Tu velocidad es " + velocidad + " m/s.");
				
				velocidad = velocidad * 0.001f * 3600f;
				Console.WriteLine("Tu velocidad es " + velocidad + " k/h.");
				
				velocidad = (velocidad * 1000) / milla;
				Console.WriteLine("Tu velocidad es " + velocidad + " millas/h.");
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.3.3) Halla las soluciones de una ecuación de segundo grado del tipo y = Ax2+ 
			Bx + C. Pista: la raíz cuadrada de un número x se calcula con Math.Sqrt(x)
			*/
			
			static void Opc3(){
				
				float a=1, b=2, c=-3, dentroRaiz=0;
				double ypositivo=0, ynegativo=0;
				
				dentroRaiz =(b * b) -4 * a * c;
				
				ypositivo = (-b + Math.Sqrt(dentroRaiz)) / (2 * a);
				ynegativo = (-b - Math.Sqrt(dentroRaiz)) / (2 * a);
				
				Console.WriteLine("y = " +  a + "x^2 + " + b + "x + " + c);
				Console.WriteLine("x = " + ypositivo + "  x = " + ynegativo);

				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.3.4) Si se ingresan E euros en el banco a un cierto interés I durante N años, el 
			dinero obtenido viene dado por la fórmula del interés compuesto: Resultado = e (1+ i)n
			Aplícalo para calcular en cuanto se convierten 1.000 euros al cabo de 10 
			años al 3% de interés anual.
			*/
			
			static void Opc4(){
				
				int euros = 1000, anios = 10;
				float interes = 0.03f;
				double interesTotal=0, resultado;
				
				interesTotal = 1+interes;
				interesTotal = Math.Pow(interesTotal, anios);
				
				resultado = euros * interesTotal;
				
				Console.WriteLine("1000 euros se han convertido en " + resultado + " euros en " + anios + " años a " +
					interes + " por año.");
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			 (3.2.3.5) Crea un programa que muestre los primeros 20 valores de la función y = x^2 -1
			*/
			
			static void Opc5(){
				
				double x, y;
				
				for(x=0; x<21; x++){
					y = Math.Pow(x, 2)-1;
					Console.WriteLine("x = " + x + "   y = " + y);
				}
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.3.6) Crea un programa que "dibuje" la gráfica de y = (x-5)2 para valores de x 
			entre 1 y 10. Deberá hacerlo dibujando varios espacios en pantalla y luego un 
			asterisco. La cantidad de espacios dependerá del valor obtenido para "y". Te será 
			fácil si dibujas la gráfica "girada", de forma que los valores de "y" crezcan hacia la 
			derecha, así:
			*/
			
			static void Opc6(){
				
				double x, y;
				
				for(x=0; x<11; x++){
						y = Math.Pow((x-5), 2);
					for(int j=0; j<y; j++)
						Console.Write(" ");
					if(x==0)
						Console.Write(" ");
					else
						Console.Write("*");
				Console.WriteLine();
				}
				
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.3.7) Escribe un programa que calcule una aproximación de PI mediante la 
			expresión: pi/4 = 1/1 - 1/3 + 1/5 - 1/7 + 1/9 - 1/11 + 1/13 ... El usuario deberá 
			indicar la cantidad de términos a utilizar, y el programa mostrará todos los 
			resultados hasta esa cantidad de términos. Debes hacer todas las operaciones con 
			"double".
			*/
			
			static void Opc7(){
				
				int  verdad=0;
				double num=0, pi=0;
				
				do{
					try{
						Console.Write("Introduce las iteraciones: ");
						num = Convert.ToInt32(Console.ReadLine());
					}
					catch(FormatException){
						Console.WriteLine("Error. Número introducido no valido: ");
					}
					if(num > 0)
						verdad=1;
				}while(verdad==0);
				
				double fraccion=1;
				for(int i=1; i<=num; i++){
					if(i%2 == 0)
						pi = pi - (1/fraccion);
					else
						pi = pi + (1/fraccion);
					fraccion+=2;
					}
					
				Console.WriteLine("pi = " + pi*4);
				Console.WriteLine("---------------------------------");
			}
		}		

		

