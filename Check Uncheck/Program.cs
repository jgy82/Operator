using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Checked_Unchecked
{
    class Program
    {
        static void Main(string[] args)
        {
            uint x = uint.MaxValue;
            Console.WriteLine(x);
            string x_1 = Convert.ToString(x, 2);
            Console.WriteLine(x_1);

            // checked操作符用法
            try
            {
                uint y = checked(x + 1);     // 数据溢出检测,若改为unchecked则不会检测,unchecked是C#默认
                Console.WriteLine(y);
            }
            catch (OverflowException ex)       // 抓取数据溢出
            {

                Console.WriteLine("There's overflow");      // 溢出后执行的语句
            }

            // checked上下文用法
            checked         // 检查语句块内所有代码
            {
                try
                {
                    uint y = x + 1;
                }
                catch (OverflowException ex)
                {

                    Console.WriteLine("There's overflow");
                }
            }
        }
    }
}
