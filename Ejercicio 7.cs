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
            int num1 = 1, rubro1 = 1, cant1 = 1;
            decimal monto1 = 22000;

            int num2 = 2, rubro2 = 3, cant2 = 2;
            decimal monto2 = 23333;

            int num3 = 3, rubro3 = 5, cant3 = 5;
            decimal monto3 = 78555;

            int num4 = 4, rubro4 = 3, cant4 = 2;
            decimal monto4 = 23434;

            int num5 = 5, rubro5 = 2, cant5 = 4;
            decimal monto5 = 23434;

            decimal total = monto1 + monto2 + monto3 + monto4 + monto5;

            int mayorTrans = num1;
            decimal mayorMonto = monto1;

            if (monto2 > mayorMonto) { mayorMonto = monto2; mayorTrans = num2; }
            if (monto3 > mayorMonto) { mayorMonto = monto3; mayorTrans = num3; }
            if (monto4 > mayorMonto) { mayorMonto = monto4; mayorTrans = num4; }
            if (monto5 > mayorMonto) { mayorMonto = monto5; mayorTrans = num5; }

            int totalCant = cant1 + cant2 + cant3 + cant4 + cant5;

            int[] cantidadesPorRubro = new int[6];
            cantidadesPorRubro[rubro1] += cant1;
            cantidadesPorRubro[rubro2] += cant2;
            cantidadesPorRubro[rubro3] += cant3;
            cantidadesPorRubro[rubro4] += cant4;
            cantidadesPorRubro[rubro5] += cant5;

            Console.WriteLine("Transacción con mayor monto: " + mayorTrans);
            Console.WriteLine("Recaudación total: $" + total);

            Console.WriteLine("Porcentaje por rubro:");
            for (int i = 1; i <= 5; i++)
            {
                double porcentaje = totalCant > 0 ? (cantidadesPorRubro[i] * 100.0) / totalCant : 0;
                Console.WriteLine("Rubro " + i + ": " + porcentaje.ToString("0.00") + "%");
            }
        }
    }
}