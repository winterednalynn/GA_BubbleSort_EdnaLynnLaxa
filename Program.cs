using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GA_BubbleSort_EdnaLynnLaxa
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10; // Change the size of the array as needed
            int minValue = 1; // Change the minimum value as needed
            int maxValue = 100; // Change the maximum value as needed

            int[] randomArray = GenerateRandomIntArray(size, minValue, maxValue);

            Console.WriteLine("Unsorted: ");
            PrintArray(randomArray);

            BubbleSort(randomArray);

            Console.WriteLine("\nSorted: ");
            PrintArray(randomArray);

            //THIS FUNCTION WORKS , it displayed the sorted array. 
        }
        static int[] GenerateRandomIntArray(int size, int minValue, int maxValue)
        {
            Random random = new Random();

            if (size <= 0 || minValue > maxValue)
            {
                throw new ArgumentException("Invalid arguments");
            }

            int[] arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = random.Next(minValue, maxValue + 1);
            }
            return arr;
        }

        static void BubbleSort(int[] arr)
        {
            int arrayLength = arr.Length;
            bool hasSwapped;

            for (int currentPass = 0; currentPass < arrayLength - 1; currentPass++)
            {
                hasSwapped = false;

                for (int currentIndex = 0; currentIndex < arrayLength - 1 - currentPass; currentIndex++)
                {
                    if (arr[currentIndex] > arr[currentIndex + 1])
                    {
                        // Swap arr[currentIndex] and arr[currentIndex + 1]
                        int temp = arr[currentIndex];
                        arr[currentIndex] = arr[currentIndex + 1];
                        arr[currentIndex + 1] = temp;
                        hasSwapped = true;
                    }
                }

                // If no two elements were swapped in the inner loop, the array is already sorted
                if (!hasSwapped)
                {
                    break;
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
        }
        static void PseudoCode(int[] array) // METHOD that takes a parameter 
        {
            // The start 
            int arrayLength = array.Length; // Obtain the length of the typed in array
            bool swapped;  // To compute a signal to maintain if any swap actions are taken in place. 

            do // Prompt a do while b/c this will loop to continue classifying until resource are exhausted of no swaps in pass. 
            {
                swapped = false;

                for (int i = 1; i < arrayLength; i++) //Iterates through the array details, initiating from point A to B up until the end. 
                {
                    if (array[i - 1] > array[i]) // Comparsion function, if A is greater than B then it is then switched using a for  now variable
                    {
                        // Swap elements
                        int temp = array[i - 1];
                        array[i - 1] = array[i];
                        array[i] = temp;

                        swapped = true; // if the action happens, its true , it happened. 
                    }
                }

                arrayLength--; // Optimization: Reduce the array size after each pass
            } while (swapped);

            //Provide comments explaining:
            //The purpose of each loop in the algorithm.

            //FOREACH: Simple, Fast, and Readable. This statement ensure performance optimization and maintnance. Oh yes, you can
            // use this statement for implementing IEnumerable too! The code can look very clean when using this. 

            //DO WHILE: With a do while you can divide the focus of initializing part and ++ condition for the loop. 
            //I've used Do - While for menu like programs but for algorithm a user input can be place and the do while will 
            //execute once to discover the user's input. 

            //WHILE LOOP : While loop for algorithm purposes targets the condition. Just like most loops this can roam over collection of data
            //The while performs based on a counter. 



            //The role of comparisons and swaps.
            // The performance of a bubble sort is comparing and sorting. Hence the cool youtube video that was shown in class. 
            // The comparision goes one by bone through a loop and it is processed until the collection is up to par. 
            // The swaps are taken place when the comparison of one detail is deemed out of order. 

            //How the algorithm progresses and concludes.
            // Like most unsorted list , it is unorganized. Concluding the term: Unsorted. A loop is used to go through the range of the list 
            //targeting any out of order elements and grouping to perfection. That's how the bubble sort process and concludes. 
        }




        //procedure bubbleSort(arr: List of Comparable)
        //// Get the length of the input array
        //arrayLength = length(arr)

        //// Initialize a flag to track whether any swaps occurred in a pass
        //swapOccurred = true

        // // Continue iterating until no swaps occur in a pass
        //   while swapOccurred is true
        //    // Reset the swap flag at the start of each pass
        //     swapOccurred = false

        // // Iterate through the array elements from the first to the second-to-last element
        //     for currentIndex from 1 to arrayLength - 1
        //        // Compare the current element with the next element
        //        if arr[currentIndex - 1] > arr[currentIndex]
        //    // Swap the elements if they are out of order
        //    swap arr[currentIndex - 1] and arr[currentIndex]

        //    // Set the swap flag to true to indicate a swap occurred
        //    swapOccurred = true
        //end if
        // end for
        //end while
        //end procedure


        //        Criteria Description Points
        //Project Setup Proper creation of a new console application named GA_BubbleSort_YourName.  20
        //Understanding of Bubble Sort Algorithm Clear explanation and pseudo-code of Bubble Sort.	15
        //Implementation of Bubble Sort   Correct implementation of Bubble Sort in C#.	15
        //Explanation of Algorithm Logic Detailed comments explaining the logic of the algorithm.    15
        //Implementing Loop Conditions Correct implementation and explanation of loop conditions.	15
        //Optimizing the Sorting Process  Implementation and explanation of optimization techniques.	10
        //Code Testing and Output Accuracy Successful testing and demonstration of accurate sorting.	5
        //Submission Successful upload to GitHub with the correct link provided.	5
        //Total       100

    }
}
}
