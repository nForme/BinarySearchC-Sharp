using System;
using System.Diagnostics;

namespace Cunt2
{
    class Utilities
    {
        public static void CompareTimes()
        {
            try
            {
                //Utility objects
                Stopwatch watch = Stopwatch.StartNew();
                Random randNum = new Random();

                //Nuber to search
                int value_of_get_search = 198023;

                //Data collection
                int size_of_input = 100000000;
                int[] binary_search = new int[size_of_input];

                //Number range for the binary_search array
                int min = 0;
                int max = 200000;

                //Populate the data collection
                for (int i = 0; i < size_of_input; i++)
                {
                    binary_search[i] = randNum.Next(min, max);
                }
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Lets now times for the two methods");
                Console.WriteLine("");
                Console.WriteLine("");

                //simple search
                int searchIndex = 0;
                bool simpleSearchFound = false;
                watch.Restart();

                while (!simpleSearchFound && searchIndex < size_of_input)
                {
                    if (binary_search[searchIndex] == value_of_get_search)
                    {
                        simpleSearchFound = true;
                    }
                    else
                    {
                        searchIndex++;
                        Console.WriteLine("Searching at: " + searchIndex);
                    }
                }
                watch.Stop();
                long elapsedMs = watch.ElapsedMilliseconds;
                Console.WriteLine("Simple search took" + elapsedMs + "mSecs and" + searchIndex + "comparisons");
                Console.WriteLine("");
                Console.WriteLine("");

                Array.Sort(binary_search);
                Console.WriteLine("");
                Console.WriteLine("Collection sort completed as required by Binary Serch");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("Now lets search for your integer value ...");

                //binary search indices
                int get_middle = 0;
                int low = 0;
                int high = (binary_search.Length) - 1;
                int mid = (low + high) / 2;
                int track_middle = 0;

                //Here is the Binary Search Algorithm
                int searchCounter = 0;
                watch.Restart();

                while (low <= high)
                {
                    searchCounter++;

                    mid = (low + high) / 2;
                    get_middle = binary_search[mid];
                    if (get_middle == value_of_get_search)
                    {
                        break;
                    }

                    if (get_middle > value_of_get_search && get_middle != track_middle)
                    {
                        high = mid + 1;
                        track_middle = get_middle;
                    }

                    else
                    {
                        low = mid + 1;
                    }
                }

                if (low > high)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Could not locate your integer value int the search. Please try again...");
                }

                Console.WriteLine("");
                Console.WriteLine("");

                watch.Stop();
                elapsedMs = watch.ElapsedMilliseconds;

                Console.WriteLine("Binary search took took " + elapsedMs + "mSecs and " + searchCounter + " comparisons. Found item at location " + mid);
                Console.WriteLine("");
                Console.WriteLine("");
                Console.WriteLine("Press any key to exit the programm ....");
                Console.ReadKey(true);
            }
            catch
            {
                Console.WriteLine("Please enter an integer value and try again ....");
                Console.ReadKey(true);
            }
        }
    }
}
