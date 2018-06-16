using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RomanToInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Roman Numeral");
            string s = Console.ReadLine();
            Console.WriteLine("The Integer for this Roman is : {0}", RomanToInt(s));
            Console.ReadKey();
        }
        public static int RomanToInt(string s)
        {
            int sum = 0;
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }

            Dictionary<char, int> dict = new Dictionary<char, int>()
            {
               {'I', 1},
               {'V', 5},
               {'X', 10},
               {'L', 50},
               {'C', 100},
               {'D', 500},
               {'M', 1000}
            };

            for (int i = 0; i < s.Length - 1; i++)
            {
                if (dict[s[i]] < dict[s[i + 1]])
                    sum = sum - dict[s[i]];
                else
                    sum = sum + dict[s[i]];
            }
            sum += dict[s[s.Length - 1]];

            return sum;
        }
    }
}
