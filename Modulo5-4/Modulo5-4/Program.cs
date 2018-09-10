using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modulo5_4
{
    class Program
    {
        /*Tarea 4: Analice el código ¿Qué hace este código? Realizar captura de pantalla del código con
su resultado y análisis del mismo. */


        //Este programa genera un triangulo de * de 7 filas poniendo espacios para que el mismo quede centrado

         public static void Main (string [] args)
         {
             Console.Clear();
             //dibujo de cada liena (bucle externo)
             for (int fila = 1; fila <= 7; fila++)
             {
                 //dibuja espacion en blanco (1er bucle interno)
                 for (int espacios = 7 - fila; espacios > 0; espacios--)
                     Console.Write(" ");//espacios
                                        //estrellas (2°bucle interno)
                 for (int conta = 1; conta < (2 * fila); conta++)
                     Console.Write("*");
                 Console.WriteLine(" ");
             }
             Console.WriteLine("Presione una tecla para salir...");
             Console.ReadKey();
         }
    }
}
