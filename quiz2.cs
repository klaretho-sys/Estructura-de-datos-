using System;

namespace ControlNotas
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalEstudiantes = 21;

            string[] estudiantes = new string[totalEstudiantes];
            double[] notas = new double[totalEstudiantes];

            for (int i = 0; i < totalEstudiantes; i++)
            {
                string nombreIngresado = "";

                for (; string.IsNullOrWhiteSpace(nombreIngresado);)
                {
                    Console.Write($"Ingrese el nombre del primer estudiante{i + 1}: ");
                    nombreIngresado = Console.ReadLine();

                    if (string.IsNullOrWhiteSpace(nombreIngresado))
                    {
                        Console.WriteLine("Error: El nombre no puede estar vacío ni contener solo espacios.");
                    }
                }

                estudiantes[i] = nombreIngresado.Trim();

                double notaIngresada = -1;

                for (; notaIngresada < 0.0 || notaIngresada > 5.0;)
                {
                    Console.Write($"Ingrese la nota de {estudiantes[i]}: ");

                    if (!double.TryParse(Console.ReadLine(), out notaIngresada))
                    {
                        notaIngresada = -1;
                    }

                    if (notaIngresada < 0.0 || notaIngresada > 5.0)
                    {
                        Console.WriteLine("Error: La nota debe ser un número decimal entre 0.0 y 5.0.");
                    }
                }

                notas[i] = notaIngresada;
                Console.WriteLine();
            }

            double sumaNotas = 0;
            double notaMayor = notas[0];
            double notaMenor = notas[0];
            int aprobados = 0;
            int reprobados = 0;

            for (int i = 0; i < notas.Length; i++)
            {
                sumaNotas += notas[i];

                if (notas[i] > notaMayor)
                {
                    notaMayor = notas[i];
                }

                if (notas[i] < notaMenor)
                {
                    notaMenor = notas[i];
                }

                if (notas[i] >= 3.0)
                {
                    aprobados++;
                }
                else
                {
                    reprobados++;
                }
            }

            double promedio = sumaNotas / totalEstudiantes;

            Console.WriteLine("====================== Resultado de Estudiantes =====================");
            Console.WriteLine($"• Promedio de notas: {promedio:F2}");
            Console.WriteLine($"• Nota mayor del curso: {notaMayor:F1}");
            Console.WriteLine($"• Nota menor del curso: {notaMenor:F1}");
            Console.WriteLine($"• Cantidad de aprobados (>= 3.0): {aprobados}");
            Console.WriteLine($"• Cantidad de reprobados (< 3.0): {reprobados}");
            Console.WriteLine("=================================================================");
        }
    }
}
