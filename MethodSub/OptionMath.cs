using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodSub
{
    public class OptionMath
    {
        public void Om1 (int i, int i2 = 0)
        {
            int num1 = i + 5;
            int numOp = i2 - 2;
            Console.WriteLine(num1);
            Console.WriteLine("{0}", numOp);

        }
    }
}
