using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyExam
{
    public class Exam
    {
        public float Average(float first, float second)
        {
            float sum = first + second;
            float avg = sum / 2;
            return avg;
        }

        public int MinMax(int number)
        {
            var numberToArray = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            int min = numberToArray[0];
            int max = 0;
            for (int x = 0; x < numberToArray.Length; x++)
			{
                if (numberToArray[x] > max)
                {
                    max = numberToArray[x];
                }
                else if (numberToArray[x] < min)
                {
                    min = numberToArray[x];
                }
			}
            return max;
        }

        public String BubbleSort(int number)
        {
            var numberToArray = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            for (int i = 0; i < numberToArray.Length; i++)
            {
                
                for (int x = 0; x < numberToArray.Length - 1; x++)
                {
                    if (numberToArray[x] > numberToArray[x + 1])
                    {
                        
                        int temp = numberToArray[x + 1];
                        ;
                        numberToArray[x + 1] = numberToArray[x];
                        numberToArray[x] = temp;
                        
                    }
                } 
            }
            string result = String.Join("", numberToArray);
            return result;
        }

        public String BinarySearch(int number, int k)
        {
            Console.WriteLine("Input Number: " + number);
            Console.WriteLine("searching for: " + k);
            var numberToArray = number.ToString().Select(t => int.Parse(t.ToString())).ToArray();
            string found = "false";
            int mid = -1;
            int left = 0;
            int right = numberToArray.Length - 1;

            while (left <= right)
            {
                Console.WriteLine("position of middle: " + mid);
                Console.WriteLine("left limit: " + left);
                Console.WriteLine("right limit: " + right);
                mid = (left + right) / 2;
                if (numberToArray[mid] == k)
                {
                    found = "true";
                    Console.WriteLine("number " + k + " found!!");
                    Console.WriteLine("middle number equals to " + k);
                    Console.WriteLine("Value in the middle position: " + numberToArray[mid]);
                    Console.WriteLine("position of middle: " + mid);
                    Console.WriteLine("left limit: " + left);
                    Console.WriteLine("right limit: " + right);
                    return found;
                }
                else if (numberToArray[mid] > k)
                {
                    right = mid - 1;
                    Console.WriteLine("middle of " + numberToArray[mid] + " is greater than " + k + " store at the right limit middle's position minus 1");
                    Console.WriteLine("Value in the middle position: " + numberToArray[mid]);
                    Console.WriteLine("position of middle: " + mid);
                    Console.WriteLine("left limit: " + left);
                    Console.WriteLine("right limit: " + right);
                }
                else
                {
                    left = mid + 1;
                    Console.WriteLine("middle of " + numberToArray[mid] + " is smaller than " + k + " store at the left limit middle's position plus 1");
                    Console.WriteLine("Value in the middle position: " + numberToArray[mid]);
                    Console.WriteLine("position of middle " + mid);
                    Console.WriteLine("left limit: " + left);
                    Console.WriteLine("right limit: " + right);
                }
                if (found == "false")
                {
                    Console.WriteLine("number " + k + " doesn't exist into the input!");
                }
            }
            return found;
        }
    }
}
