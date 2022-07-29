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
        int dice = 0;
        rollDice(dice);
    }
    else if (decision == "3") {
        end = 1;
    }
    else if (decision == "2") {
        Console.Write("Health: ");
        int health = Console.Read();
        health = health - 48;
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
            else if (move == "2") {
                Random random = new Random();
                int skillroll = random.Next(1, 21);
                Console.Write("What is the bonus to d20 roll: ");
                string rollbonus = Console.ReadLine();
                int rolbonus = int.Parse(rollbonus);
                skillroll = (skillroll + rolbonus);
                Console.WriteLine(skillroll);
            }
            else if (move == "3") {
                Console.Write("Damage: ");
                string damagetaken = Console.ReadLine();
                int damage = int.Parse(damagetaken);
                health = health - damage;
                Console.WriteLine($"You have {health} health left.");
                if (health <= 0) {
                    Random random = new Random();
                    int deathsave = random.Next(1, 21);
                    if (deathsave < 10) {
                        Console.WriteLine("You have lost another death save.");
                        failedsaves = failedsaves + 1;
                    }
                }
            }
            else if (move == "4") {
                failedsaves = 3;
            }
        } while (failedsaves < 3);
    }
    else if (decision == "Help") {
        Console.WriteLine(@" The different types of use:
1. Roll Dice
2. Player Battle (player side of a fight)
3. End");
    }
}
static void Explanation() {
    Console.WriteLine(@"Welcome to the DND Assistant. THis will help facilitate an easier play experience.");
}

int rollDice(int roll) {
            Console.WriteLine("What dice?");
        string whatdie = Console.ReadLine();
        if (whatdie == "4") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 5);
            return roll;
        }
        else if (whatdie == "6") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 7);
            return roll;
        }
        else if (whatdie == "8") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 9);
            return roll;
        }
        else if (whatdie == "10") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 11);
            return roll;
        }
        else if (whatdie == "12") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 13);
            return roll;
        }
        else if (whatdie == "20") {
            Random rnd = new Random();
            roll  = rnd.Next(1, 21);
            if (roll < 10) {
                Console.WriteLine("Burn these ones.");
            }
            return roll;
        }
        else if (whatdie == "100") {
            Random rnd = new Random();
            roll = rnd.Next(1, 101);
            Console.WriteLine(roll);
            return roll;
        }
        else {
            Console.WriteLine("Unable to roll non existent dice. please pick a reasonable dice type");
            roll = 0;
            
            return roll;
        }
}
void pFight() {
    Console.Write("magic or weapon: ");
    string fightmove = Console.ReadLine();
    if (fightmove == "magic") {
        Console.Write("Spell save or ranged attack: ");
        string fightmove2 = Console.ReadLine();
        if (fightmove2 == "Spell Save") {
            int damageroll = 0;
            rollDice(damageroll);
            Console.Write("bonus: ");
            int bonus = Console.Read();
            bonus = bonus - 48;
            damageroll = damageroll + bonus;
            Console.WriteLine($"Damage: {damageroll}");
        }
        else if (fightmove2 == "Ranged Attack") {
        Random random = new Random();
        int attackroll = random.Next(1, 21);
        Console.Write("What is the bonus to d20 roll: ");
        int rollbonus = Console.Read();
        rollbonus = rollbonus - 48;
        attackroll = (attackroll + rollbonus);
        Console.WriteLine(attackroll);
        Console.Write("Hit or Miss? ");
        string guessinevermisshuh = Console.ReadLine();
        if (guessinevermisshuh == "Hit") {
            int damageroll = 0;
            rollDice(damageroll);
            Console.Write("bonus: ");
            int bonus = Console.Read();
            bonus = bonus - 48;
            damageroll = damageroll + bonus;
            Console.WriteLine($"Damage: {damageroll}");
        }
        else if (guessinevermisshuh == "Miss") {
            Console.WriteLine("OOF!");
        }
        else {
            Console.WriteLine($"Unable to provide {guessinevermisshuh}.");
        }
        }
    }
    else if (fightmove =="weapon") {

        Random random = new Random();
        int attackroll = random.Next(1, 21);
        Console.Write("What is the bonus to d20 roll: ");
        int rollbonus = Console.Read();
        rollbonus = rollbonus - 48;
        attackroll = (attackroll + rollbonus);
        Console.WriteLine(attackroll);
        Console.WriteLine("Hit or Miss? ");
        string guessinevermisshuh = Console.ReadLine();
        if (guessinevermisshuh == "Hit") {
            int damageroll = 0;
            rollDice(damageroll);
            Console.Write("bonus: ");
            int bonus = Console.Read();
            bonus = bonus - 48;
            damageroll = damageroll + bonus;
            Console.WriteLine($"Damage: {damageroll}");
        }
        else if (guessinevermisshuh == "Miss") {
            Console.WriteLine("OOF!");
        }
        else {
            Console.WriteLine($"Unable to provide {guessinevermisshuh}.");
        }
    }
}