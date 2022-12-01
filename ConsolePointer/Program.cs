using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePointer
{
    class Program
    {
        static void Main(string[] args)
        {
            unsafe
            {
                Test test;
                test.x = 1;
                test.y = 99;
                Test* ptest = &test;        // 指针*和取地址操作符&用于取变量test的地址,然后给指针变量ptest赋值
                ptest->x = 1000;         // 操作符->通过指针间接访问,修改值
                (*ptest).x = 100;       // 引用符号*ptest,和上句一样效果
                                        // *x符号比成员访问符.优先级低,需要()
                                        // 
                Console.WriteLine(test.x);      // test.x直接访问

                // exercise
                Test two = new Test();
                two.x = 1;
                two.y = 3;
                Test* place = &two;
                (*place).y = 10;
                Console.WriteLine(two.y);
            }
        }
    }
    struct Test
    {
        public int x;
        public long y;
    }
}
