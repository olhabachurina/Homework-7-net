using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_net
{
    public class Array : IClac, IOutput2
    {
        private int[] array;

        public Array(int[] array)
        {
            this.array = array;
        }

        public int Less(int valueToCompare)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element < valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }

        public int Greater(int valueToCompare)
        {
            int count = 0;
            foreach (int element in array)
            {
                if (element > valueToCompare)
                {
                    count++;
                }
            }
            return count;
        }
        public void ShowEven()
        {
            Console.Write("Even numbers: ");
            foreach (int element in array)
            {
                if (element % 2 == 0)
                {
                    Console.Write($"{element} ");
                }
            }
            Console.WriteLine();
        }

        public void ShowOdd()
        {
            Console.Write("Odd numbers: ");
            foreach (int element in array)
            {
                if (element % 2 != 0)
                {
                    Console.Write($"{element} ");
                }
            }
            Console.WriteLine();


        }
    }
}

