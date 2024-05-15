namespace Rollies
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
             * Rollies is a simple game popularized by Critical Roll 
             * it's a simple "who rolls highest on a 20 sided dice?".
             * 
             * Plan: let player click a button to roll, Have an AI roll and compare. 
             * Best out of 3 goes wins.
            */
            int playerRoll;
            int enemyRoll;

            int playerPoints = 0;
            int enemyPoints = 0;
            int totalPoints = playerPoints+enemyPoints;
            
            Random random = new Random();
           
            for (int gameRound = 0; gameRound < 5; gameRound++) 
            {
                Console.WriteLine("Press any button to roll.... \n");

                Console.ReadKey();
                    
                playerRoll = random.Next(1, 21);
                Console.WriteLine("You rolled a.. " +playerRoll);
                if (playerRoll < 6)
                {
                    Console.WriteLine(" oof\n");
                }
                if (playerRoll == 20)
                {
                    Console.WriteLine("NAT 20!\n");
                }

                Console.WriteLine("...");

                System.Threading.Thread.Sleep(1000);

                enemyRoll = random.Next(1, 21);
                Console.WriteLine("Enemy AI Rolled.."+enemyRoll);

                if (enemyRoll < playerRoll)
                {
                    playerPoints++;
                    Console.WriteLine("You got a point!\n");

                }
                if (enemyRoll > playerRoll)
                {
                    enemyPoints++;
                    Console.WriteLine("The AI got a point!\n");
                }
                    
                else if (enemyRoll == playerRoll) 
                {
                    Console.WriteLine("Draw, points for everyone!" + enemyPoints++, playerPoints++, "\n") ;
                }


            }
            // --- Determine winner --- \\
            Console.WriteLine($"you got {playerPoints} points out of 5 ");
            if (playerPoints > enemyPoints)
            {
                Console.WriteLine("you win!");
            }
            else if (enemyPoints > playerPoints)
            {
                Console.WriteLine("you loose!");
            }
        }
    }
}
