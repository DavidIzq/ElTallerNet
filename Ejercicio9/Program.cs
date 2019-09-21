/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 20/09/2019
 * Time: 4:30 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio9
{
	class Program
	{
		public static void Main(string[] args)
		{
			//9)	Ingresar cinco números y mostrar su promedio (usar ciclos)
			
			int num=0;
			for(int i=1;i<6;i++){
				Console.WriteLine("Digite numero "+i);
				num=int.Parse(Console.ReadLine());
				num+=num;
			}
			Console.WriteLine("El promedio de los numeros es de "+(num/5));
			
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}