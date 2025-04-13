using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmunka
{
    internal class erdoResz
    {
        public static  void erdoEsemeny() 
        {
            Random rng = new Random();

            Console.WriteLine("Bemész az erdőbe? (y/n)");
            string valasz = Console.ReadLine();

            //Bemész az erdőbe
            if (valasz == "y")
            {
                int ellenfel = rng.Next(1, 10);
                Console.WriteLine();
                if (ellenfel == 1 || ellenfel == 2 || ellenfel == 3)
                {
                    Console.WriteLine("Elindulsz az ösvényen, egy darabig mész azután a bokorból elő másszik az ellenfeled");
                    harc.kobold.harcKobold();
                }
                else if (ellenfel == 4|| ellenfel == 5 || ellenfel == 6)
                {
                    Console.WriteLine("Elindulsz az ösvényen, egy darabig mész azután a bokorból elő másszik az ellenfeled");
                    harc.farkas.harcFarkas();
                }
                else if (ellenfel == 7)
                {
                    Console.WriteLine("Elindulsz az ösvényen, egy darabig mész azután a bokorból elő másszik az ellenfeled");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Szia uram! Nem lenne kedve adakozni egy kicsit?");
                    harc.bandita.banditaHarc();
                }
                else
                {
                    Console.WriteLine("Elindulsz az ösvényen, egy darabig mész azután nem történt semmi. Szerencsére");
                    Console.ReadKey();
                }

            }
            //nem mész be az erdőbe
            else if (valasz == "n")
            {
                Console.WriteLine();
                Console.WriteLine("Inadba száll a bátorságot és inkább úgy döntöttél, hogy megvárod a segítséget. Mondani se kell, hogy ez egy rossz döntés volt." +
                    " BAD END");
                Console.ReadKey();
                Environment.Exit(0);  
            }
            else
            {
                Console.WriteLine("Nem értelmezhető a válasz");
                Console.ReadKey();
                Environment.Exit(0);
            }

            //Következő esemény
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Ahogy egyre mélyebre kerülsz az erdőbe úgy egyre közelebb leszel az erdőben lévő barlanghoz" +
                " normál esetben elkerölőd azt a helyet, de lábnyomokat veszel észre melyek arra felé tartanak");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Tudod, hogy anyukád sosem csinálna olyan meggondolatlanságot, hogy bemegy a barlanga mert tudod, hogy tudja az anyukád a barlang veszélyeiről" +
                " de ha mégis van rá egy halvány esély van arra, hogy ezzek az ő lábnyomai akkor nem hagyhatod figyelmen kívűl.");
            Console.WriteLine();
            Console.ReadLine();

            Console.WriteLine("Demo vége");
            Console.ReadKey();
        }
    }
}
