using System;
using System.IO;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()
        {
            string ruta = "Potaxies.csv";

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                sw.WriteLine("Nombre,Edad,Nota,Asignatura,Profesion,mascotas");
                sw.WriteLine("Klareth,17,50,Estructura de datos,Ingeniera informatica,1 gato");
                sw.WriteLine("Jesus,22,45,Calculo 1,Futbolista,3");
                sw.WriteLine("Mavis,40,100,Ingles,Secretaria,1");
            }
            Console.WriteLine("Archivo creado exitosamente.");

}   }   }  