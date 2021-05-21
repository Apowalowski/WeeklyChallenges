using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            if(startNumber == 0)
            {
                return n;
            }
            var divisibleNum = 0;
            for (int i = 0; i < startNumber * n; i++)
            {
                if (i > startNumber && i % n == 0)
                {
                    divisibleNum = i;
                    break;
                }
            }
            return divisibleNum;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for(int i = 0; i < businesses.Length; i++)
            {
                if(businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";
                }
            }
            
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if(numbers == null || numbers.Length == 0)
            {
                return false;
            }
            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i] < numbers[i - 1])
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if(numbers == null)
            {
                return 0;
            }
            
              int sum = 0;

            
           
            for(int i = 1; i < numbers.Length; i++)
            {
                if(numbers[i - 1] % 2 == 0)
                {
                   
                        sum += numbers[i];
                    
                    
                }
                

            }
            return sum;
        }

        public string TurnWordsIntoSentence(string[] words)
        {
            string sentence = "";
            
            if (words == null)
            {
                return "";
            }
            sentence = string.Join(" ", words.Where(x => x != " " && x != "" && x != "  ").Select(y => y.Trim()));
            
          
            return sentence.Trim() + ".";
           
        }

        public double[] GetEveryFourthElement(List<double> elements)
        {
           
            if(elements == null || elements.Count == 0)
            {
                return new double[0];
            }
            var everyFourth = new List<double>();
            for(int i = 3; i < elements.Count; i += 4)
            {
                everyFourth.Add(elements[i]);
            }
            return everyFourth.ToArray();
           
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            
            for(int i = 0; i < nums.Length; i++)
            {
                for(int j = i + 1; j < nums.Length; j++)
                {
                    if(nums[i] + nums[j] == targetNumber)
                    {
                        return true;
                    }
                   
                }
            }
        }
    }
}
