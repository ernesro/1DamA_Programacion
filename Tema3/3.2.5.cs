	
	using System;
		
		class Ej_3_2_5{
		
			static void Main(){
				
				int verdad=0, num=0;
				
				do{
					do{
						
						try{
							Console.WriteLine("Opcion 1 -----------> 3.2.5.1");
							Console.WriteLine("Opcion 2 -----------> 3.2.5.2");
							Console.WriteLine("Opcion 3 -----------> 3.2.5.3");
							Console.WriteLine("Opcion 4 -----------> 3.2.5.4");
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
						
						case 0 :
							break;
						case 1:Opc1();
							break;
						case 2:Opc2();
							break;
						case 3:Opc3();
							break;
						case 4:Opc4();
							break;
						
					}
				}while(num != 0);
			}
			
			
			/*
			(3.2.5.1) El usuario de nuestro programa podrá teclear dos números de hasta 12 
			cifras significativas. El programa deberá mostrar el resultado de dividir el primer 
			número entre el segundo, utilizando tres cifras decimales.
			*/
			
			static void Opc1(){
				
				double num1=0, num2=0, resultado;
				int verdad=0;
				
				do{
					try{
						Console.Write("Introduce el primer numero : ");
						num1 = Convert.ToDouble(Console.ReadLine());
						
						if(num1 >= 0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				verdad=0;
				
				do{
					try{
						Console.Write("Introduce el segundo numero : ");
						num2 = Convert.ToDouble(Console.ReadLine());
						
						if(num2 > 0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un numero valido");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
				}while(verdad == 0);
				
				resultado = num1/num2;
				Console.WriteLine(resultado.ToString("N3"));
				
				Console.WriteLine("---------------------------------");

			}
			
			
			/*
			(3.2.5.2) Crea un programa que use tres variables x,y,z. Las tres serán números 
			reales, y nos bastará con datos de simple precisión. Se deberá pedir al usuario los 
			valores para las tres variables y mostrar en pantalla el valor de x2
			+ y - z (con exactamente dos cifras decimales).
			*/
			
			static void Opc2(){
				
				int verdad=0;
				double x=0, y=0, z=0, resultado;
				
				
				do{
					try{
						Console.Write("Introduce el valor de x : ");
						x = Convert.ToDouble(Console.ReadLine());
						verdad = 1;
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				do{
					try{
						Console.Write("Introduce el valor de y : ");
						y = Convert.ToDouble(Console.ReadLine());
						verdad = 1;
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				do{
					try{
						Console.Write("Introduce el valor de z : ");
						z = Convert.ToDouble(Console.ReadLine());
						verdad = 1;
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
	
				}while(verdad == 0);
				
				resultado =Math.Pow(x,2) + y - z;
				
				Console.WriteLine("El resultado de x^2 + y - z = " + resultado.ToString("N2"));
				
				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.5.3) Calcula el perímetro, área y diagonal de un rectángulo, a partir de su 
			ancho y alto (perímetro = suma de los cuatro lados; área = base x altura; diagonal
			= hipotenusa, usando el teorema de Pitágoras). Muestra todos ellos con una cifra 
			decimal.
			*/
			
			static void Opc3(){
				
				double ladoA=0, ladoB=0, perim, area, hipot;
				int verdad=0;
				
				do{
					try{
						Console.Write("Introducela altura del lado A : ");
						ladoA = Convert.ToDouble(Console.ReadLine());
						
						if(ladoA > 0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un altura no valida");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				verdad=0;
				
				do{
					try{
						Console.Write("Introduce la altura del lado B : ");
						ladoB = Convert.ToDouble(Console.ReadLine());
						
						if(ladoB > 0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un altura no valida");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				perim = ladoA + ladoA + ladoB + ladoB;
				area = ladoA * ladoB;
				hipot = Math.Sqrt(Math.Pow(ladoA,2) + Math.Pow(ladoB,2));
				
				Console.WriteLine("El perimetro del rectanculo es " + perim.ToString("N1") 
					+ ", el area es " + area.ToString("N1") + " y su diagonal es " + hipot.ToString("N1"));

				Console.WriteLine("---------------------------------");
			}
			
			/*
			(3.2.5.4) Calcula la superficie y el volumen de una esfera, a partir de su radio 
			(superficie = 4 * pi * radio al cuadrado; volumen = 4/3 * pi * radio al cubo). Usa
			datos "doble" y muestra los resultados con 5 cifras decimales.
			*/
			
			static void Opc4(){
				
				int verdad=0;
				double radio=0, superficie, volumen, pi=3.14159265;
				
				do{
					try{
						Console.Write("Introduce el radio de una esfera : ");
						radio = Convert.ToDouble(Console.ReadLine());
						
						if(radio > 0)
							verdad = 1;
						else
							Console.WriteLine("Error: No es un radio no valida");
					}
					
					catch(FormatException){
						Console.WriteLine("Error: No es un numero valido");
					}
					
				}while(verdad == 0);
				
				superficie = 4 * pi * Math.Pow(radio,2);
				volumen = (4 * pi * Math.Pow(radio,3))/3;
				
				
				Console.WriteLine("La superficei de la esfera es " + superficie.ToString("N5") 
					+ " y su volumen es de " + volumen.ToString("N5"));
				
				Console.WriteLine("---------------------------------");
			}
		}		

		

