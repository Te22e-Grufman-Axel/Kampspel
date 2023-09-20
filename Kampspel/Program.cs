int spelareHP = 100;
int aihp = 100;
int maxskada = 35;
int maxrundor = 5;
int lightattackmisschansplayer = 20;
int hardattackmisschansplayer = 40;
int lightattackmisschansai = 20;
int hardattackmisschansai = 40;


String inst = "";
String instval = "";
String nameval = "";
String Spelarename = ("Hero");
String spelaretypavattack = "";
String aiName = ("Villan");
Random Skada = new Random();
Random misschans = new Random();
while (true)
{
    int runda = 0;
    int nuvaranespelarhp = spelareHP;
    int nuvaraneaihp = aihp;
    Random aitypavattack = new Random();
    int tmpaitypavattack = aitypavattack.Next(2);



    Console.WriteLine("Välkomen till Axels slagsmål spel");
    Console.WriteLine("För att gå in i instälnignar tryck på i");
    Console.WriteLine("För att välja fiende tryck på F");
    Console.WriteLine("För att starta spelet tryck på en annan knapp");
    inst = Console.ReadLine();
    inst = inst.ToLower();
    Console.Clear();
    if (inst == "i")
    {
        Console.WriteLine("Välkommen till instälnignar");
        Console.WriteLine("Här kan du välja olika instänlnignar");
        Console.WriteLine("Namn på spelaren(N)");
        Console.WriteLine("Namn på fiende(F)");
        Console.WriteLine("Max attack(A)");
        Console.WriteLine("Max rundor(R)");
        Console.WriteLine("Spelaren hp(S)");
        Console.WriteLine("Motståndarens hp(M)");
        Console.WriteLine("Din Light attack miss chans(L)");
        Console.WriteLine("Din Hard attack miss chans(H)");
        Console.WriteLine("");
        Console.WriteLine("För att välja vad du vill ändra så skriv bokstaven brevid instälginar");
        instval = Console.ReadLine();
        instval = instval.ToLower();
        if (instval == "n")
        {
            Console.WriteLine("Vad vill du ändra nammnet till?");
            Spelarename = Console.ReadLine();

        }
        else if (instval == "f")
        {
            Console.WriteLine("Välj mellan 3 namn eller skapa dit egna");
            Console.WriteLine("Namn 1: Enemy");
            Console.WriteLine("Name 2: Villan");
            Console.WriteLine("Namn 3; opponent");
            Console.WriteLine("Namn 4: Eget namn");
            Console.WriteLine("Nammnet är just nu " + aiName);
            nameval = Console.ReadLine();
            nameval = nameval.ToLower();
            {
                if (nameval == "1")
                {
                    aiName = "Enemy";
                }
                if (nameval == "2")
                {
                    aiName = "Vilan";
                }
                if (nameval == "3")
                {
                    aiName = "Opponent";
                }
                if (nameval == "4")
                {
                    Console.WriteLine("Vad ska han heta?");
                    aiName = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Vet inte vad du sa, skriv igen");
                }
            }
        }
        else if (instval == "a")
        {
            Console.WriteLine("Vad ska max attack vara?");
            Console.WriteLine("Just nu är det " + maxskada);

            string tmpMaxskada = Console.ReadLine();
            bool success = int.TryParse(tmpMaxskada, out maxskada);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }

        }
        else if (instval == "r")
        {
            Console.WriteLine("Vad ska max rundor vara?");
            Console.WriteLine("Just nu är det " + maxrundor);

            string tmpMaxrundor = Console.ReadLine();
            bool success = int.TryParse(tmpMaxrundor, out maxrundor);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else if (instval == "s")
        {
            Console.WriteLine("Vad ska spelaren ha för hp?");
            Console.WriteLine("Just nu är det " + spelareHP);

            string tmpspelarHp = Console.ReadLine();
            bool success = int.TryParse(tmpspelarHp, out spelareHP);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else if (instval == "m")
        {
            Console.WriteLine("Vad ska " + aiName + " ha för hp");
            Console.WriteLine("Just nu är det " + aihp);

            string tmpaihp = Console.ReadLine();
            bool success = int.TryParse(tmpaihp, out aihp);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
        }
        else if (instval == "l")
        {
            Console.WriteLine("Nu är din chansen att missen en light attack " + lightattackmisschansplayer + "%");
            Console.WriteLine("Vad ska den vara på?");

            string tmpspelarelighmiss = Console.ReadLine();
            bool success = int.TryParse(tmpspelarelighmiss, out lightattackmisschansplayer);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }

        }
        else if (instval == "h")
        {
            Console.WriteLine("Nu är din chansen att missen en hard attack " + hardattackmisschansplayer + "%");
            Console.WriteLine("Vad ska den vara på?");

            string tmpplayerhardmiss = Console.ReadLine();
            bool success = int.TryParse(tmpplayerhardmiss, out lightattackmisschansplayer);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
            }
            else
            {
                Console.WriteLine("Jag vet inte vad du sa, skriv igen");
            }
        }
        else if (inst == "f")
        {
Console.WriteLine("Varje fiende har olika stats");
Console.WriteLine("Just");
        }
    }
    while (nuvaranespelarhp > 0 && nuvaraneaihp > 0 && runda < maxrundor)
    {
        Console.WriteLine("          Ny Runda");
        Console.WriteLine("");
        Console.WriteLine(Spelarename + " börjar rundan med " + nuvaranespelarhp + " hp");
        Console.WriteLine(aiName + " börjar rundan med " + nuvaraneaihp + " hp");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Vill du göra en hard eller light attack?");
        Console.WriteLine("Light(L) eller Hard(H)");
        spelaretypavattack = Console.ReadLine();
        spelaretypavattack = spelaretypavattack.ToLower();
        Console.WriteLine("");
        Console.WriteLine("");

        if (spelaretypavattack == "l")
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= lightattackmisschansplayer)
            {
                Console.WriteLine("Du försökte göra en light attack men missade fienden");
            }
            else
            {
                int spelaredamage = Skada.Next(maxskada);
                nuvaraneaihp -= spelaredamage;
                Console.WriteLine(Spelarename + " attakerar " + aiName + " med en light attack och gör " + spelaredamage + " i skada");
                Console.WriteLine(aiName + " har nu " + nuvaraneaihp + " i hp");
            }
        }
        else if (spelaretypavattack == "h")
        {

            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= hardattackmisschansplayer)
            {
                Console.WriteLine("Du försöker göra en hard attack men missade fienden");
            }
            else
            {
                int spelaredamage = Skada.Next(2 * maxskada);
                nuvaraneaihp -= spelaredamage;
                Console.WriteLine(Spelarename + " attakerar " + aiName + " med en hard attack och gör " + spelaredamage + " i skada");
                Console.WriteLine(aiName + " har nu " + nuvaraneaihp + " i hp");
            }
        }
        else
        {
            Console.WriteLine("Du valde inget så du slår inte");
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        if (tmpaitypavattack == 0)
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= lightattackmisschansplayer)
            {
                Console.WriteLine(aiName + " försökta göra en lightattack men missade dig");
            }
            else
            {
                int aidamage = Skada.Next(maxskada);
                nuvaranespelarhp -= aidamage;
                Console.WriteLine(aiName + " attakerar " + Spelarename + " med en lightattack och gör " + aidamage + " i skada");
                Console.WriteLine(Spelarename + " har nu " + nuvaranespelarhp + " i hp");
            }
        }
        else if (tmpaitypavattack == 1)
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= hardattackmisschansplayer)
            {
                Console.WriteLine(aiName + " försökte göra en hardattack men missade dig");
            }
            else
            {
                int aidamage = Skada.Next(2 * maxskada);
                nuvaranespelarhp -= aidamage;
                Console.WriteLine(aiName + " attakerar " + Spelarename + " med en har attack och gör " + aidamage + " i skada");
                Console.WriteLine(Spelarename + " har nu " + nuvaranespelarhp + " i hp");
            }
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine();
        Console.WriteLine("Tryck på en valfri knapp för att köra igen");
        Console.ReadKey();
        Console.Clear();
        runda++;
    }

    if (nuvaranespelarhp <= 0 && nuvaraneaihp <= 0)
    {
        Console.WriteLine("Game over");
        Console.WriteLine("Båda dog och det blev ovagjort");
    }
    else if (nuvaranespelarhp <= 0)
    {
        Console.WriteLine("Game over");
        Console.WriteLine(aiName + " Vann och dödade " + Spelarename);
    }
    else if (nuvaraneaihp <= 0)
    {
        Console.WriteLine("Game over");
        Console.WriteLine(Spelarename + " vann och dödade " + aiName);
    }
    else
    {
        Console.WriteLine("Game over");
        Console.WriteLine("Slut på rundor");
    }


    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("Tryck på en valfri knapp för att köra igen");
    Console.ReadKey();
    Console.Clear();
}




