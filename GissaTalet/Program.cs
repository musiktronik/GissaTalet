/* GissaTalet
 * Ett program som slumpar fram ett heltal
 * mellan 1 - 100 och låter användaren få gissa talet.
 * Programmet anger om gissningen var rätt, för hög eller för låg.
 * Antalet gissningar räknas och presenteras i slutet.
 * 
 * Roger Sundh
 * 2015-01-22
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GissaTalet
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int correctNumber = random.Next(1, 100);

            int nrTries = 0;
            Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
            while (true)
            {
                nrTries++;
                Console.Write("Vad gissar du på?: ");
                string str = Console.ReadLine();
                int guess = Convert.ToInt32(str);

                // Kontrollera gissningen:
                if (guess < correctNumber)
                    Console.WriteLine("Fel! Talet är större!");
                else if (guess > correctNumber)
                    Console.WriteLine("Fel! Talet är mindre!");
                else
                    break;

            }

            Console.WriteLine("Du gissade rätt efter {0} gissningar!", nrTries);
        }
    }
}
