using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_6
{
    class Program
    {
        /*Tarea 6: Crea una función "SumaCifras" que reciba un numero cualquiera y que devuelva como
resultado la suma de sus dígitos. Por ejemplo, si el número fuera 123 la suma sería 6.*/
        static int SumarCifras(string number)
         {
             int acumulador = 0;
             for (int i = 0; i < number.Length; i++)
             {
                 acumulador += Convert.ToInt32(number.Substring(i, 1));
             }
             return acumulador;
         }
         static void Main(string[] args)
         {
             Console.WriteLine("Tarea 6: Sumador de Cifras");
             Console.Write("\nIngresa un numero (entero) al cual sumarle las cifras: ");
             Console.WriteLine("El resultado es: {0}", SumarCifras(Console.ReadLine()));

             Console.ReadKey();

         }
    }
}
