using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay04
{
    public class NumberSystem
    {
        static int[] nums = new int[] { 12, 12, 4, 3, 12, 43, 12, 45, 5, 6, 773, 565 };
        public static void OddNum()
        {
            foreach (int i in nums)
            {
                if(i % 2 == 1) 
                    Console.WriteLine(i);
            }
        }
        public static void EvenNum()
        {
            foreach (int i in nums)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i);
            }
        }
    }
}
