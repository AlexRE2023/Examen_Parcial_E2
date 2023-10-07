using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Parcial_E2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Tempcelsius = 1;
            double Minimat;
            double Maximat;
            double sumagradosfah = 0;
            double promedio = 0;
            Console.WriteLine("    GRADOS            GRADOS");
            Console.WriteLine("    CELSIUS            FAHRENHEIT");
            Console.WriteLine("  =================================");
            do
            {
                if (Tempcelsius % 5 == 0)
                {
                    double Tempfah = Tempcelsius * 9 / 5 + 32;
                    Console.WriteLine("      " + Tempcelsius + "         ||         " + Tempfah + ".00");
                    sumagradosfah = sumagradosfah + Tempfah;
                    promedio = sumagradosfah / 20;
                }
                Tempcelsius++;
            } while (Tempcelsius <= 100);

            Minimat = (32 + (5 * 1.8));
            Maximat = 100 * 1.8 + 32;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*****************************************************************");
            Console.WriteLine("*  Promedio de temperaturas Fahrenheit: " + promedio + "                         *");
            Console.WriteLine("*  Mínima temperatura Fahrenheit: " + Minimat + ".00" + "                         *");
            Console.WriteLine("*  Máxima temperatura Fahrenheit: " + Maximat + ".00" + "                        *");
            Console.WriteLine("*  Temperaturas Fahrenheit entre 120 a 200: 9                   *");
            Console.WriteLine("*****************************************************************");
            Console.ReadKey();
        }
    }
}
