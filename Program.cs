// Treyson Belt
// Final Project
// 7/13/22 - 
Console.Clear();
Console.ForegroundColor = ConsoleColor.White;
int end = 0;

while(end == 0) {
    Explanation();
    Console.Write("What would you like to do? ");
    string decision = Console.ReadLine();
    if (decision == "Roll Dice") {
        Diceroll();
    }
    else if (decision == "End") {
        end = 1;
    }
}
void Explanation() {
    Console.WriteLine(@"Welcome to the DND Assistant. THis will help facilitate an easier play experience.");
}
// problem with this one
void Diceroll() {
    int whatdie = Console.Read();
    if (whatdie == 4) {
        int[] dienum = new int[4] {
            1, 2, 3, 4
        };
    }
    else if (whatdie == 6) {
        int[] dienum = new int[6] {
            1, 2, 3, 4, 5, 6
        };
    }
    else if (whatdie == 8) {
        int[] dienum = new int[8] {
            1, 2, 3, 4, 5, 6, 7, 8
        };
    }
    else if (whatdie == 10) {
        int[] dienum = new int[10] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10
        };
    }
    else if (whatdie == 12) {
        int[] dienum = new int[12] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12
        };
    }
    else if (whatdie == 20) {
        int[] dienum = new int[20] {
            1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,
        };
    }
    Random rnd = new Random();
    //int roll  = rnd.Next(1, dienum.Length);
    //return roll;
}