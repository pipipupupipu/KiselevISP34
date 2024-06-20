using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace KiselevISP34
{
    internal class Program
    {
        int Sum(int a, int b)
        {
            return a + b;
        }
        double CircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
        int StringLength(string str)
        {
            return str.Length;
        }
        int MaxValue(int[] array)
        {
            int max = array[0];
            foreach (int value in array)
            {
                if (value > max)
                {
                    max = value;
                }
            }
            return max;
        }
        long Factorial(int n)
        {
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);
        }
        bool IsPalindrome(string str)
        {
            int left = 0;
            int right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                {
                    return false;
                }
                left++;
                right--;
            }
            return true;
        }
        int[] CombineArrays(int[] array1, int[] array2)
        {
            int[] result = new int[array1.Length + array2.Length];
            array1.CopyTo(result, 0);
            array2.CopyTo(result, array1.Length);
            return result;
        }
        bool IsPrime(int number)
        {
            if (number <= 1)
            {
                return false;
            }
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
        string ReverseString(string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        int SumOf2DArray(int[,] array)
        {
            int sum = 0;
            foreach (int value in array)
            {
                sum += value;
            }
            return sum;
        }

        static void Main(string[] args)
        {
        }
    }
}
