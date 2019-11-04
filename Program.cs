using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace undantagshantering
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random(); 
            int speltal = slumpat.Next(); 
         
            bool spela = true; 

            while (!spela)
            {
                Console.Write("\n\tGissa på ett tal mellan 1 och 20: ");
                int tal = Convert.ToInt32(Console.ReadLine());

                if (tal < speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal + " är för litet, försök igen.");
                }

                if (tal > speltal)
                {
                    Console.WriteLine("\tDet inmatade talet " + tal  " är för stort, försök igen.");
                }

                if (tal = speltal)
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                }

                spela = false;

            }

        }
    }
}
