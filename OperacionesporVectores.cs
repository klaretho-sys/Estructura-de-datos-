using System;

namespace BusquedaYModificacion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 2: Búsqueda y Modificación de información de vectores
            // Operaciones: Búsqueda Lineal, Verificación de existencia y Actualización de un elemento en un Array.

            int[] codigos = new int[20]; 
            Console.WriteLine("======= Ingrese  Códigos =======");
            for (int i = 0; i < codigos.Length; i++)
            {
                Console.Write($"Ingrese el código {i + 1}: ");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("\n======= Códigos Actuales =======");
            Console.WriteLine(string.Join(", ", codigos));

           
            Console.Write("\nIngrese el código a  modificar: ");
            int codigoBuscado = Convert.ToInt32(Console.ReadLine());

            int indiceEncontrado = -1;
            
            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == codigoBuscado)
                {
                    indiceEncontrado = i;
                    break; 
                }
            }

            if (indiceEncontrado != -1)
            {
                Console.Write($"¡Código encontrado{indiceEncontrado + 1}!\nIngrese el nuevo valor para actualizar: ");
                codigos[indiceEncontrado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("\n¡Actualización!");
                Console.WriteLine($"Vector actualizado: {string.Join(", ", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError BDD.");
            }
        }
    }
}
