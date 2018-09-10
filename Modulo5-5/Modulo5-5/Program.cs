using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_5
{
    class Program
    {
        /*Tarea 5: Crea una calculadora básica, llamada "calcula", que deberá sumar, restar, multiplicar
o dividir los dos números que se le indiquen como parámetros. Ejemplos de su uso sería
"calcula 2 + 3" o "calcula 5 * 60". (Utilice Funciones)*/
        static string CortarEnEspacio(ref string frase)
        {
            frase = frase.Remove(0, frase.IndexOf(" ") + 1);
            return frase;
        }
         static int ExtraerValor(ref string frase)
            //Extrae el OPERANDO
        {
            return Convert.ToInt32(frase.Substring(0, frase.IndexOf(" "))); 
        }
         static char ExtraerOperacion(ref string frase)
            //Extra la OPERACION
        {
            return Convert.ToChar(frase.Substring(0, frase.IndexOf(" ")));
        }
         static int Resolver (int num1, char oper, int num2)
        {
            switch (oper)
            {
                case '+':
                    return num1 + num2;
                    
                case '-':
                    return num1 - num2;
                    
                case '*':
                    return num1 * num2;
                    
                case '/':
                    return num1 / num2;
                    
                case '%':
                    return num1 % num2;
                    
                default: return 0;
            }
        }
         static void Main(string[] args)
        {
            string frase;
            char operacion;
            int operando1, operando2, resultado;
             Console.WriteLine("Tarea 6: Ingresá un calculo. \nEl mismo debe iniciar diciendo \"calcula...\"");
            Console.WriteLine("Ejemplo: calcula 6 + 4");
            Console.Write("Incia: ");
            frase = Console.ReadLine().ToLower();
            CortarEnEspacio(ref frase);
            operando1 = ExtraerValor(ref frase);
            CortarEnEspacio(ref frase);
            operacion = ExtraerOperacion(ref frase);
            CortarEnEspacio(ref frase);
            operando2 = Convert.ToInt32(frase);
             resultado = Resolver(operando1, operacion, operando2);
            
            Console.WriteLine("El resultado de la operación es {0}", resultado);
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }


    }
}
