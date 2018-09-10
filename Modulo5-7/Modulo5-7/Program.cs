using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_7
{
    class Program
    {
        /*Tarea 7 (Opcional): Crea una función "Triángulo" que reciba una letra y un número, y escriba
         un "triángulo" formado por esa letra, que tenga como anchura inicial la que se ha indicado. Por
         ejemplo, si la letra es * y la anchura es 4, debería escribir*/
        public static void Triangulo(char letter, int number)
        {
            for (int fila = 1; fila <= number; fila++)
            {

                for (int conta = 1; conta < (2 * fila); conta++)
                    Console.Write("{0}", letter);
                Console.WriteLine(" ");
            }
            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
        public static void Main()
        {
            char letter;
            int number;
            Console.WriteLine("Tarea 7: Dibujar Triangulo");
            Console.Write("\nIngrese una letra para rellenar el triangulo: ");
            letter = Convert.ToChar(Console.ReadLine());
            Console.Write("\nIngrese un número de filas: ");
            number = Convert.ToInt32(Console.ReadLine());
            Triangulo(letter, number);


        }
    }
}
