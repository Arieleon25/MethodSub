using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSub
{
    class Program
    {
        static void Main(string[] args)
        {
            OptionMath OptionNum = new OptionMath();
            Console.WriteLine("Input 2 numbers, one at a time. Second number is optional: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            try
            {
                int userInput2 = Convert.ToInt32(Console.ReadLine());
                OptionNum.Om1(userInput, userInput2);
            }
            catch (FormatException)
            {
                OptionNum.Om1(userInput);
            }
            Console.ReadLine();
        }
    }
}
