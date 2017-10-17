using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmTest
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] test = CreateArray();

            Console.WriteLine("Kies een nummer 1, 2 of 3 om te zien wat uw prijs is.");
            string keus = Console.ReadLine();

            GokkenEnBlijfBijKeuzen(keus);

            int choice = int.Parse(keus);
            try
            {
                Console.WriteLine(test[choice - 1]);
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Het heeft alleen de keus tussen de cijfers 1, 2 of 3. Probeer het opnieuw");
            }
            
        }

        static int[] CreateArray()
        {
            int[] prijzen = new int[3];

            int min = 0;
            int max = 100;
            
            Random nummertjes = new Random();

            for (int i = 0; i < prijzen.Length; i++)
            {
                prijzen[i] = nummertjes.Next(min, max);
            }

            Random arraySize = new Random();
            int prijs = arraySize.Next(3);

            prijzen[prijs] = 100;

            return prijzen;
        }

        static void GokkenEnBlijfBijKeuzen(string nummer)
        {
            int choice = int.Parse(nummer);

            Console.WriteLine("Uw keuze is: " + choice + ". " + "Uw heeft de volgende prijs:");

            //int deKeus = choice - 1;
            //return deKeus;
        }

        static void GokkenEnSwitchVanKeuzen()
        {

        }
    }
}
