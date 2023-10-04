using System.Diagnostics;
// ------------------------------------------------------------------
int spelareHP = 100;
int aihp = 100;
int maxskadaspelaren = 35;
int maxskadaai = 35;
int maxrundor = 10;
int lightattackmisschansplayer = 20;
int hardattackmisschansplayer = 40;
int lightattackmisschansai = 20;
int hardattackmisschansai = 40;

String curentenemy = "2";
String inst = "";
String instval = "";
String Spelarename = ("Hero");
String spelaretypavattack = "";          //massa variablar
String aiName = ("Willmer");

Random Skada = new Random();
Random misschans = new Random();
// ------------------------------------------------------------------
while (true)
{
    // ------------------------------------------------------------------
    string köranu = "nej";
    int runda = 0;
    int nuvaranespelarhp = spelareHP;           //mer variablar som startar om varje match
    int nuvaraneaihp = aihp;
    Random aitypavattack = new Random();
    int tmpaitypavattack = aitypavattack.Next(2);
    // ------------------------------------------------------------------
    void instälnignar()
    {
        Console.WriteLine("Välkommen till instälnignar");
        Console.WriteLine("Här kan du välja olika instänlnignar");
        Console.WriteLine("Namn på spelaren(N)");
        Console.WriteLine("Max attack(A)");              //massa olika instänlignar
        Console.WriteLine("Max rundor(R)");
        Console.WriteLine("Spelaren hp(S)");
        Console.WriteLine("Din Light attack miss chans(L)");
        Console.WriteLine("Din Hard attack miss chans(H)");
        Console.WriteLine("");
        Console.WriteLine("För att välja vad du vill ändra så skriv bokstaven brevid instälginar");
        instval = Console.ReadLine();
        instval = instval.ToLower();
        if (instval == "n")
        {
            Console.WriteLine("Här kan du ändra vad din gubbe ska heta");
            Console.WriteLine("Vad vill du ändra nammnet till?");
            Spelarename = "";
            while (Spelarename.Length <= 0 || Spelarename.Length > 20 || int.TryParse(Spelarename, out int y))
            {
                Spelarename = Console.ReadLine();
            }

            Console.Clear();
            instälnignar();

        }
        else if (instval == "a")
        {
            Console.WriteLine("Vad ska max attack för spelaren vara?");
            Console.WriteLine("Just nu är det " + maxskadaspelaren);

            string tmpMaxskada = Console.ReadLine();
            bool success = int.TryParse(tmpMaxskada, out maxskadaspelaren);
            if (success == false)
            {
                Console.WriteLine("Det där var inte en siffra!");
                Console.ReadKey();
            }
            Console.Clear();
            instälnignar();
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
                Console.ReadKey();
            }
            Console.Clear();
            instälnignar();
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
                Console.ReadKey();
            }
            Console.Clear();
            instälnignar();
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
                Console.ReadKey();
            }
            Console.Clear();
            instälnignar();

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
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Jag vet inte vad du sa, skriv igen");
            }
            Console.Clear();
            instälnignar();
        }

    }
    // ------------------------------------------------------------------
    void väljafiende()
    {
        Console.WriteLine("Varje fiende har olika styrkor och svagheter");
        Console.WriteLine("Just nu slåss du mot " + aiName);
        Console.WriteLine("Hans styrkor och svagheter är");
        Console.WriteLine(aihp + " i hp");
        Console.WriteLine(maxskadaai + " I max attack");             //statestik för fiendern
        Console.WriteLine(lightattackmisschansai + "% i misschans när han gör en light attack");
        Console.WriteLine(hardattackmisschansai + "% i misschans när han gör en light attack");

        Console.WriteLine("För att ändra gubbe välj mellan dom här nere");
        Console.WriteLine("Super lätt: Sam (0)");
        Console.WriteLine("Lätt: Liam (1)");
        Console.WriteLine("Mellan: Willmer (2)");
        Console.WriteLine("Svår: Neo (3)");
        Console.WriteLine("Omöjligt: Axel (4)");

        if (curentenemy == "0")
        {
            fiende0();
        }
        else if (curentenemy == "1")
        {
            fiende1();
        }
        else if (curentenemy == "2")
        {                                       //ascii art för fienden
            fiende2();
        }
        else if (curentenemy == "3")
        {
            fiende3();
        }
        else if (curentenemy == "4")
        {
            fiende4();

        }

        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Välj mellan 0-4 för att välja enemy");
        Console.WriteLine("För att lämmna tryck på space");
        curentenemy = Console.ReadLine();

        if (curentenemy == " ")
        {
            Console.Clear();
            startmeny();
        }
        else if (curentenemy == "0")
        {
            aiName = "Sam";
            aihp = 25;
            nuvaraneaihp = 25;
            maxskadaai = 5;
            lightattackmisschansai = 40;
            hardattackmisschansai = 80;        //olika värder för olika fiender
            Console.Clear();
            väljafiende();
        }
        else if (curentenemy == "1")
        {
            aiName = "Liam";
            aihp = 50;
            nuvaraneaihp = 50;
            maxskadaai = 15;
            lightattackmisschansai = 30;
            hardattackmisschansai = 60;
            Console.Clear();
            väljafiende();
        }
        else if (curentenemy == "2")
        {
            aiName = "Wilmer";
            aihp = 100;
            nuvaraneaihp = 100;
            maxskadaai = 35;
            lightattackmisschansai = 20;
            hardattackmisschansai = 40;
            Console.Clear();
            väljafiende();
        }
        else if (curentenemy == "3")
        {
            aiName = "Neo";
            aihp = 150;
            nuvaraneaihp = 150;
            maxskadaai = 40;
            lightattackmisschansai = 10;
            hardattackmisschansai = 20;
            Console.Clear();
            väljafiende();
        }
        else if (curentenemy == "4")
        {
            aiName = "Axel";
            aihp = 250;
            nuvaraneaihp = 250;
            maxskadaai = 50;
            lightattackmisschansai = 5;
            hardattackmisschansai = 10;
            Console.Clear();
            väljafiende();
        }
        else
        {
            curentenemy = "2";
            Console.Clear();
            väljafiende();
        }
    }
    // ------------------------------------------------------------------
    void startmeny()
    {
        Console.Clear();
        Console.WriteLine("Välkomen till Axels slagsmål spel");
        Console.WriteLine("För att gå in i instälnignar tryck på i");
        Console.WriteLine("För att välja fiende tryck på F");
        Console.WriteLine("För att starta spelet tryck på en annan knapp");
        inst = Console.ReadLine();
        inst = inst.ToLower();
        Console.Clear();
        if (inst == "i")                 //startmenyn
        {
            instälnignar();
        }
        else if (inst == "f")
        {
            väljafiende();
        }
        else
        {
            köranu = "ja";
        }
    }
    // ------------------------------------------------------------------
    while (köranu == "nej")
    {                                  // om man ska starta startmenyen eller inte
        startmeny();
    }
    // ------------------------------------------------------------------
    while (nuvaranespelarhp > 0 && nuvaraneaihp > 0 && runda < maxrundor && köranu == "ja")
    {
        Console.WriteLine("          Ny Runda");
        Console.WriteLine("");
        Console.WriteLine(Spelarename + " börjar rundan med " + nuvaranespelarhp + " hp");
        Console.WriteLine(aiName + " börjar rundan med " + nuvaraneaihp + " hp");
        Console.WriteLine("");
        Console.WriteLine("");                             //Start av rundan
        Console.WriteLine("");
        Console.WriteLine("Vill du göra en hard eller light attack?");
        Console.WriteLine("Light(L) eller Hard(H)");
        spelaretypavattack = Console.ReadLine();
        spelaretypavattack = spelaretypavattack.ToLower();
        Console.WriteLine("");
        Console.WriteLine("");
// ------------------------------------------------------------------
        if (spelaretypavattack == "l")
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= lightattackmisschansplayer)
            {
                Console.WriteLine("Du försökte göra en light attack men missade fienden");
            }
            else                        //spelaren lightattack kod
            {
                int spelaredamage = Skada.Next(maxskadaspelaren);
                nuvaraneaihp -= spelaredamage;
                Console.WriteLine(Spelarename + " attakerar " + aiName + " med en light attack och gör " + spelaredamage + " i skada");
                Console.WriteLine(aiName + " har nu " + nuvaraneaihp + " i hp");
            }
        }
        // ------------------------------------------------------------------
        else if (spelaretypavattack == "h")
        {

            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= hardattackmisschansplayer)
            {
                Console.WriteLine("Du försöker göra en hard attack men missade fienden");
            }
            else                //Spelaren hardattack kod
            {
                int spelaredamage = Skada.Next(2 * maxskadaspelaren);
                nuvaraneaihp -= spelaredamage;
                Console.WriteLine(Spelarename + " attakerar " + aiName + " med en hard attack och gör " + spelaredamage + " i skada");
                Console.WriteLine(aiName + " har nu " + nuvaraneaihp + " i hp");
            }
        }
        // ------------------------------------------------------------------
        else                 //om man inte slår
        {
            Console.WriteLine("Du valde inget så du slår inte");
        }
        // ------------------------------------------------------------------
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        if (tmpaitypavattack >= 0)
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= lightattackmisschansai)
            {
                Console.WriteLine(aiName + " försökta göra en lightattack men missade dig");
            }
            else                        //ai lightattack kod
            {
                int aidamage = Skada.Next(maxskadaai);
                nuvaranespelarhp -= aidamage;
                Console.WriteLine(aiName + " attakerar " + Spelarename + " med en lightattack och gör " + aidamage + " i skada");
                Console.WriteLine(Spelarename + " har nu " + nuvaranespelarhp + " i hp");
            }
        }
        // ------------------------------------------------------------------
        else if (tmpaitypavattack <= 1)
        {
            int tempmisschans = misschans.Next(100);
            if (tempmisschans <= hardattackmisschansplayer)
            {
                Console.WriteLine(aiName + " försökte göra en hardattack men missade dig");
            }
            else                   //ai hardattack kod
            {
                int aidamage = Skada.Next(2 * maxskadaai);
                nuvaranespelarhp -= aidamage;
                Console.WriteLine(aiName + " attakerar " + Spelarename + " med en har attack och gör " + aidamage + " i skada");
                Console.WriteLine(Spelarename + " har nu " + nuvaranespelarhp + " i hp");
            }
        }
        // ------------------------------------------------------------------
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");                       //För att starta om rundan
        Console.WriteLine();
        Console.WriteLine("Tryck på en valfri knapp för att köra igen");
        Console.ReadKey();
        Console.Clear();
        runda++;
    }
// ------------------------------------------------------------------
    if (nuvaranespelarhp <= 0 && nuvaraneaihp <= 0)
    {
        Console.WriteLine("Game over");
        Console.WriteLine("Båda dog och det blev ovagjort");
    }
    else if (nuvaranespelarhp <= 0)
{                                                  //för att kolla vem som van
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
// ------------------------------------------------------------------
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");
    Console.WriteLine("");                           //starta om
    Console.WriteLine("Tryck på en valfri knapp för att köra igen");
    Console.ReadKey();
    Console.Clear();
}
// ------------------------------------------------------------------
void fiende0()
{
    Console.WriteLine(@"   ,=''=,
  c , _,{
  /\  @ )                 __
 /  ^~~^\          <=.,__/ '}=
(_/ ,, ,,)          \_ _>_/~
 ~\_(/-\)'-,_,_,_,-'(_)-(_)");
}
void fiende1()                       //ascii art                 
{
    Console.WriteLine(@"      ////\\\\
      |      |
     @  O  O  @
      |  ~   |         \__
       \ -- /          |\ |
     ___|  |___        | \|
    /          \      /|__|
   /            \    / /
  /  /| .  . |\  \  / /
 /  / |      | \  \/ /
<  <  |      |  \   /
 \  \ |  .   |   \_/
  \  \|______|
    \_|______|
      |      |
      |  |   |
      |  |   |
      |__|___|
      |  |  |
      (  (  |
      |  |  |
      |  |  |
     _|  |  |
 cccC_Cccc___)");
}
void fiende2()
{
    Console.WriteLine(@"                 ,#####,
                 #_   _#
                 |a` `a|
                 |  u  |
                 \  =  /
                 |\___/|
        ___ ____/:     :\____ ___
      .'   `.-===-\   /-===-.`   '.
     /      .-'''''-.-'''''-.      \
    /'             =:=             '\
  .'  ' .:    o   -=:=-   o    :. '  `.
  (.'   /'. '-.....-'-.....-' .'\   '.)
  /' ._/   '.     --:--     .''   \_. '\
 |  .'|      '.  ---:---  .'      |'.  |
 |  : |       |  ---:---  |       | :  |
  \ : |       |_____._____|       | : /
  /   (       |----|------|       )   \
 /... .|      |    |      |      |. ...\
|::::/''     /     |       \     ''\::::|
'''''       /'    .L_      `\       '''''
           /'-.,__/` `\__..-'\
          ;      /     \      ;
          :     /       \     |
          |    /         \.   |
          |`../           |  ,/
          ( _ )           |  _)
          |   |           |   |
          |___|           \___|
          :===|            |==|
           \  /            |__|
           /\/\           /'''`8.__
           |oo|           \__.//___)
           |==|
           \__/");
}
void fiende3()
{
    Console.WriteLine(@"                     ______
                   <((((((\\\
                   /      . }\
                   ;--..--._|}
(\                 '--/\--'  )
 \\                | '-'  :'|
  \\               . -==- .-|
   \\               \.__.'   \--._
   [\\          __.--|       //  _/'--.
   \ \\       .'-._ ('-----'/ __/      \
    \ \\     /   __>|      | '--.       |
     \ \\   |   \   |     /    /       /
      \ '\ /     \  |     |  _/       /
       \  \       \ |     | /        /
        \  \      \        /");
}
void fiende4()
{
    Console.WriteLine(@"                                         .''--..__
                     _                     []       ``-.._
                  .'` `'.                  ||__           `-._
                 /    ,-.\                 ||_ ```---..__     `-.
                /    /:::\\               /|//}          ``--._  `.
                |    |:::||              |////}                `-. \
                |    |:::||             //'///                    `.\
                |    |:::||            //  ||'                      `|
                /    |:::|/        _,-//\  ||
               /`    |:::|`-,__,-'`  |/  \ ||
             /`  |   |'' ||           \   |||
           /`    \   |   ||            |  /||
         |`       |  |   |)            \ | ||
        |          \ |   /      ,.__    \| ||
        /           `         /`    `\   | ||
       |                     /        \  / ||
       |                     |        | /  ||
       /         /           |        `(   ||
      /          .           /          )  ||
     |            \          |     ________||
    /             |          /     `-------.|
   |\            /          |              ||
   \/`-._       |           /              ||
    //   `.    /`           |              ||
   //`.    `. |             \              ||
  ///\ `-._  )/             |              ||
 //// )   .(/               |              ||
 ||||   ,'` )               /              //
 ||||  /                    /             || 
 `\\` /`                    |             // 
     |`                     \            ||  
    /                        |           //  
  /`                          \         //   
/`                            |        ||    
`-.___,-.      .-.        ___,'        (/    
         `---'`   `'----'`");
}