/*
 * Created by SharpDevelop.
 * User: miguel
 * Date: 20/09/2019
 * Time: 4:15 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Ejercicio2
{
	class Program
	{
		/*
			 * 2)	Mostrar los números del 1 hasta un  número x ingresado por el usuario.
			 */ 
			
			int num;
			
			Console.Write("Digite un numero: ");
			num = int.Parse(Console.ReadLine());
			
			for(int i=1; i<=num;i++){
				Console.Write("\n"+i);
			}
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}