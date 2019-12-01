using System;

namespace HealthyHearts
{
    class Program
    {
        static void Main(string[] args)
        {
            while(true)
            { 
                int personageno;

                Console.Write("What is your age? ");

                // Reads what the user entered.
                string PersonAge = Console.ReadLine();

                if (int.TryParse(PersonAge, out personageno) && personageno < 220)
                {
                    // Subtract 220 from the users age.
                    int ratemax = 220 - personageno;

                    // Multiply the maximum heart rate by 0.85 and 0.5 respectively.
                    double rateint = ratemax * 0.85;
                    double ratemin = ratemax * 0.5;
                    // ConvertToInt32 rounds 0.50 down to the smaller integer.  I added 0.001 to make 0.50 round up to the next higher integer.
                    int ratemaxint = Convert.ToInt32(ratemax + 0.001);
                    // ConvertToInt32 rounds 0.50 down to the smaller integer.  I added 0.001 to make 0.50 round up to the next higher integer.
                    int rateminint = Convert.ToInt32(ratemin + 0.001);

                    Console.WriteLine("Your maximum heart rate should be " + ratemax + " beats per minute.");
                    Console.WriteLine("Your target heart rate zone is " + rateminint + " - " + rateint + " beats per minute.");
                    break;
                }

                // If the user does not enter an integer or an integer above 219, it jumps here and make a beep on the computer.
                else
                {
                    Console.WriteLine("\aThat was not a number or it was more than 220.");
                    break;
                }
            }
        }
    }
}
