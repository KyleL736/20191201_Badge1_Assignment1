using System;

namespace DogGenetics
{
    class Program
    {
        static void Main(string[] args)
        {

            int total = 100;
            //Make an array with five random numbers to be filled in later.
            int[] fivesum = new int[5];

            //Read the dog name.
            Console.Write("What is your dog's name? ");
            string dogname = Console.ReadLine();

            Console.WriteLine("Well then, I have this highly reliable report on " + dogname + "'s prestigious background right here.\n");

            //Loop throuh the array to populate it with 4 random numbers.
            for (int i = 0; i < 4; i++)
            {
                Random r = new Random();
                fivesum[i] = r.Next(1, total);
                //Change the value of total.
                total = total - fivesum[i];
            }

            //This is to make sure the five numbers equal 100.
            fivesum[4] = (100 - fivesum[0] - fivesum[1] - fivesum[2] - fivesum[3]);

            Console.WriteLine(dogname + " is:\n");

            Console.WriteLine(fivesum[0] + "% St. Bernard");
            Console.WriteLine(fivesum[1] + "% Chihuahua");
            Console.WriteLine(fivesum[2] + "% Dramatic RedNosed Asian Pug");
            Console.WriteLine(fivesum[3] + "% Common Cur");
            Console.WriteLine(fivesum[4] + "% King Doberman");

            Console.WriteLine("");
            Console.WriteLine("Wow, that's QUITE the dog!");
        }
    }
}
