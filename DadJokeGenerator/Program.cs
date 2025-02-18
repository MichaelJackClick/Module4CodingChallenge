using System;

class DadJokeGenerator
{
    static void Main()
    {
        // Array of 12 dad jokes I found online
        string[] dadJokes = {
            "Why don’t skeletons fight each other? They don’t have the guts.",
            "What do you call fake spaghetti? An impasta.",
            "I told my wife she should embrace her mistakes. She gave me a hug.",
            "Why couldn’t the bicycle stand up by itself? It was two-tired.",
            "Why do cows have hooves instead of feet? Because they lactose.",
            "Did you hear about the guy who invented Lifesavers? He made a mint.",
            "I used to play piano by ear, but now I use my hands.",
            "Why don’t eggs tell jokes? They’d crack each other up.",
            "I would avoid the sushi if I was you. It’s a little fishy.",
            "Why did the scarecrow win an award? Because he was outstanding in his field.",
            "What do you call cheese that isn't yours? Nacho cheese.",
            "Why can’t you hear a pterodactyl go to the bathroom? Because the ‘P’ is silent."
        };
        //this makes the jokes random and allows the user to control when to stop
        Random random = new Random();
        bool showMoreJokes = true;

        while (showMoreJokes)
        {
            Console.Clear();
            Console.WriteLine("Here are some dad jokes for you:\n");

            // This displays two random jokes
            for (int i = 0; i < 2; i++)
            {
                int index = random.Next(dadJokes.Length);
                Console.WriteLine($"- {dadJokes[index]}");
            }

            Console.Write("\nWould you like to hear more dad jokes? (yes/no): ");
            string response = Console.ReadLine().Trim().ToLower();

            // This continues the loop if the user wants more jokes
            showMoreJokes = (response == "yes");
        }

        Console.WriteLine("\nThanks for enjoying some dad jokes! Have a great day!");
    }
}
