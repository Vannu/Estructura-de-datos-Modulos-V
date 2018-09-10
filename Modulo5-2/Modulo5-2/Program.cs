using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_2
{
    class Program
    {
        /* Tarea 2: Crea una función "Menor" que calcule el menor de dos números enteros que recibirá
 como parámetros.El resultado será otro número entero.*/
           public static int Menor(int num1, int num2)
           {
               if (num1 < num2)
                   return num1;
               else
                   return num2;           
           }
           public static void Main()
           {
               int number1;
               int number2;
               Console.WriteLine("Ingrese el primer número");           
               number1 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("Ingrese el segundo número");
               number2 = Convert.ToInt32(Console.ReadLine());
               Console.WriteLine("El menor de {0} y {1} es: {2}",number1, number2, Menor(number1, number2));
               Console.ReadKey();
           }
    }
}
