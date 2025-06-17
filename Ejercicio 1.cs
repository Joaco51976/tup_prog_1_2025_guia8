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
            int cantidad = 0;
            int max = 0;
            int min = 0;
            int suma = 0;
            int contador = 0;
            bool hayDatos = false;

            int opcion;

            do
            {
                Console.WriteLine("1 - Procesar un solo número");
                Console.WriteLine("2 - Procesar varios números");
                Console.WriteLine("3 - Mostrar máximo y mínimo");
                Console.WriteLine("4 - Mostrar promedio");
                Console.WriteLine("5 - Mostrar cantidad de números ingresados");
                Console.WriteLine("6 - Reiniciar variables");
                Console.WriteLine("0 - Salir");
                Console.Write("Opción: ");
                opcion = int.Parse(Console.ReadLine());

                if (opcion == 1)
                {
                    Console.Write("Ingrese un número: ");
                    int num = int.Parse(Console.ReadLine());
                    if (!hayDatos)
                    {
                        max = min = num;
                        hayDatos = true;
                    }
                    else
                    {
                        if (num > max) max = num;
                        if (num < min) min = num;
                    }
                    suma += num;
                    contador++;
                    Console.WriteLine("Número procesado.");
                }
                else if (opcion == 2)
                {
                    Console.Write("¿Cuántos números va a ingresar?: ");
                    cantidad = int.Parse(Console.ReadLine());
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.Write("Ingrese número " + (i + 1) + ": ");
                        int num = int.Parse(Console.ReadLine());
                        if (!hayDatos)
                        {
                            max = min = num;
                            hayDatos = true;
                        }
                        else
                        {
                            if (num > max) max = num;
                            if (num < min) min = num;
                        }
                        suma += num;
                        contador++;
                    }
                    Console.WriteLine("Números procesados.");
                }
                else if (opcion == 3)
                {
                    if (hayDatos)
                    {
                        Console.WriteLine("Máximo: " + max);
                        Console.WriteLine("Mínimo: " + min);
                    }
                    else
                        Console.WriteLine("No hay datos cargados.");
                }
                else if (opcion == 4)
                {
                    if (contador > 0)
                        Console.WriteLine("Promedio: " + (suma / (double)contador));
                    else
                        Console.WriteLine("No hay datos para calcular promedio.");
                }
                else if (opcion == 5)
                {
                    Console.WriteLine("Cantidad de números ingresados: " + contador);
                }
                else if (opcion == 6)
                {
                    cantidad = 0;
                    max = 0;
                    min = 0;
                    suma = 0;
                    contador = 0;
                    hayDatos = false;
                    Console.WriteLine("Variables reiniciadas.");
                }

            } while (opcion != 0);

            Console.WriteLine("Programa finalizado.");
        }
    }
}