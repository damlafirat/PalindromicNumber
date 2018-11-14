using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromicNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(palindromicNumberCheck(751357));

            Console.ReadLine();
        }

        private static bool palindromicNumberCheck(int v)
        {
            int reverse = 0;
            int temp = v;

            while (temp != 0)
            {
                reverse = reverse * 10 + (temp % 10);
                temp = (temp - (temp % 10))/10;
            }

            if (reverse == v)
                return true;

            else
                return false;
        }
    }
}
