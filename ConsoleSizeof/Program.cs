using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSizeof
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                int x = sizeof(Test);
                Console.WriteLine(x);
            }
            unsafe
            {
                int y = sizeof(Test);
                Console.WriteLine(y);
            }
            
        }
    }
    struct Test     // 声明一个结构体类型(类class类型,结构体struct类型)
    {
        long x;
        decimal y;
        double z;
    }
}
