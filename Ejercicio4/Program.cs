/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 20/09/2019
 * Time: 4:22 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio4
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*
			 *4) Ingresar 10 números, sumar los positivos y multiplicar los negativos. 
			*/ 
			
			int num, sumaP=0;
			long multiplicacionN=1;
			
			for(int i=1;i<=10;i++){
				Console.Write("Digite un numero: ");
				num = int.Parse(Console.ReadLine());
				
				if (num>0){
					sumaP=sumaP+num;
				}else{
					multiplicacionN=multiplicacionN*num;
				}
				
			}
			
			Console.Write("\nLa suma de los numeros positivos es: "+sumaP);
			Console.Write("\nLa multiplicacion de los numeros negativos es: "+multiplicacionN);
			
			Console.Write("")
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}