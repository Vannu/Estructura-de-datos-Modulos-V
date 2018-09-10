using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_3
{
    class Program
    {
        /* Tarea 3: Crea una función "EsPrimo", que reciba un número y devuelva el valor booleano
 "true" si es un número primo o "false" en caso contrario.*/

         public static bool EsPrimo(int number)
         {
             if ((number != 2) && (number % 2 == 0)) return false;
             for (int i = 3; i < number / 2; i += 2)
             {
                 if (number % i == 0)
                 {
                     return false;
                 }
             }
             return true;
         }
         public static void Main()
         {
             int number;
             Console.WriteLine("Ingrese un número");
             number = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("El número {0} es : {1}",number,EsPrimo(number));
             Console.ReadKey();
         }
    }
}
