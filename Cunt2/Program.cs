using System;
using System.Diagnostics;
using System.Collections;
using Cunt2;

class Progam
{
    static void Main(string[] args)
    {
        Console.Write("Please enter an integer value between 1 and 20:");
        try
        {
            //user input
            string input = Console.ReadLine();
            int value_of_input = int.Parse(input);
            //lowest random integer
            int min = 0;
            //maximum random integer
            int max = 20;
            int[] binary_search = new int[value_of_input];
            //Generate a random number instance called randNum
            Random randNum = new Random();

            //Populate the array with random numbers between 0 and 20
            for (int i = 0; i < value_of_input; i++)
            {
                binary_search[i] = randNum.Next(min, max);
                Console.Write(" " + binary_search[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            //Here user should enter an integer value from the list displayed by the array in the console
            Console.Write("Now enter one integer value from this array to conduct the binary search");

            string get_search = Console.ReadLine();
            int value_of_get_search = int.Parse(get_search);

            //Now sort the integer values in the array as required by binary search
            Array.Sort(binary_search);
            Console.WriteLine("");
            Console.WriteLine("Here is the array with the integer values in order as required by binary search");
            Console.WriteLine("");

            //Print the ordered array to the console
            for (int i = 0; i < value_of_input; i++)
            {
                Console.Write("  " + binary_search[i]);
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Now lets search for you integer value ....");
            //get middle will be used to get the element in the middle of the array
            int get_middle = 0;
            //lower element 
            int low = 0;
            //This is the upper element
            int high = (binary_search.Length) - 1;
            //This is the middle if the array. mid is rounded automatically if (low + high)
            int mid = (low + high) / 2;
            int track_middle = 0;

            //Here binary search Algorithm
            while (low <= high)
            {
                mid = (low + high) / 2;
                //Get the middle element in the binary_search array
                get_middle = binary_search[mid];

                if (get_middle == value_of_get_search)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Found your integer! Here it is " + value_of_get_search);
                    break;
                }

                if (get_middle > value_of_get_search && get_middle != track_middle)
                {
                    high = mid + 1;
                    Console.WriteLine("");
                    Console.WriteLine("Found this integer:" + get_middle + "But thats not it!");
                    track_middle = get_middle;
                }

                //If no match is found, low will continue to increase I more utill it exceeds high
                //Otherwise low will be used to contonue the search
                else
                {
                    low = mid + 1;
                    Console.WriteLine("");
                    Console.WriteLine("Found this integer" + get_middle + "But thats not it");
                }
                if (low > high)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Could not locate your integer value in the search. Pls try again");
                }

                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press any key to continue .....");
                Console.ReadKey(true);
            }
        }
        catch
        {
            Console.WriteLine("Please enter an integer value and try again .....");
            Console.ReadKey(true);
        }

        Utilities.CompareTimes();
    }
}