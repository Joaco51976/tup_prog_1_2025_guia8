using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayorValor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int puntosJugador1 = 0;
            int puntosJugador2 = 0;

            Console.Write("Ingrese el nombre del jugador 1: ");
            string jugador1 = Console.ReadLine();

            Console.Write("Ingrese el nombre del jugador 2: ");
            string jugador2 = Console.ReadLine();

            for (int set = 1; set <= 3; set++)
            {
                Console.WriteLine($"Set: {set}");

                Console.Write($"Ingrese el resultado del set {set} para {jugador1}: ");
                int resultado1 = int.Parse(Console.ReadLine());

                Console.Write($"Ingrese el resultado del set {set} para {jugador2}: ");
                int resultado2 = int.Parse(Console.ReadLine());

                if (resultado1 > resultado2)
                    puntosJugador1++;
                else if (resultado2 > resultado1)
                    puntosJugador2++;
            }

            Console.WriteLine("Resultado final:");
            Console.WriteLine($"{jugador1}: {puntosJugador1} sets ganados");
            Console.WriteLine($"{jugador2}: {puntosJugador2} sets ganados");

            if (puntosJugador1 > puntosJugador2)
                Console.WriteLine($"{jugador1} ganó el partido");
            else if (puntosJugador2 > puntosJugador1)
                Console.WriteLine($"{jugador2} ganó el partido");
            else
                Console.WriteLine("Empate!");
        }
    }
}