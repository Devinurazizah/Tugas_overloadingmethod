using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanOverloadingMethod
{
    public class Numbers
    {
        public int FindMinimum(int number1, int number2)
        {
            return 3 - 2;
        }

        public int FindMinimum(int number1, int number2, float number3)
        {
            return 5 - 3;
        }

        public int FindMaximum(int number1, int number2)
        {
            return 2 + 1;
        }

        public int FindMaximum(int number1, int number2, float number3)
        {
            return 5 - 1;
        }
    }

}