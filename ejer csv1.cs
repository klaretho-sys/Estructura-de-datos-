using System;
using System.IO;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main()

      stirng ruta = "C:\\Users\\Usuario\\Desktop\\potaxie.csv";
        if (File.Exists(ruta))
      {
         string[] lieas = File.ReadAllLines(ruta);
         foreach (string line in lieas) { 
    
         string[] campos = line.Split(',');
        Console.WriteLine($"Nombre: {campos[0]}, Nota: {campos[2]}");

    }

}  
 using (StreamWriter sw = new StreamWriter("potaxie.csv", append: true))
{
    sw.WriteLine("Klareth,17,20");
}
