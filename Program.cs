// Treyson Belt
// Final Project
// 7/13/22 - 

// This is where we set everything up and start the loop
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
int end = 0;
Explanation();
while(end == 0) {
    // this is the decision tree where you'll
    Console.Write("What would you like to do? ");
    string decision = Console.ReadLine();
    if (decision == "1") {
        Console.WriteLine("What dice?");
        string whatdie = Console.ReadLine();
        if (whatdie == "4") {
            Random rnd = new Random();
            int roll4  = rnd.Next(1, 4);
            Console.WriteLine(roll4);
        }
        else if (whatdie == "6") {
            Random rnd = new Random();
            int roll6  = rnd.Next(1, 6);
            Console.WriteLine(roll6);
        }
        else if (whatdie == "8") {
            Random rnd = new Random();
            int roll8  = rnd.Next(1, 8);
            Console.WriteLine(roll8);
        }
        else if (whatdie == "10") {
            Random rnd = new Random();
            int roll10  = rnd.Next(1, 10);
            Console.WriteLine(roll10);
        }
        else if (whatdie == "12") {
            Random rnd = new Random();
            int roll12  = rnd.Next(1, 12);
            Console.WriteLine(roll12);
        }
        else if (whatdie == "20") {
            Random rnd = new Random();
            int roll20  = rnd.Next(1, 20);
            Console.WriteLine(roll20);
            if (roll20 < 10) {
                Console.WriteLine("Burn these ones.");
            }
        }
        else if (whatdie == "100") {
            Random rnd = new Random();
            int roll100 = rnd.Next(1, 100);
            Console.WriteLine(roll100);
        }
        else {
            Console.WriteLine("Unable to roll non existent dice. please pick a reasonable dice type");
        }
    }
    else if (decision == "4") {
        end = 1;
    }
    else if (decision == "2") {
        Console.Write("Health: ");
        int health = Console.Read();
        int failedsaves = 0;
        string move = "";
        do {
            Console.WriteLine(@"What would you like to do?
    1. Fight
    2. Roll Stat
    3. Take Damage
    4. End");
            move = Console.ReadLine();
            if (move == "1") {
                pFight();
            }
            else if (move == "4") {
                failedsaves = 3;
            }
        } while (failedsaves < 3);
    }
    else if (decision == "3") {
        Console.WriteLine("nope");
    }
    else if (decision == "Help") {
        Console.WriteLine(@" The different types of use:
1. Roll Dice
2. Player Battle (player side of a fight)
3. DM Battle (DM side of battle)
4. End");
    }
}
static void Explanation() {
    Console.WriteLine(@"Welcome to the DND Assistant. THis will help facilitate an easier play experience.");
}

static void pFight() {
    Console.Write("magic or weapon: ");
    string fightmove = Console.ReadLine();
    if (fightmove == "magic") {
        
    }
    else if (fightmove =="weapon") {

        Random random = new Random();
        int attackroll = random.Next(1, 20);
        Console.Write("What is the bonus to d20 roll: ");
        int rollbonus = Console.Read();
        Console.WriteLine(attackroll);
        attackroll = (attackroll + rollbonus);
        Console.WriteLine(attackroll);
    }
}