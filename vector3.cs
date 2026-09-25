using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vectores3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 2 .Busqueda y Modificacion de informacion de vectores
            //Operaciones: Busqueda Lineal, Verificacion de existencia y Actualizacion de un elemento en un Array.

            int[] codigos = { 001, 002, 003, 006, 005, 012, 123, 445, 935 };
            Console.WriteLine($"codigos actuales: {string.Join(",", codigos)}");
            Console.WriteLine("Ingrese el codigo que sea actualizar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEncontrado = i;
                    break;
                }

            }// Valido si encontre el valor que quiero modificar!!
            if (indiceEncontrado != -1) {
                Console.WriteLine("Ingrese el codigo: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"\nVector Actualizado: {String.Join(", ", codigos)}");
            } else {
                Console.WriteLine("\nError: El codigo ingresado bo existe en la BDD.");

        }   }
    }
}

