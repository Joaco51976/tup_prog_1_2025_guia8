using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese número de mes (1 a 12): ");
            int mes = int.Parse(Console.ReadLine());

            Console.Write("Ingrese año: ");
            int año = int.Parse(Console.ReadLine());

            bool bisiesto;

            if (año % 4 == 0)
            {
                if (año % 100 != 0 || año % 400 == 0)
                    bisiesto = true;
                else
                    bisiesto = false;
            }
            else
            {
                bisiesto = false;
            }

            if (bisiesto)
                Console.WriteLine("El año es bisiesto.");
            else
                Console.WriteLine("El año NO es bisiesto.");

            int dias;

            if (mes == 2)
            {
                if (bisiesto)
                    dias = 29;
                else
                    dias = 28;
            }
            else if (mes == 4 || mes == 6 || mes == 9 || mes == 11)
                dias = 30;
            else
                dias = 31;

            Console.WriteLine("El mes tiene " + dias + " días.");
        }
    }
}