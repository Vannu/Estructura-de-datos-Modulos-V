using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_1
{
    public class Program
    {

        /* Tarea 1: Crea una función llamada "Signo", que reciba un número real, y devuelva un número
entero con el valor: -1 si el número es negativo, 1 si es positivo o 0 si es cero.*/
       
        public static int Signo(int realNumber)
        {
            int temp = 1;
            if (realNumber < 0)
                 temp = -1;
                 
            if (realNumber > 0)
                 temp = 1;
            if (realNumber == 0)
                 temp = 0;

            return temp;

        }
        public static void Main()
        {
            int number;
            Console.WriteLine("Ingrese un numero");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("El número {0} es: {1}",number, Signo(number));
            Console.ReadKey();
        } 
    }
}
