using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach(var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
                if (num %2 != 0)
                {
                    sum -= num;
                }
            }return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            List<int> stringLengths = new List<int>
            {
                str1.Length,
                str2.Length,
                str3.Length,
                str4.Length
            
            };
            return stringLengths.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            List<int> numbers = new List<int>
            {
                number1,
                number2,
                number3,
                number4
            };
            return numbers.Min();
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
            biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            return (sideLength1 + sideLength2 > sideLength3 && 
                    sideLength1 + sideLength3 > sideLength2 && 
                    sideLength2 + sideLength3 > sideLength1);
        }

        public bool IsStringANumber(string input)
        {
            bool isNumber = double.TryParse(input, out double number);
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var arrayLength = objs.Length;
            var majorityOfElements = (arrayLength / 2) + 1;

            var numOfNullElements = 0;

            foreach (var element in objs)
            {
                if (element == null)
                {
                    numOfNullElements++;
                }
            }

            if(numOfNullElements >= majorityOfElements)
            {
                return true;
            }
            else return false;
        }

        public double AverageEvens(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            
            //List<double> evens = new List<double>();   // <-- Will try this way later
            //for(int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] % 2 == 0)
            //    {
            //        evens.Add(numbers[i]);  
            //    }
            //}return evens.Average();
            var sum = 0.0;
            var evensCount = 0.0;

            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    sum += num; //sum = sum + num
                    evensCount++;
                }
            }
            if (evensCount > 0)
            {
                return sum / evensCount;
            }
            else return 0;
        }

        public int Factorial(int number)
        {
            var factorial = 1;

            if (number < 0)
            {
                throw new ArgumentOutOfRangeException(); //I should have read the tests page sooner
            }
            for (int i = number; i > 0; i--)
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
