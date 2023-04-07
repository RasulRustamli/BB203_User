using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    internal static class Helper
    {
       public static int MatchCount(this string words, string word)
        { 
            int count=0;
            string[] wordsArray = words.Split(' ');  
            foreach (string item in wordsArray)
            {
                if (item.ToLower() == word.ToLower())
                {
                    count++;
                }
            }
            return count;


        }
        public static void CheckPalendromee(this int number)
        {
            int oldNum = number;
            int mertebe = 0;
            int newNum = 0;
            while (number > 0)
            {
                mertebe = number % 10;
                newNum = newNum * 10 + mertebe;
                number /= 10;
            }
            if (oldNum == newNum)
            {
                Console.WriteLine("Palindromdur");
            }
            else
            {
                Console.WriteLine("Palindrom deyil");

            }
        }

    }
}
