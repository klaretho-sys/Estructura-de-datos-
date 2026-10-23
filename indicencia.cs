using System;
using System.Collections.Generic;
using System.IO;


//Registro de incidencias de soporte tecnico utilizando archivos (.txt)
//1. Guardar en una lista de incidencias atendidas en un archivo de texto (incidencidencias,txt)
//2. leer el archivo
//3. generar un reporte que cuenta cuantas incidencias hay por prioridad (alta, media, baja)
//la estructura del archivo es: ID, NOMBRE, DESCRIPCION, PRIORIDAD.

// ejemplo: "01";"Klareth OLivo";"daño del pc"; "alta"
namespace RegistrosInciedncia
{
    internal class Program
    {

        static string pathARCHIVO = "imcidencias.txt";

        static void GuardarIncidencias(List<string[]> Incidencias)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(pathARCHIVO, false))
                {
                    foreach (string[] incidencia in Incidencias)
                    {
                        sw.WriteLine(incidencia);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"error al esribir el archivo: {ex.Message}");

            }

        }
        static List<string[]> LeerIncidencias()
        {
            List<string[]> incidencias = new List<string[]>();

            if (!File.Exists(pathARCHIVO))
            {
                Console.WriteLine("El archivo no existe aún.");
                return incidencias;
            }

            try
            {
                string linea;
                using (StreamReader sr = new StreamReader(pathARCHIVO))

                    while ((linea = sr.ReadLine()) != null)
                    {
                        if (string.IsNullOrEmpty(linea))
                        {
                            string[] campos = linea.Split(';');
                            incidencias.Add(campos);
                        }

                    }


            }
            catch (Exception error)
            {
                Console.WriteLine($"Error al leer el archivo{error.Message}");
            }
            return incidencias;
        }

        static void GenerarReporte(List<string[]> incidencias)
        {
            if (incidencias.Count == 0)
            {
                Console.WriteLine("No hay incidencias para reportar");
                return;
            }
            Dictionary<string, int> conteoPorPrioridad = new Dictionary<string, int>();
            foreach (string[] inc in incidencias)
            {
                if (inc.Length < 4) continue;
                string prioridad = inc[3];
                // inc [ejemplo: "01";"A";"daño del pc"; "alta"]

                if (conteoPorPrioridad.ContainsKey(prioridad))
                {
                    conteoPorPrioridad[prioridad]++;
                }
                else
                    conteoPorPrioridad[prioridad] = 1;
            }
            Console.WriteLine("\n REPOTE DE INCIDENCIAS");
            Console.WriteLine($"total atendidas: {incidencias.Count}");
            Console.WriteLine("detalle por prioridad");
            foreach (var inc in conteoPorPrioridad)

            {
                Console.WriteLine($"\nprioridad {inc.Key}: {inc.Value}");
            }
        }

        static void Main(string[] args)
        {
            List<string[]> incidenciasToday = new List<string[]>
            {
                new string[] { "1", "Klareth Olivo", "no imprime", "alta" },
                new string[] { "2", "Jose Aguas", "olvido la consatraseña", "baja" },
                new string[] { "3", "Jesus Meriño", "lento", "alta" },
                new string[] { "4", "David Leal", "pantalla mala", "media" },
                new string[] { "5", "Mavis Montero", "pc lenta", "alta" },
            };
            Console.WriteLine("REGISTRO DE INCIDENCIA UNICARIBE");
            GuardarIncidencias(incidenciasToday);

            Console.WriteLine("\n---- leyendo incidencias del archivo ----");
            List<string[]> incidenciasLeidas = LeerIncidencias();

            Console.WriteLine("\n LISTADO DE INCIDENCIDENCIAS LEIDAS");
            Console.WriteLine($"{"ID",-4}{"usuario",-15}{"Descripcion",-20}{"prioridad",-10}");
            Console.WriteLine(new string('-', 55));

            foreach (string[] inc in incidenciasLeidas)
            {
                if (inc.Length < 4) continue;
                Console.WriteLine($"{inc[0],-4}{inc[1],-15}{inc[2],-20}{inc[3],-10}");
            }
            GenerarReporte(incidenciasLeidas);
            Console.WriteLine("\nPresione cualquier tecla para salir!!!!");
            Console.ReadKey();
        }
    }
}
