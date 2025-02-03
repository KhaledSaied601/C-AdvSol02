using System.Collections;

namespace C_AdvAss02
{

    internal class Program
    {
        #region 1- You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.
        public static void ReverseArrayList(ref ArrayList list)
        {
            if (list == null) return;
            ArrayList reversedList = new ArrayList();
            for (int i = list.Count ; i >= 0; i--)
            {
                reversedList.Add(list[i]);
            }

            list = reversedList;

        }
        #endregion

        static int FirstNonRepeatedChar(string str)
        {

            Dictionary<char, int> charCount = new Dictionary<char, int>();

          
           
            foreach (char c in str)
            {
                if (charCount.ContainsKey(c))
                    charCount[c] += 1;
                else
                    charCount[c] = 1;
            }

            for (int i = 0; i < str.Length; i++)
            {
                if (charCount[str[i]] == 1)

                    return i;
            }

            // If no non-repeated character is found
            return -1;

        }

        static void RemoveDuplicated<T>(ref T[] arr)
        {
            if (arr == null) return;
            T[] set = new HashSet<T>(arr).ToArray();
            arr = set;


        }

        static void RemoveOddNumbers(ArrayList list)
        {

            if (list == null) return;
            for (int i = 0; i< list.Count ; i++)
            {
                if (list[i] is int other) 
                {
                   if (other % 2 != 0)
                    {
                        list.RemoveAt(i);
                    }
                }
            }
        }
          static void Main(string[] args)
        {


            #region 1- You are given an ArrayList containing a sequence of elements. try to reverse the order of elements in the ArrayList in-place(in the same arrayList) without using the built-in Reverse. Implement a function that takes the ArrayList as input and modifies it to have the reversed order of elements.


            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, "Khaled" };
            //ReverseArrayList(ref arrayList);
            //foreach (var item in arrayList) Console.WriteLine(item);

            #endregion

            #region 2- You are given a list of integers. Your task is to find and return a new list containing only the even numbers from the given list.


            //List<int> list = new List<int>() { 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15 };
            //List<int>? evenNumsList =   list.FindAll(e=>e%2==0).ToList();
            //for (int i = 0; i < evenNumsList.Count; i++) Console.WriteLine(evenNumsList[i]);






            #endregion

            #region 3- implement a custom list called FixedSizeList<T> with a predetermined capacity. This list should not allow more elements than its capacity and should provide clear messages if one tries to exceed it or access invalid indices.

            //FixedSizeList<int> fixedSizeList = new FixedSizeList<int> (5);
            //fixedSizeList.Add(10);
            //fixedSizeList.Add(20);
            //fixedSizeList.Add(30);
            //fixedSizeList.Add(40);
            //fixedSizeList.Add(50);
            ////fixedSizeList.Add(60);



            //Console.WriteLine(fixedSizeList.GetValue(0));
            //Console.WriteLine(fixedSizeList.GetValue(1));
            //Console.WriteLine(fixedSizeList.GetValue(2));
            //Console.WriteLine(fixedSizeList.GetValue(3));
            //Console.WriteLine(fixedSizeList.GetValue(4));
            //Console.WriteLine(fixedSizeList.GetValue(5));



            #endregion


            #region 4- Given a string, find the first non-repeated character in it and return its index. If there is no such character, return -1. 

            //string name = "Khh";

            //Console.WriteLine(FirstNonRepeatedChar(name)) ;

            #endregion

            #region 5- Given an array  consists of  numbers with size N and number of queries, in each query you will be given an integer X, and you should print how many numbers in array that is greater than  X.


            //int[] arr = { 11, 5, 3 };

            //int q=0;
            //bool flagQuery = false;
            //do
            //{
            //    Console.WriteLine("Please Enter the Size of Array");
            //   flagQuery= int.TryParse(Console.ReadLine(), out q);

            //}
            //while (flagQuery == false);

            //int x=0 ;

            //bool flagX = false;
            //do
            //{
            //    Console.WriteLine("Please Enter the Size of Array");
            //   flagX = int.TryParse(Console.ReadLine(), out q);

            //}
            //while (flagX == false);


            //if (arr.Length < q)
            //{
            //    for (int i = 0; i < q; i++)
            //    {

            //        if (arr[i] > x) Console.WriteLine(arr[i]);


            //    }
            //}
            //else Console.WriteLine("Numbers of query is bigger than the arr");


            #endregion

            #region 6 - Given a number N and an array of N numbers. Determine if it's palindrome or not.

            //int[] arr = { 1, 3, 2, 3, 1 };

            //int N ;
            //bool flagN = false;
            //do
            //{
            //    Console.WriteLine("Please Enter the Size of Array");
            //   flagN = int.TryParse(Console.ReadLine(), out N);

            //}
            //while (flagN == false);

            //if (N == arr.Length)
            //{
            //    Console.WriteLine("YES");
            //}
            //else Console.WriteLine("No");

            #endregion


            #region 7 - Given an array, implement a function to remove duplicate elements from an array.

            //int[] arr = { 1, 3, 1, 4, 5, 4, 5, 3 };
            //RemoveDuplicated<int>(ref arr);
            //for (int i = 0; i < arr.Length; i++) Console.WriteLine(arr[i]);

            #endregion

            #region 8 -  Given an array list , implement a function to remove all odd numbers from it.

            //ArrayList list = new ArrayList() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //RemoveOddNumbers(list);

            //foreach (var item in list) Console.WriteLine(item); 
            #endregion
        }
    }
}
