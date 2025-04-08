using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projektmunka
{
    internal class harc
    {
        class TurnBasedGame
        {
            static void Main()
            {
                int playerHp = 100;
                int enemyHp = 100;
                Random rng = new Random();

                Console.WriteLine("Körökre osztott harc kezdődik!");
                Console.WriteLine("Te vs. Szörny\n");

                while (playerHp > 0 && enemyHp > 0)
                {
                    // Játékos köre
                    Console.WriteLine("\n--- Te következel ---");
                    Console.WriteLine("1. Támadás (10-20 sebzés)");
                    Console.WriteLine("2. Gyógyulás (+10-15 HP)");

                    Console.Write("Válassz (1/2): ");

                    string valasz = Console.ReadLine();
                    if (valasz == "1")
                    {
                        int sebzes = rng.Next(10, 21);
                        enemyHp -= sebzes;
                        Console.WriteLine($"Támadtál és {sebzes} sebzést okoztál az ellenségnek!");
                    }
                    else if (valasz == "2")
                    {
                        int gyogy = rng.Next(10, 16);
                        playerHp += gyogy;
                        Console.WriteLine($"Meggyógyultál {gyogy} életerővel!");
                    }

                    else
                    {
                        Console.WriteLine("Érvénytelen választás, kimaradt a köröd!");
                    }

                    // Ellenfél köre, ha még él
                    if (enemyHp > 0)
                    {
                        Console.WriteLine("\n--- Ellenség köre ---");
                        int enemyAttack = rng.Next(5, 16);
                        playerHp -= enemyAttack;
                        Console.WriteLine($"Az ellenség megtámadott és {enemyAttack} sebzést okozott!");
                    }

                    // Állapot
                    Console.WriteLine($"\n[Állapot] Te: {playerHp} HP | Szörny: {enemyHp} HP");
                }

                // Játék vége
                Console.WriteLine("\n--- Harc vége ---");
                if (playerHp <= 0 && enemyHp <= 0)
                {
                    Console.WriteLine("Döntetlen!");
                }
                else if (playerHp > 0)
                {
                    Console.WriteLine("Gratulálok! Legyőzted az ellenfeled !");
                }
                else
                {
                    Console.WriteLine("Vesztettél! A szörny legyőzött.");
                }

                Console.WriteLine("\nNyomj Entert a kilépéshez...");
                Console.ReadLine();
            }
        }
    }
}
