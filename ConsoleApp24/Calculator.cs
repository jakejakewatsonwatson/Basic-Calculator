using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp24
{
    class Calculator
    {
        public int Add(params int[] numbers)
        {
            var sum = 0;
            foreach (var number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public int Subtract(int minuend, int subtrahend) => minuend - subtrahend;

        public int Multiply(int a, int b)
        {
            return a * b;
        }

        public double Divide(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                return 0;
            }

            return (double)dividend / divisor;
        }


    }
}
