using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmunka
{
    internal class harc
    {
        //Szörny: Kobold
        public class kobold
        {
            public static void harcKobold()
            {
                string enemyName = "Kobold";
               
                int playerHp = 100;
                int enemyHp = 100;
                Random rng = new Random();

                Console.WriteLine("Körökre osztott harc kezdődik!");
                Console.WriteLine($"Te vs. {enemyName}\n");

                while (playerHp > 0 && enemyHp > 0)
                {
                    // Játékos köre
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--- Te következel ---");
                    Console.WriteLine("1. Támadás");
                    Console.WriteLine("2. Gyógyulás");

                    Console.Write("Válassz (1/2): ");


                    string valasz = Console.ReadLine();
                    //Harc - Támadás
                    if (valasz == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int sebzes = rng.Next(10, 21);
                        enemyHp -= sebzes;
                        Console.WriteLine($"Támadtál és {sebzes} sebzést okoztál az ellenségnek!");
                    }
                    //Gyógyítás
                    else if (valasz == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int gyogy = rng.Next(14, 28);
                        playerHp += gyogy;
                        Console.WriteLine($"Meggyógyultál {gyogy} életerővel!");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Érvénytelen választás, kimaradt a köröd!");
                    }

                    // Ellenfél köre, ha még él
                    if (enemyHp > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n--- {enemyName} köre ---");
                        int enemyAttack = rng.Next(9, 21);
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Az {enemyName} megtámadott és {enemyAttack} sebzést okozott!");
                    }

                    // Állapot
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n[Állapot] Te: {playerHp} HP | {enemyName}: {enemyHp} HP");
                }

                // Játék vége
                Console.WriteLine("\n--- Harc vége ---");
                if (playerHp <= 0 && enemyHp <= 0)
                {
                    Console.WriteLine("Döntetlen!");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (playerHp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gratulálok! Legyőzted az ellenfeled !");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Vesztettél! A {enemyName} legyőzött.");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.WriteLine("\nNyomj Entert a folytatáshoz...");
                Console.ReadLine();
            }
        }

        //Szörny: Farkas
        public class farkas
        {
            public static void harcFarkas()
            {
                string enemyName = "Farkas";    

                int playerHp = 100;
                int enemyHp = 100;
                Random rng = new Random();

                Console.WriteLine("Körökre osztott harc kezdődik!");
                Console.WriteLine($"Te vs. {enemyName}\n");

                while (playerHp > 0 && enemyHp > 0)
                {
                    // Játékos köre
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--- Te következel ---");
                    Console.WriteLine("1. Támadás");
                    Console.WriteLine("2. Gyógyulás");

                    Console.Write("Válassz (1/2): ");


                    string valasz = Console.ReadLine();
                    if (valasz == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int sebzes = rng.Next(10, 21);
                        enemyHp -= sebzes;
                        Console.WriteLine($"Támadtál és {sebzes} sebzést okoztál az ellenségnek!");
                    }
                    else if (valasz == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int gyogy = rng.Next(19, 28);
                        playerHp += gyogy;
                        Console.WriteLine($"Meggyógyultál {gyogy} életerővel!");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Érvénytelen választás, kimaradt a köröd!");
                    }

                    // Ellenfél köre, ha még él
                    if (enemyHp > 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n--- {enemyName} köre ---");
                        int enemyAttack = rng.Next(11, 27);
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Az {enemyName} megtámadott és {enemyAttack} sebzést okozott!");
                    }

                    // Állapot
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n[Állapot] Te: {playerHp} HP | {enemyName}: {enemyHp} HP");
                }

                // Játék vége
                Console.WriteLine("\n--- Harc vége ---");
                if (playerHp <= 0 && enemyHp <= 0)
                {
                    Console.WriteLine("Döntetlen!");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);

                }
                else if (playerHp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gratulálok! Legyőzted az ellenfeled !");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Vesztettél! A {enemyName} legyőzött.");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

                Console.WriteLine("\nNyomj Entert a kilépéshez...");
                Console.ReadLine();
            }
        } 

        //Ember: Bandita
        public class bandita
        {
            public static void banditaHarc()
            {
                string enemyName = "Bandita";

                int playerHp = 100;
                int enemyHp = 100;
                Random rng = new Random();
                Console.WriteLine();
                Console.WriteLine("Körökre osztott harc kezdődik!");
                Console.WriteLine($"Te vs. {enemyName}\n");

                while (playerHp > 0 && enemyHp > 0)
                {
                    // Játékos köre
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("\n--- Te következel ---");
                    Console.WriteLine("1. Támadás");
                    Console.WriteLine("2. Gyógyulás");

                    Console.Write("Válassz (1/2): ");


                    string valasz = Console.ReadLine();
                    //Harc - Támadás
                    if (valasz == "1")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int sebzes = rng.Next(10, 21);
                        enemyHp -= sebzes;
                        Console.WriteLine($"Támadtál és {sebzes} sebzést okoztál az ellenségnek!");
                    }
                    //Gyógyítás
                    else if (valasz == "2")
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        int gyogy = rng.Next(14, 28);
                        playerHp += gyogy;
                        Console.WriteLine($"Meggyógyultál {gyogy} életerővel!");
                    }

                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Érvénytelen választás, kimaradt a köröd!");
                    }

                    // Ellenfél köre, ha még él
                    if (enemyHp > 0)
                    {
                        

                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n--- {enemyName} köre ---");
                        //Bandita beszolások
                        int beszed = rng.Next(1, 6);
                        if (beszed == 1 || beszed == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Azt hiszed te vagy a Károly öcsi?");
                        }
                        else if (beszed == 3 || beszed == 4)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Nézzed má' ágaskodsz mint valami occso Yuri Boyka");
                        }
                        else if (beszed == 5 || beszed == 6)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Jaj, mindjárt tele a gatya annyira félek töled");
                        }
                        

                        int enemyAttack = rng.Next(8, 19);
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Az {enemyName} megtámadott és {enemyAttack} sebzést okozott!");

                    }

                    // Állapot
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"\n[Állapot] Te: {playerHp} HP | {enemyName}: {enemyHp} HP");
                }

                // Játék vége
                Console.WriteLine("\n--- Harc vége ---");
                if (playerHp <= 0 && enemyHp <= 0)
                {
                    Console.WriteLine("Döntetlen!");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }
                else if (playerHp > 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Megmondalak a bátyámnak *elfutt*");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Gratulálok! Legyőzted az ellenfeled !");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Vesztettél! A {enemyName} legyőzött.");
                    Console.WriteLine("BAD END");
                    Console.ReadLine();
                    Environment.Exit(0);
                }

            }
        }
    }
}
