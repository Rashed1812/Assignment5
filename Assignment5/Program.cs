using System.Diagnostics.CodeAnalysis;
using System.Drawing;

namespace Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1.Write a program that prints an identity matrix using for loop, in other words takes a value n from the user and shows the identity table of size n * n
            //Console.Write("Enter Number of the identity matrix: ");
            //int n;

            //while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
            //{
            //    Console.Write("Please enter a valid positive number for n: ");
            //}

            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = 0; j < n; j++)
            //    {
            //        if (i == j)
            //        {
            //            Console.Write("1 ");
            //        }
            //        else
            //        {
            //            Console.Write("0 ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 2.Write a program in C# Sharp to find the sum of all elements of the array
            //Console.Write("Enter Number of Elements You Want To Get Sum All :");
            //int elements;
            //int.TryParse(Console.ReadLine(), out int n);

            //int sum = 0;

            //int[] nums = new int[n];
            //Console.WriteLine("Enter The Numbers You Want to Sum: ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0;i < nums.Length; i++) 
            //{
            //    sum += nums[i] ;
            //}
            //Console.WriteLine($"Sum Of All Elements {sum}");

            #endregion

            #region 3.Write a program in C# Sharp to merge two arrays of the same size sorted in ascending order

            //Console.Write("Enter Number of Elements You Want To Make 2 Arrays Same Size: ");
            //int.TryParse(Console.ReadLine(), out int elements);
            //if (elements == 0 || elements < 0) { Console.WriteLine("Invaled Number Of Elments");}

            //int[] array1 = new int[elements];
            //Console.WriteLine("Enter The Numbers Of First Array: ");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array1[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int[] array2 = new int[elements];
            //Console.WriteLine("Enter The Numbers Of Second Array: ");
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    array2[i] = Convert.ToInt32(Console.ReadLine());
            //}
            
            //int[] result = new int[array1.Length + array2.Length];
            //for (int i = 0; i < array1.Length; i++)
            //{
            //    result[i] = array1[i];
            //    result[array2.Length + i] = array2[i];
            //}
            //Array.Sort(result);

            //Console.WriteLine("Merged 2 Arrays And sorted in ascending order:");
            //foreach (int number in result)
            //{
            //    Console.Write(number + " ");
            //}

            #endregion
        }
    }
}