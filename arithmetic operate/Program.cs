using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arithmetic_operate
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = 3 + "a";        // 自动判定运算符两边数据类型
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);
            var x1 = 3 + 'a';
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);
            var x2 = 3.0 + 4;       // "数值提升",从int变为double
            Console.WriteLine(x.GetType());
            Console.WriteLine(x);

            double a = double.PositiveInfinity;     // 正无穷
            double b = double.NegativeInfinity;     // 负无穷
            double c = a / b;
            Console.WriteLine(c);       // NaN not a number
            double d = (double)5 / 4;       // 数据类型提升,除号两边数据类型不同,会自动向更高精度的数据类型转换
            Console.WriteLine(d);
            double e = 5.0 / 4;     // 和上条表达式等价
            Console.WriteLine(e);

            for (var i = 0; i < 100; i++)
            {
                double f = i % 3.1;        // double类型取余
                Console.WriteLine(f);
            }

            int num1 = 7;
            int num2 = num1 << 1;       // 位移操作符,左移<<1位,二进制每左移一位即乘2
                                        // 容易数据溢出,用checked检查溢出
            Console.WriteLine(Convert.ToString(num1, 2).PadLeft(32, '0'));
            Console.WriteLine(Convert.ToString(num2, 2).PadLeft(32, '0'));
            Console.WriteLine(num1);
            Console.WriteLine(num2);
        }
    }
}
