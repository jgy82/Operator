using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace logic_or_xor_and
{
    class Program
    {
        static void Main(string[] args)
        {
            // or xor and一般在操作二进制或图片时常用
            int x = 7;
            int y = 8;
            int z = x & y;      // 位与操作符,按位取值,1是真0是假,仅1&1为真
            Console.WriteLine(z);
            z = x ^ y;      // 位异或,不同为真
        }
    }
}
