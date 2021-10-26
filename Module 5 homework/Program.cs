using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Module_5_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            string input1 = "+35 392-022-194";
            string input2 = "+958 28492-503";
            string pattern = (@"^\+\d{2}\s*\d{3}-\d{3}-\d{3}$");

            var rgx = new Regex(pattern);
            var match1 = rgx.Match(input1);
            var match2 = rgx.Match(input2);

            if (rgx.IsMatch(input1))
            {
                Console.WriteLine($"Valid phone number is {match1.Value}");
            }
            else
            {
                Console.WriteLine($"Invalid phone number");

            }


            if (rgx.IsMatch(input2))
            {
                Console.WriteLine($"Valid phone number is {match2.Value}");
            }
            else
            {
                Console.WriteLine($"Invalid phone number");
                Console.ReadLine();
            }
        }
    }
}
