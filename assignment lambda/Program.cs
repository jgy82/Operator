using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_lambda
{
    class Program
    {
        static void Main(string[] args)
        {
            // 复合赋值操作符,*= += -= <<=  等等
            // 从右向左的运算顺序
            int x = 5;
            int y = 6;
            int z = 7;
            int i = x += y *= z;        // 按从右向左顺序,从y = y * z开始
        }
    }
}
