using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace complete_me
{
    class Program
    {
        static void Main(string[] args)
        {
            Random slumpat = new Random(); 
            int speltal = slumpat.Next(1,20);//Lade till så att det rollas fram ett tal mellan 1 och 20. 
            int tal=0; // deklarerar tal utanför try/catchen för att den inte ska bli lokal för det kodblocket.
            bool spela = true; 

            Console.Write("\n\tGissa på ett tal mellan 1 och 20: "); // flyttade ut kodraden så den inte körs varje gång man loopar.
            while (spela)// Ta bort ! för att komma in i while-loopen
            {
            string input = Console.ReadLine(); // tar in input som en sträng
            input=input.ToLower();//Konverterar till lowercase
            //switch för att avsluta vid rätt kommando, annars ska det konverteras till int.
            switch(input)
            {
                case "q":
                {
                    return;
                }

                default:
                {
                    try
                    {
                    tal = Convert.ToInt32(input);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine("\n\tWrong input");
                        throw e; // Det stod att man skulle använda throw.
                    }

                }break;
            }
                //Gjorde om writeline till write, för att jag föredrar att ha det så. 
                //Tydliggjorde att man skulle ange ett nytt tal eftersom jag valde att ha "gissa talet" utanför loopen.
                if (tal < speltal)
                {
                    Console.Write("\tDet inmatade talet " + tal + " är för litet, försök igen: ");
                }

                else if (tal > speltal)//lagt till else-satser.
                {
                    Console.Write("\tDet inmatade talet " + tal + " är för stort, försök igen: ");// Lade till ett + för att kunna läsa in nästa textsträng.
                }

                else if (tal == speltal)//Lade till ett = för ett ensamt = är en tilldelningsoperator.
                {
                    Console.WriteLine("\tGrattis, du gissade rätt!");
                    spela = false;// flyttade på bool-tilldelningen så att den sker vid rätt tillfälle.
                }


            }

        }
    }
}
