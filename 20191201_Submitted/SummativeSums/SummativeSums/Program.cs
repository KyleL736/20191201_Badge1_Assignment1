
/*          This is how you initialize three seperate arrays and supply data to them.
           
            int[] array1 = new int[] { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            int[] array2 = new int[] { 999, -60, -77, 14, 160, 301 };
            int[] array3 = new int[] { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130,
            140, 150, 160, 170, 180, 190, 200, -99 };

               */

using System;
using System.Linq;

namespace SummativeSums
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a new jagged array with three columns.
            int[][] array123 = new int[3][];
                           // If you wanted to supply data to a jagged array, this is how you would do it.  I decided to fill the jagged array with random numbers.
            // Set the size of the columns.
            array123[0] = new int[9];  // { 1, 90, -33, -55, 67, -16, 28, -55, 15 };
            array123[1] = new int[6];  // { 999, -60, -77, 14, 160, 301 };
            array123[2] = new int[21]; // { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100, 110, 120, 130, 140, 150, 160, 170, 180, 190, 200, -99 };
            
            // Set the total sum to an int.
            int totalsum = 0;

            //I am going to display the random numbers that I am using to calculate the sum of them.
            Console.Write("\nThe random values in column one are: ");
            for (int i = 0; i < array123[0].Length; i++)
                {
                // Select a random number and populate the array with it.
                Random r = new Random();
                array123[0][i] = r.Next(-25, 25);
                Console.Write(array123[0][i] + ", ");

                }
                Console.Write("\nThe random values in column two are: ");

                for (int i = 0; i < array123[1].Length; i++)
                {
                // Select a random number and populate the array with it.
                Random r = new Random();
                array123[1][i] = r.Next(-50, 50);
                Console.Write(array123[1][i] + ", ");

                }
                Console.Write("\nThe random values in column three are: ");

            // I decided to do a legnth minus 1 so the last digit would not have a following comma.

            for (int i = 0; i < (array123[2].Length - 1); i++)
                {
                // Select a random number and populate the array with it.
                Random r = new Random();
                array123[2][i] = r.Next(-75, 75);
                Console.Write(array123[2][i] + ", ");

                }

            // Calculate the random number for the last index of the array.
            {
                Random r = new Random();
                array123[2][20] = r.Next(-75, 75);
            }
            //Display the last number on column three.
            Console.Write(array123[2][20]);
            Console.WriteLine();

            // This method is used to calculate the sum of the columns of my jagged array.

            int Sum(params int[] passthrough)
            {
                //The name is passthrough since I am going to passthrough an array and set it equal to the word sum as an int.
                int sum = passthrough.Sum();
                return sum;
            }

            //Changed the font color to cyan.  I like the way this color looks.

            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();

            //I am calling the Sum method and passing through the first column of my jagged array and stoing the value in totalsum.
            totalsum = Sum(array123[0]);
            Console.WriteLine("Array column #1 sum is " + totalsum);

            //I am calling the Sum method and passing through the second column of my jagged array and stoing the value in totalsum.
            //The value of totalsum gets replaced.
            totalsum = Sum(array123[1]);
            Console.WriteLine("Array column #2 sum is " + totalsum);

            //I am calling the Sum method and passing through the third column of my jagged array and stoing the value in totalsum.
            //The value of totalsum gets replaced.
            totalsum = Sum(array123[2]);
            Console.WriteLine("Array column #3 sum is " + totalsum);
            Console.ResetColor();

        }
    }
}