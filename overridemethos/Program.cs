using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace overridemethos
{
    class Program
    {
        static int Power(int input)
        {
            return input * input;
        }
        static int Power(int input, int count)
        {
            for (int i = 1; i<=count; i++)
            {
                input = input * input;
            }
            return input;
        }
        static int SumAll(int end)
        {
            int i=0;
            for (i = 1; i < end; i++)
            {
                i += i;
            }
            return i;
        }
        static int SumAll(int start, int end)
        {
            int i=0;
            if (start > end)
            {
                for (i = start+1; i> end; i--)
                {
                    i += i;
                }
            }
            else if (start < end)
            {
                for (i = start+1; i < end; i++)
                {
                    i += i;
                }
            }
            return i;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Power(2));
            Console.WriteLine(Power(2, 3));
            Console.WriteLine(SumAll(10));
            Console.WriteLine(SumAll(0, 10));
        }
    } 
}
