using System;

namespace Medidas
{
    class Program
    {
        static void Main(string[] args)
        {
            string entrada;
            double metros, centimetros, quilometros;
            
            Console.WriteLine("Entre com a medida (em metros):");
            entrada = Console.ReadLine();

            metros = Convert.ToDouble(entrada);
            centimetros = metros * 100;
            quilometros = metros / 1000;

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("---Equivalência das medidas---");
            Console.ResetColor();
            Console.WriteLine($"{centimetros} cm");
            Console.WriteLine($"{metros:N2} metros");
            Console.WriteLine($"{quilometros:N3} km");

            
            
        }
    }
}
