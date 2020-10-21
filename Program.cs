/*
 * Programa que determina si un año ingresado
 * en valor numérico enteroy positivo
 * es o no un año bisiesto
 * 
 * Creado    : 14/10/2020
 * Modificado: 21/10/2020
 * */
using System;

namespace bisiesto
{
	class Program
	{
		
		/*
		 * Función que decide si un número entero es o no positivo
		 * Recibe:
		 *  int numero : Número a revisar
		 * 
		 * Regresa:
		 *  bool valor : Un valor booleano que indica si el número recibido es o no positivo
		 * */
		public static bool revisarIntPositivo(int numero)
		{
			return numero >= 0;
		}
		
		/* Función de lectura para asegurar la conversión a entero
		 * Recibe:
		 * 	string mensaje : Cadena de caracteres con un mensaje a mostrar
		 * 
		 * Regresa:
		 *  int : Un valor entero con la cadena ingresada
		 * */
		public static int ingresarInt(string mensaje = "Ingresar un valor entero: ")
		{
			string resp;
			int valor;
			// Se coloca todo dentro de un ciclo infinito
			while(true)
			{
				// Limpiar la consola
				Console.Clear();
				// Colocar la cadena de caracteres en posicion
				Console.SetCursorPosition(0,0);
				// Se recibe una cadena de caracteres
				Console.Write(mensaje);
				resp = Console.ReadLine();
				// Se ingresa a una sección try - catch
				try
				{
					// En este caso se intenará realizar una conversión a un valor entero 
					valor = Convert.ToInt32(resp);
					// Una vez que no aparezcan errores, se procede a verificar si el número
					// es positivo
					if(revisarIntPositivo(valor)){
						// FIXME: Modificar para que esto sólo se muestre con una función
						Console.ForegroundColor = ConsoleColor.Green;
						Console.SetCursorPosition(0,1);
						Console.WriteLine("Valor correcto");
						Console.ForegroundColor = ConsoleColor.Gray;
						// En caso de que se logre romperá el ciclo
						break;
					}
					else
					{
						Console.ForegroundColor = ConsoleColor.Red;
						Console.SetCursorPosition(0,2);
						Console.WriteLine("El valor no es positivo");
						Console.SetCursorPosition(0,3);
						Console.WriteLine("¡Favor de ingresar de nuevo!");
						Console.ForegroundColor = ConsoleColor.Gray;						
					}
				}
				// Aquí se maneja la excepción, esta es del tipo FormatException
				catch(FormatException e)
				{
					// Cambiar a color rojo
					Console.ForegroundColor = ConsoleColor.Red;
					Console.SetCursorPosition(0,2);
					Console.WriteLine("El valor no es un número entero");
					Console.SetCursorPosition(0,3);
					Console.WriteLine("¡Favor de ingresar de nuevo!");
					// Regresar al color original
					Console.ForegroundColor = ConsoleColor.Gray;
				}
				finally
				{
					// FIXME: Hacer que esto solo aparezca cuando hay algún error
					Console.ReadKey(true);
				}
			}
			// Una vez que se logre salir del ciclo, se regresa el valor
			return valor;
		}
		
		public static void Main(string[] args)
		{
			int aa;			
			
			// Inicia el nombre de la ventana
			Console.Title = "Año bisiesto";
			
			//aa = ingresarInt("Ingresar un año (valor entero y positivo): ");
			aa = ingresarInt();
			
			// Probación de que es un año bisiesto
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.SetCursorPosition(0,2);
			if( (aa % 4 == 0)&&(aa % 100 != 0)||(aa % 400 == 0) )
				Console.WriteLine("El año {0} es bisiesto", aa);
			else
				Console.WriteLine("El año {0} NO es bisiesto", aa);
			Console.ForegroundColor = ConsoleColor.Gray;
			
			Console.SetCursorPosition(0,5);
			Console.Write("Presione una tecla para continuar . . . ");
			Console.ReadKey(true);
		}
	}
}
