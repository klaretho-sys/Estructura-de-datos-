double[] ventas = { 200.000, 302.300, 400.000, 300.223, 700.410, 740.432, 100.233, 99.423, 823.231, 902.211 };
double total = 0;
double mayorVenta = ventas[0];
double menorVenta = ventas[0];
int diaMayorVenta = 0;
int diaMenorVenta = 0;

for (int i = 0; i < ventas.Length; i++)
{
    total += ventas[i];

    if (ventas[i] > mayorVenta)
    {
        mayorVenta = ventas[i];
        diaMayorVenta = i;
    }

    if (ventas[i] < menorVenta)
    {
        menorVenta = ventas[i];
        diaMenorVenta = i;
    }
}

double promedio = total / ventas.Length;
int diasSobrePromedio = 0;

for (int i = 0; i < ventas.Length; i++)
{
    if (ventas[i] > promedio)
    {
        diasSobrePromedio++;
    }
}

Console.WriteLine("======================Reporte De Venta=====================");
Console.WriteLine();
Console.WriteLine($"Total vendido: ${total}");
Console.WriteLine($"Promedio diario: ${promedio:F3}");
Console.WriteLine();

Console.WriteLine($"Mayor Venta ${mayorVenta} - el dia {diaMayorVenta + 1}");
Console.WriteLine($"Menor Venta ${menorVenta} - el dia {diaMenorVenta + 1}");

Console.WriteLine($"Dias que superaron el promedio de Ventas: {diasSobrePromedio}");
Console.WriteLine();

Console.WriteLine("Ventas por Dias");
for (int i = 0; i < ventas.Length; i++)
{
    Console.WriteLine($"dia {i + 1}: ${ventas[i]}");
}
