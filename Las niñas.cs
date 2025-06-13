using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese el monto que dispone");
        decimal monto = decimal.Parse(Console.ReadLine());

        Console.WriteLine("Cual es la edad de la primer niña?");
        int edad1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Cual es la edad de la segunda niña?");
        int edad2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Cual es la edad de la tercer niña?");
        int edad3 = int.Parse(Console.ReadLine());

        Console.WriteLine("Cual es la edad de la cuarta niña?");
        int edad4 = int.Parse(Console.ReadLine());

        int total = edad1 + edad2 + edad3 + edad4;

        decimal monto1 = monto * edad1/total;
        decimal monto2 = monto * edad2/total;
        decimal monto3 = monto * edad3/total;
        decimal monto4 = monto * edad4/total;

        decimal porcentaje1 = (decimal)edad1/total;
        decimal porcentaje2 = (decimal)edad2/total;
        decimal porcentaje3 = (decimal)edad3/total;
        decimal porcentaje4 = (decimal)edad4/ total;

        Console.WriteLine("Niña 1: ${porcentaje1:P1} - {monto1:F2");
        Console.WriteLine("Niña 2: ${porcentaje2:P1} - {monto2:F2");
        Console.WriteLine("Niña 3: ${porcentaje3:P1} - {monto3:F2");
        Console.WriteLine("Niña 4: ${porcentaje4:P1} - {monto4:F2");
    }
}
