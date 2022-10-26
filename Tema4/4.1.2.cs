/*
  (4.1.2.1) Un programa que almacene en una tabla el número de días que tiene 
cada mes (supondremos que es un año no bisiesto), pida al usuario que le indique 
un mes (1=enero, 12=diciembre) y muestre en pantalla el número de días que 
tiene ese mes.
 */
using System;
class Ej_4_1_2_1{
	static void Main(){
		int[] diasMes = new int[12] {31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};
		bool ok = false; int num = 0;
		do{
			try{
				Console.Write("in troduce un mes Enesro = 1 ...  Diciembre = 12 :  ");
				num = Convert.ToInt32(Console.ReadLine());
				if(num < 13 && num > 0)
					ok=true;
			}
			catch(FormatException){
				Console.WriteLine("Error: Has introducido un numero que no es valido");
			}
		}while(!ok);
		Console.WriteLine(diasMes[num-1]);
	}
}
