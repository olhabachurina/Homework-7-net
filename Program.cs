using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7_net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 105, 210, 325, 456, 521, 666, 777, 888, 889, 910 };
            Array array = new Array(numbers);

            int lessCount = array.Less(521);
            int greaterCount = array.Greater(521);

            Console.WriteLine($"Less than 521: {lessCount} elements");
            Console.WriteLine($"Greater than 521: {greaterCount} elements");
            array.ShowEven();
            array.ShowOdd();
        }
    }
}
