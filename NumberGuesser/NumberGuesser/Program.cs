using System;


//Namespace
namespace NumberGuesser
{
    public class Helper
    {
        public String name = "In C#";
        int[] newArray = { 5, 6, 7 };

    }

    //Main Class
    class Program
    {

        //Entry Point Method
        static void Main(string[] args)
        {
            Helper helper = new Helper();

            //Start Here
            string gameName = "Number Guesser" + " " + helper.name;
            String name = "Utsab";
           
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Hello World!  This is " + name + " ");
            Console.ResetColor();



            while (true) { 

            Console.WriteLine("What is your name ?");

            String input1 = Console.ReadLine();

            Console.WriteLine("Hello, {0} - let's play a game --> {1}", input1, gameName);

            Console.WriteLine($"Let's get started,  {input1}");


            Console.WriteLine("Please guess a number between 1 and 10");

            int guess = 0;
      
            

            Random random = new Random();
            int correctGuess = random.Next(1, 10);




            while (guess != correctGuess)
            {

                string input = Console.ReadLine();

                if (!int.TryParse(input, out guess))
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine("Please enter an actual number");
                    Console.ResetColor();
                    continue;

                }
                guess = Int32.Parse(input);

                if (guess != correctGuess)
                {
                    Console.ForegroundColor = ConsoleColor.Red;

                    Console.WriteLine("Sorry Wrong Guess - Try again !! ");
                }
                else
                {
                    Console.ResetColor();
                    Console.WriteLine("Correct!!! You guessed the right number. You guessed  {0} ", guess);

                    Console.WriteLine(" Do you want to play again? Press Y for Yes, N for NO");

                    String answer = Console.ReadLine();
                    

                    if (answer.ToUpper() == "Y")
                    {
                        continue;

                    }
                    else if (answer.ToUpper() == "N")
                    {
                        return;
                    }

                    else
                    {
                            return;
                    }

                }
            }

            }

                   

        }
    }
}
