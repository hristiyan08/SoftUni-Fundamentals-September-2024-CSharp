using System;

class Program
{
    static void Main()
    {
        // Initial balance input
        double balance = double.Parse(Console.ReadLine());
        double spentMoney = 0;
        string input;

        while ((input = Console.ReadLine()) != "Game Time")
        {
            double gamePrice;

            switch (input)
            {
                case "OutFall 4":
                    gamePrice = 39.99;
                    break;
                case "CS: OG":
                    gamePrice = 15.99;
                    break;
                case "Zplinter Zell":
                    gamePrice = 19.99;
                    break;
                case "Honored 2":
                    gamePrice = 59.99;
                    break;
                case "RoverWatch":
                    gamePrice = 29.99;
                    break;
                case "RoverWatch Origins Edition":
                    gamePrice = 39.99;
                    break;
                default:
                    Console.WriteLine("Not Found");
                    continue; // Skip the rest of the loop if the game is not found
            }

            if (balance >= gamePrice)
            {
                balance -= gamePrice;
                spentMoney += gamePrice;
                Console.WriteLine($"Bought {input}");
            }
            else
            {
                Console.WriteLine("Too Expensive");
            }

            // Check if the user has run out of money
            if (balance <= 0)
            {
                Console.WriteLine("Out of money!");
                return;
            }
        }

        // Output the total spent and remaining balance
        Console.WriteLine($"Total spent: ${spentMoney:F2}. Remaining: ${balance:F2}");
    }
}
