/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 20/09/2019
 * Time: 4:36 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio14
{
	class Program
	{
		public static void Main(string[] args)
		{
			/*14)Escriba un programa que muestre los números del 1 al 20 concatenados.
 				*Mostrar la concatenación agregando un número por línea.
			*/
			string espacio="";
			for(int i=1;i<21;i++){
				espacio=(espacio+i);
				Console.WriteLine(espacio);
				
			}
		
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}