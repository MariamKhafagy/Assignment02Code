using Assignment_AdvancedCode.Arraylist;
using Assignment_AdvancedCode.FixedsizeList;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;
//using static Assignment_AdvancedCode.Arraylist.ArrayLIst;

namespace Assignment_AdvancedCode
{
    internal class Program
    {
        #region Q.4 function
        //public static void GraterThan()
        //{
        //    //Array
        //    int sizearray;
        //    do
        //    {
        //        Console.Write("Enter Size of array:");
        //    } while (!int.TryParse(Console.ReadLine(), out sizearray));
        //    List<int> array = new List<int>();
        //    Console.WriteLine("\nFill The array: ");
        //    Console.WriteLine("----------------");
        //    for (int i = 0; i < sizearray; i++)
        //    {
        //        int value;
        //        do
        //        {
        //            Console.Write($"Enter element {i + 1}: ");
        //        } while (!int.TryParse(Console.ReadLine(), out value));

        //        array.Add(value);
        //    }
        //    Console.WriteLine();
        //    Console.WriteLine("----------------");
        //    Console.WriteLine("\nFill The Quary: ");
        //    Console.WriteLine("----------------");
        //    //Query
        //    int sizequary;
        //    do
        //    {
        //        Console.Write("Enter Size of Quary: ");
        //    } while (!int.TryParse(Console.ReadLine(), out sizequary));
        //    for (int i = 0; i < sizequary; i++)
        //    {
        //        int x;
        //        do
        //        {
        //            Console.Write($"Enter element {i + 1}: ");
        //        } while (!int.TryParse(Console.ReadLine(), out x));
        //        int count = array.Count(num => num > x);
        //        Console.WriteLine($"Numbers greater than {x}: {count}");
        //    }
        //}
        #endregion

        #region Q.6 function
        //static int[] RemoveDuplicates(int[] arr)
        //{ 
        // HashSet<int> seen = new HashSet<int>();
        //    List<int> result= new List<int>();
        //    foreach (int num in arr)
        //    {
        //        if(seen.Add(num))
        //            result.Add(num);
        //    }
        //    return result.ToArray();
        
        //}
        #endregion

        #region Q.7 function
        //static void RemoveOddNumbers(ArrayList list)
        //{
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        if (list[i] is int num && num % 2 != 0)
        //        { 
        //          list.Remove(i);
                
        //        }
            
            
        //    }


        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q.1 
            // 1. You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
            //List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
            //ReverseListArray.ReverseArrayList(numbers);

            //Console.WriteLine("After Reverse : " + string.Join(" , ", numbers));
            #endregion

            #region  Q.2
            //You are given a list of integers.Your task is to find and return a new list containing only the even numbers from the given list.
            //List<int> numbers = new List<int> {  1 , 2 , 3 , 4 , 5 , 6 , 7 , 8 , 9 };
            //List<int> EvenNumbers = new List<int>();

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    { 
            //     EvenNumbers.Add(number);
            //    }

            //}
            //Console.WriteLine("Even Numbers :" + string.Join(" ,", EvenNumbers));
            #endregion

            #region Q.3 
            //implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.
            //try
            //{
            //    FixedSIzeList<int> list = new FixedSIzeList<int>(3);
            //    list.Add(10);
            //    list.Add(20);
            //    list.Add(30);

            //    Console.WriteLine(list.Get(0));
            //    Console.WriteLine(list.Get(2));

            //    list.Add(40);


            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine($"Error : {ex.Message}");

            //}
            #endregion

            #region Q.4
            //Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.
            //GraterThan();


            #endregion

            #region Q.5
            //Given a number N and an array of N numbers. Determine if it's palindrome or not.
            //int N = int.Parse(Console.ReadLine()!);
            //int[] arr = Array.ConvertAll(Console.ReadLine()!.Split(),int.Parse);

            //bool isPalindrome = true;
            //for(int i =0;i<N/2;i++)
            //  {
            //    if (arr[i] != arr[N - 1 - i])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }

            //  }
            //Console.WriteLine(isPalindrome ? "Yes" : "No");
            #endregion

            #region Q.6
            //Given an array, implement a function to remove duplicate elements from an array.
            //int[] arr = { 1, 2, 3, 4, 4, 1, 3, 4 };
            //int[] uniquerArr = RemoveDuplicates(arr);
            //Console.WriteLine(string.Join(" , " ,uniquerArr));
            #endregion

            #region Q.7 
            // Given an array list , implement a function to remove all odd numbers from it.
            //ArrayList numbers = new ArrayList() {1,2,3,4,5,6,7,8 };

            //RemoveOddNumbers(numbers);

            //Console.WriteLine("After Removing Odds " + string.Join(" ," , numbers.ToArray()));

            #endregion
        }
    }
}
