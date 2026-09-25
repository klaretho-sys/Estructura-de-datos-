using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperatura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] temperatura = new double[5]; // Declarado e iniciando 


            //Lectura/Escritura de nuestro vector 

            Console.WriteLine("=======Ingreso de Temperaturas=======");


            for (int i = 0; i < temperatura.Length; i++)
            {
                Console.Write($"Ingrese la Temperatura del dia {i + 1}:");
                temperatura[i] = Convert.ToDouble(Console.ReadLine());
            }
            double suma = 0;
            double maxT = temperatura[0];
            double minT = temperatura[0];

            foreach (double tem in temperatura)
            {   
                suma += tem;
                if (tem > maxT) maxT = tem;
                if (tem < minT) minT = tem;
         
            }

            double promedio = suma / temperatura.Length;

            //salida de informacion 
            Console.WriteLine("\n---Reporte---");
            Console.WriteLine($"Temperaturas registradas: {string.Join(", ", temperatura)}");
            Console.WriteLine($"Temperatura promedio: {promedio:F2}°C");
            Console.WriteLine($"Temperatura Maxima: {maxT}°C");
            Console.WriteLine($"Temperatura Minima: {minT}°C");
        }
    }
}
    
