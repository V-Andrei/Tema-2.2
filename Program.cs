using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema_2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ex1();
            //Ex2();
            //Ex3();
            //Ex4();
            //Ex5();
            //Ex6();
            //Ex7();
            //Ex8();

            //ExUniqueString();
            //
            //ExPalindrome();
            //ExBonus();

            Console.ReadLine();
        }
       
        private static void ExBonus()
        {
            Console.WriteLine("Write a sentence:");
            string text = Console.ReadLine();
            string empty = " ";
            char characterEmpty = char.Parse(empty);

            string dot = ".";
            char characterDot = char.Parse(dot);

            int count = 0;

            for (int i = text.Length - 1; i >= 0; i--)
            {

                count++;
                if (text[i] == characterDot)
                {
                    count--;
                }
                if (text[i] == characterEmpty)
                {
                    break;
                }

            }


            Console.WriteLine("The last word have " + (count - 1) + " characters");
        }

        private static void ExPalindrome()
        {
            string word = "reper";
            char[] warray = word.ToCharArray();
            Console.WriteLine(istPalindrom(warray));
            Console.Write("The word is a palindrome");
        }

        public static bool istPalindrom(char[] word)
        {
            int i = 0;
            int j = word.Length - 1;
            while (j > i)
            {
                if (word[i] != word[j])
                {
                    return false;
                }
                ++i;
                --j;
            }
            return true;         
        }

        private static void ExUniqueString()
        {
            string inputStr = "Drive";
            Console.WriteLine("The string input its  " + isUnique(inputStr) + " unique.");            
        }

        private static bool isUnique(String input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                char charatersPutString = input[i];
                int count = 0;
                for (int j = 0; j < input.Length; j++)
                {
                    if (charatersPutString == input[j])
                    {
                        count++;
                    }
                    if (count > 1)
                    return false;
                }               
            }
            return true;
        }

        private static void Ex8()
        {
            int[] arr1 = new int[] { 0, 2, 4, 5, 6, 8 };
            int[] arr2 = new int[6];

            int i; 
            int n;

            n = arr1.Length;

            for (i = 0; i < n; i++)
            {
                arr2[i] = arr1[i];
            }

            Console.WriteLine("The elements stored in the first array are :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            Console.WriteLine("The elements copied into the second array are :");
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(arr2[i]);
            }

            Console.ReadLine();
        }

        private static void Ex7()
        {
            int[] arr1 = { 1, 4, 2, 8, 7 };
            int[] arr2 = { 7, 5, 9, 1, 0, 2, 6 };

            Console.Write("First array is: ");
            Array.ForEach(arr1, Console.WriteLine);

            Console.Write("Secound array is: ");
            Array.ForEach(arr2, Console.WriteLine);


            int i = 0;
            int j = 0;

            Console.WriteLine("Elementele comune sunt: ");
            for (i = 0; i < arr1.Length; i++)
            {
                for (j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i] == arr2[j])
                    {
                        Console.WriteLine(arr1[i]);
                    }
                }
            }
        }

        private static void Ex6()
        {
            int[] arr = new int[] { 50, 1005, 100, 43, 87, 2, 53 };
            int i, max, min, n;

            Console.WriteLine("The array is: ");
            Array.ForEach(arr, Console.WriteLine);
            

            n = arr.Length;
            max = arr[0];
            min = arr[0];
            for (i = 1; i < n; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Maximum element = " + max);
            Console.WriteLine("Minimum element = " + min);
        }

        private static void Ex5()
        {
            int i = 0;
            int pos = 0;
            int item = 0;
            int[] arr = { 1, 2, 3, 4, 5, 6 };

            Array.ForEach(arr, Console.WriteLine);

            Console.Write("Enter position : ");
            pos = int.Parse(Console.ReadLine());

            Console.Write("Enter new item : ");
            item = int.Parse(Console.ReadLine());

            for (i = 5; i >= pos; i--)
            {
                arr[i] = arr[i - 1];
            }

            arr[pos - 1] = item;

            Console.WriteLine("Array elements after insertion : ");
            for (i = 0; i < 6; i++)
            {
                Console.WriteLine("Element: " + (i + 1) + " Position: " + arr[i]);
            }

            Console.WriteLine();
        }

        private static void Ex4()
        {
            int[] arr = { 0, 1, 2, 3, 4 };
            int[] newArr = new int[5];

            Array.ForEach(arr, Console.WriteLine);
            Console.WriteLine("What element to remove?");
            int index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] == index)
                {
                    continue;
                }

                if (!(arr[i] == index))
                {
                    newArr[i] = arr[i];
                }

            }

            Array.ForEach(newArr, Console.WriteLine);
        }

        private static void Ex3()
        {
            int[] arr = { 4, 5, 7, 8, 44 };
            Console.WriteLine("What index to finde?");
            Array.ForEach(arr, Console.WriteLine);
            int index = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine("The index of " + index + " is " + arr[i]);
                    break;
                }
            }
        }

        private static void Ex2()
        {
            int[] arr = { 1, 2, 3, 4, 5 };
            int sum = 0;
            int ave = 0;

            Console.WriteLine("The array is: ");
            Array.ForEach(arr, Console.WriteLine);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            ave = sum / arr.Length;
            Console.WriteLine("The averge number is: " + ave);
        }

        private static void Ex1()
        {
            int[] arr = { 20, 3, 4, 3, 87, 45, 69, 48, 87 };
            int sum = 0;

            Console.WriteLine("The array is: ");
            Array.ForEach(arr, Console.WriteLine);

            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }

            Console.WriteLine("The sum is: " + sum);

        }
    }
}
