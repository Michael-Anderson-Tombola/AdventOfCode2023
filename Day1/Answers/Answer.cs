using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Day1.Question1
{
    public static class Answer
    {

        public static Dictionary<string, int> NumWords = new()
        {
            { "one", 1 },
            { "two", 2 },
            { "three", 3 },
            { "four", 4 },
            { "five", 5 },
            { "six", 6 },
            { "seven", 7 },
            { "eight", 8 },
            { "nine", 9 },
        };

        //question 1 calculate callibrations from taking first and last number in a string and sum them all together 
        public static int Question1(string[] strings)
        {
            int finalSum = 0;
            foreach (string s in strings)
            {
                string numStr = Regex.Replace(s, "[^0-9]", "");
                int n;
                int.TryParse(
                    $"{numStr[0]}{numStr[numStr.Length - 1]}", out n);
                finalSum += n;
            }
            return finalSum;
        }

        //question 2 same as question 1 but with number words 
        public static int QuestionTwo(string[] strings)
        {
            //regex to match any numbers or number words 
            string regex = @"[0-9]|one|two|three|four|five|six|seven|eight|nine";
            int answer = 0;

            foreach (string s in strings)
            {

                //get first substring that matches the regex pattern
                Match leftMatch = Regex.Match(s, regex, RegexOptions.IgnoreCase);

                //get last substirng that matches the regex pattern
                var opts = RegexOptions.IgnoreCase | RegexOptions.RightToLeft;
                Match rightMatch = Regex.Match(s, regex, opts);

                int first = 0;
                int last = 0;

                //try parse int, if not a number then get the nubmer from the dict
                if (!int.TryParse(leftMatch.Value, out first))
                {
                    first = NumWords[leftMatch.Value];
                }

                //do same for last match
                if (!int.TryParse(rightMatch.Value, out last))
                {
                    last = NumWords[rightMatch.Value];
                }

                //Console.WriteLine($"{first}{last}");

                //add sum of each string
                answer += int.Parse($"{first}{last}");

            }
            return answer;
        }

    }
}
