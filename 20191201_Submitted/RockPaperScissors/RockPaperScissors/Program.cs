using System;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int rounds;
            int userselect;
            int computerselect;
            int computerwins = 0;
            int userwins = 0;
            int ties = 0;

            //Stores the value of the user name to display in the game.
            Console.WriteLine("\nWelcome to Rock Paper Scissors! \nPlease enter your name: ");
            string name = Console.ReadLine();

            while (true)
            {
                //Reset computerwins value to zero.
                computerwins = computerwins - computerwins;

                //Reset userwins value to zero.
                userwins = userwins - userwins;

                //Reset ties value to zero.
                ties = ties - ties;

                Console.WriteLine("\n" + name + ", Please enter the number of rounds you want to play between 1-10:  ");
                string stringrounds = Console.ReadLine();

            //Check to make sure an integer was entered.
            if(int.TryParse(stringrounds, out rounds))
            {
                if(rounds > 0 && rounds < 11)
                {
                    //This loop is for the number of rounds the user is going to play.
                    for(int i = 1; i <=rounds; i++)
                    {
                        Console.WriteLine();
                        Console.WriteLine(name + ", Please select: 1 = Rock, 2 = Paper, 3 = Scissors");
                        string stringuserselect = Console.ReadLine();
                        if (int.TryParse(stringuserselect, out userselect))
                        {
                            // Randomly generates a selection for the computer.
                            Random r = new Random();
                            computerselect = r.Next(1, 3);

                            Console.WriteLine("The computer randomly selected " + computerselect);

                            switch(userselect) //I am checking what the user entered since they may enter a number out of range and I would like to show a message if that happens.
                            {
                                case 1:
                                    if(computerselect == 2)
                                    {
                                        Console.WriteLine("Paper wraps Rock");
                                        Console.WriteLine("Computer won the round.");
                                        computerwins++;
                                    }
                                    else if (computerselect == 3)
                                    {
                                        Console.WriteLine("Rock breaks Scissors");
                                        Console.WriteLine("You won the round.");
                                        userwins++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The round is a tie.");
                                        ties++;
                                    }
                                    break;
                                case 2:
                                    if (computerselect == 3)
                                    {
                                         Console.WriteLine("Scissors cut Paper");
                                         Console.WriteLine("Computer won the round.");
                                        computerwins++;
                                    }
                                    else if (computerselect == 1)
                                    {
                                        Console.WriteLine("Paper wraps Rock");
                                        Console.WriteLine("You won the round.");
                                        userwins++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The round is a tie.");
                                        ties++;
                                    }
                                    break;
                                case 3:
                                    if (computerselect == 1)
                                    {
                                            Console.WriteLine("Rock breaks Scissors");
                                            Console.WriteLine("Computer won the round.");
                                        computerwins++;
                                    }
                                    else if (computerselect == 2)
                                    {
                                        Console.WriteLine("Scissors cut Paper");
                                        Console.WriteLine("You won the round.");
                                        userwins++;
                                    }
                                    else
                                    {
                                        Console.WriteLine("The round is a tie.");
                                        ties++;
                                    }
                                    break;
                                default:
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.WriteLine("Error.  The number was out of range.  Please enter 1, 2, or 3.");
                                        Console.ResetColor();
                                        //Add 1 to the round total so that when a user enters a something that is not a 1,2,3, it does not count as a round 
                                        rounds++;
                                        break;
                            }

                        }
                        //This is for if the tryparse fails for selecting 1,2,3.
                        else
                        {
                            rounds++;
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error.  A letter was entered.  Please enter 1, 2, or 3.");
                            Console.ResetColor();
                        }

                    }
                    Console.WriteLine();

                    //Changing the color to green and displaying the number of rounds the user won.  And I reset the color after I am done using it.
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You won " + userwins + " rounds.");
                    Console.ResetColor();
                    //Changing the color to blue and displaying the number of rounds the computer won.  And I reset the color after I am done using it.
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Computer won " + computerwins + " rounds.");
                    Console.ResetColor();
                    //Changing the color to yellow and displaying the number of rounds that were ties.  And I reset the color after I am done using it.
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("There were " + ties + " ties in the rounds played.");
                    Console.ResetColor();

                        //Determine the overall winner of the game.
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        if (userwins > computerwins)
                        {
                            Console.WriteLine("You won the overall game.\n");
                        }
                        else if(userwins < computerwins)
                        {
                            Console.WriteLine("The computer won the overall game.\n");
                        }
                        else
                        {
                            Console.WriteLine("The overall game was a tie.\n");
                        }
                        Console.ResetColor();

                        //If the number of rounds is out of range, go here.        
                    }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error.  The number was out of range.  Enter a number 1 to 10.");
                    Console.ResetColor();
                }

                                        
            }
            //If the tryparse fails, go here.   
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error.  The number was out of range or a letter was entered.");
                Console.ResetColor(); 
            }

                Console.WriteLine("\aDo you want to play again " + name + "?  Y for Yes, N for No");
                string again = Console.ReadLine();

                //I could not find a way to do a wild card in C#, so I had to do a lot of OR possibilities.  Does C# have a wildcard character?
                if (again == "y" || again == "Y" || again == "Yes" || again == "yes" || again == "YES" || again == "yEs" || again == "yeS" || again == "YeS")
                {

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("Thanks for playing!");
                    Console.ResetColor();
                    break;
                }

            }
          
        }
    }
}
