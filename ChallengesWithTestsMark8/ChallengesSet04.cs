using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)
        {
            var sum = 0;
            foreach (var num in numbers)
            {
                
                if(num % 2 == 0)
                {
                    sum += num;
                }
                if(num % 2 != 0)
                {
                    sum -= num;
               
                }
               
            }
            return sum;
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            var list = new List<int>() { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
          
            var otherList = new List<int>() { number1, number2, number3, number4 };
            return otherList.Min();
        }


        public void ChangeBusinessNameTo_TrueCoders(Business biz)
        {
           biz.Name = "TrueCoders";
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)
        {
            //any two sides have to be bigger than the third
            //if statement to compare all combinations of two sides being greater than the third side
           return new int[] {sideLength1, sideLength2, sideLength3}.OrderByDescending(x => x).Aggregate((agg, num) => agg - num) < 0;
        }

        public bool IsStringANumber(string input)
        {
            double doublex;
            //tryparse
            if(input == "")
            {
                return false;
            }
            else if(input == null)
            {
                return false;
            }
            if (double.TryParse(input, out doublex))
            {
                return true;
            }
            return input.All(char.IsDigit);
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            //linq
            //var majority = Objects.Length / 2;
            return objs.Count(x => x == null) > objs.Length / 2;
        }

        public double AverageEvens(int[] numbers)
        {
            //return numbers.Where(x => x % 2 == 0; ""
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            var avgNums = numbers.Where(num => num % 2 == 0);

            if (avgNums.Count() == 0)
                return 0;

            return avgNums.Average();
        }

        public int Factorial(int number)
        {
            if(number < 0)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (number == 0)
                return 1;
            else
                return number * Factorial(number - 1);
        }
    }
}
