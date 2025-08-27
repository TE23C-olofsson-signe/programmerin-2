Fightsim(); 

static void Fightsim()
{
    bool fråga = true; 
    while (fråga)
    {
        bool clear = false;
        int p1Hp = 100;
        int p2Hp = 150;

        string p1Name = "";
        string p2Name = "martin";

        while (!clear)
        {
            Console.WriteLine("Skriv ett namn för både spelarna ");
            p1Name = Console.ReadLine();


            if (p1Name.Length > 0)
            {
                clear = true;
            }
            else
            {
                Console.WriteLine("skriv något");
            }

        }

        Console.WriteLine($"{p1Name} vs {p2Name} - FIGHT!");

        while (p1Hp > 0 && p2Hp > 0)
        {
            Console.WriteLine($"{p1Name}:{p1Hp}");
            Console.WriteLine($"{p2Name}:{p2Hp}");

            int p1Damage = Random.Shared.Next(25);
            int p2Damage = Random.Shared.Next(15);

            p2Hp -= p1Damage;
            Console.WriteLine($"{p1Name} gör {p1Damage} i skada på {p2Name}");
            p1Hp -= p2Damage;
            Console.WriteLine($"{p2Name} gör {p2Damage} i skada på {p1Name}");
            Console.ReadLine();
        }

        if (p1Hp <= 0 && p2Hp <= 0)
        {
            Console.WriteLine($"{p1Name} och {p2Name} svimmade båda");
        }
        else if (p2Hp <= 0)
        {
            Console.WriteLine($"{p2Name} vann!");
        }
        else
        {
            Console.WriteLine($"{p1Name} vann!");
        }

        Console.WriteLine($"vill du sluta spela tryck n ");

        ConsoleKeyInfo key = Console.ReadKey();

        if (key.KeyChar == 'n')
        {
            fråga = false;
        }
    }


    Console.ReadLine();
}
