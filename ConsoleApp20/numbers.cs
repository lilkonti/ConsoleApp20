using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal struct Numbers
    {
        int originalNum;
        public Numbers()
        {
            originalNum = 8;
        }
        void toBinary()
        {
            int from = 10;
            int to = 2;

            string binary = Convert.ToString(Convert.ToInt32(originalNum, from), to);
            Console.WriteLine(binary);
        }
        void toEight() 
        {
            int from = 10;
            int to = 8;

            string binary = Convert.ToString(Convert.ToInt32(originalNum, from), to);
            Console.WriteLine(binary);
        }
        void toSixteen()
        {
            int from = 10;
            int to = 16;

            string binary = Convert.ToString(Convert.ToInt32(originalNum, from), to);
            Console.WriteLine(binary);
        }
    }
}
