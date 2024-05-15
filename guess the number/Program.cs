namespace guess_the_number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            do
            {
                PlayGame();
                Console.WriteLine("Want to play again? Y for yes, N for no");
            } while (Console.ReadLine().ToLower() == "y");
        }
        private static void PlayGame()
        { 

            Random num = new Random();
            int returnValue = num.Next(1, 100);
            int Guess = 0;

            Console.WriteLine("Guess a number between 1 and 100! I'll tell you whether you're correct or not");

           

            {

                while (Guess != returnValue)
                {
                    Guess = Convert.ToInt32(Console.ReadLine());

                    if (Guess < returnValue)
                    {
                        Console.WriteLine("Wrong. My number is higher than " + Guess + "Try again!");
                    }
                    else if (Guess > returnValue)
                    {
                        Console.WriteLine("Wrong. My number is lower than" + Guess + "Try again!");
                    }
                }
                Console.WriteLine("You did it! The answer was" + returnValue);
                Console.ReadLine();
                
            }
        }
    }
}
