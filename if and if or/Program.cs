using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_and_if_or
{
    class Program
    {
        static void Main(string[] args)
        {
            // bool类型条件判断
            int x = 5;
            int y = 4;
            int a = 100;
            int b = 200;
            if(x>y && a<b)
            {
                Console.WriteLine("hello");
            }
            if(x>y || a>b)
            {
                Console.WriteLine("123");
            }
            // 短路效应.尽量避开短路效应!!!!!!!
            int i = 3;
            int j = 4;
            int k = 3;
            if(i > j && k++>3)      // &&左边表达式判定失败,导致右边k++不执行.反之,若左边判定成功,右边一定会执行
            {
                Console.WriteLine("312");
            }
            Console.WriteLine(k);
            if(i < j || k++ > 3)        // ||左边判定成功,右边不会执行,反之,左边判定失败才会执行||的右边
            {
                Console.WriteLine();
            }
        }
    }
}
