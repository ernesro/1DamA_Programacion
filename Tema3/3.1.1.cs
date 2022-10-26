/*
(3.1.1.1) Calcula el producto de 1.000.000 por 1.000.000, usando una variable 
llamada "producto", de tipo "long". Prueba también a calcularlo usando una 
variable de tipo "int"
*/
	using System;
		class Ej_3_1_1{
			static void Main(){
							
				long num = 1000000;
				long producto = num * num; 
				
				//int productoInt = 1000000 * 1000000;
				
				Console.WriteLine(producto);
			}	
		}		

		
