using Mission2;
internal class Program
{
    private static void Main(string[] args)
    {
        //Declare variables
        int numDiceRolls = 0;
        int numTotal = 0;
        double numPercent = 0.0;

        //Call DiceRoller
        DiceRoller dr = new DiceRoller();

        //Ask user for number of dice rolls
        Console.WriteLine("Welcome to the dice throwing simulator!\n\nHow many dice rolls would you like to simulate?");
        numDiceRolls = int.Parse(Console.ReadLine());

        //Roll dice
        int [] diceRollArray = dr.RollDice(numDiceRolls);

        //Display results
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS" +
                          "\nEach \"*\" represents 1% of the total number of rolls." +
                          "\nTotal number of rolls = " + numDiceRolls + ".\n");

        //Calculate results
        for (int i = 2; i <= 12; i++)
        {
            for (int j = 0; j < numDiceRolls; j++)
            {
                if (diceRollArray[j] == i)
                {
                    numTotal++;
                }
            }

            numPercent = ((double)numTotal / numDiceRolls) * 100;
            numPercent = Math.Round(numPercent);

            if (i < 10)
            {
                Console.Write(i + ":  ");
            }
            else
            {
                Console.Write(i + ": ");
            }

            //Display histogram one bar at a time
            for (int j = 0; j < numPercent; j++)
            {
                Console.Write("*");
            }

            //Reset numTotal and add a new line
            numTotal = 0;
            Console.WriteLine();
        }

        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}