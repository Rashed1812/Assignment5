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

            #region 4.Write a program in C# Sharp to count the frequency of each element of an array

            #endregion

            #region 5.Write a program in C# Sharp to find maximum and minimum element in an array
            //Console.Write("Enter Number of Elements You Want To Get Max And Min: ");
            //int.TryParse(Console.ReadLine(), out int elements);

            //int[] nums = new int[elements];
            //Console.WriteLine("Enter The Numbers Of Array: ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //Console.WriteLine($"Min Number In Array Is: {nums.Min()}");
            //Console.WriteLine($"Max Number In Array Is: {nums.Max()}");
            #endregion

            #region 6.Write a program in C# Sharp to find the second largest element in an array
            //Console.Write("Enter Number of Elements You Want To Get Max And Min: ");
            //int.TryParse(Console.ReadLine(), out int elements);

            //int[] nums = new int[elements];
            //Console.WriteLine("Enter The Numbers Of Array: ");
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    nums[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //int largest, secondLargest;

            //if (nums[0] > nums[1])
            //{
            //    largest = nums[0];
            //    secondLargest = nums[1];
            //}
            //else
            //{
            //    largest = nums[1];
            //    secondLargest = nums[0];
            //}

            //for (int i = 2; i < nums.Length; i++)
            //{
            //    if (nums[i] > largest)
            //    {

            //        secondLargest = largest;
            //        largest = nums[i];
            //    }
            //    else if (nums[i] > secondLargest && nums[i] != largest)
            //    {
            //        secondLargest = nums[i];
            //    }
            //}
            //Console.WriteLine("The second largest element is: " + secondLargest);

            #endregion

            #region 7.Consider an Array of Integer values with size N, having values as in this Example

            //Console.Write("Enter Number of Elements :");
            //int.TryParse(Console.ReadLine(), out int n);

            //int[] array = new int[n];
            //Console.WriteLine("Enter the Numbers of the array:");
            //for (int i = 0; i < n; i++)
            //{
            //    array[i] = int.Parse(Console.ReadLine());
            //}

            //int longestDistance = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    for (int j = i + 1; j < n; j++)
            //    {
            //        if (array[i] == array[j])
            //        {
            //            int distance = j - i;
            //            if (distance > longestDistance)
            //            {
            //                longestDistance = distance;
            //            }
            //        }
            //    }
            //}
            //Console.WriteLine("The longest distance between two equal cells is: " + longestDistance);
            #endregion

            #region 9.Given a list of space separated words, reverse the order of the words
            //Console.Write("Enter a Words string: ");
            //string input = Console.ReadLine();
            //string[] words = input.Split(' ');

            //for (int i = words.Length - 1; i >= 0; i--)
            //{
            //    if (i != words.Length - 1)
            //    {
            //        Console.Write(" ");
            //    }
            //    Console.Write(words[i]);
            //}
            #endregion

            #region 10.Write a program to create two multidimensional arrays of same size. Accept values from the user and store them in first array. Now copy all the elements of the first array on second array and print second array
            //Console.Write("Enter the number of rows: ");
            //int rows = int.Parse(Console.ReadLine());

            //Console.Write("Enter the number of columns: ");
            //int cols = int.Parse(Console.ReadLine());

            //int[,] Array1 = new int[rows, cols];
            //int[,] Array2 = new int[rows, cols];

            //Console.WriteLine("Enter the elements for the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write($"Enter element for position ({i}, {j}): ");
            //        Array1[i, j] = int.Parse(Console.ReadLine());
            //    }
            //}

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Array2[i, j] = Array1[i, j];
            //    }
            //}
            //Console.WriteLine("The second array after copying elements from the first array:");
            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        Console.Write(Array2[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 11.Write a Program to Print One Dimensional Array in Reverse Order

            //Console.Write("Enter the Number of the Elements: ");
            //int element = int.Parse(Console.ReadLine());

            //int[] num = new int[element];
            //Console.WriteLine("Enter the elements of the array:");
            //for (int i = 0; i < element; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //}
            //Console.WriteLine("Array in reverse order:");
            //for (int i = element - 1; i >= 0; i--)
            //{
            //    Console.Write(num[i] + " ");
            //}
            #endregion
        }
    }
}