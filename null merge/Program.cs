using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace null_merge
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x;
            //x = null;  非法
            Nullable<int> x = null;     // 可空类型
            x = 100;
            Console.WriteLine(x.HasValue);      // 判断x是否有数值
            int? x1 = null;     // 可空类型简写
            int y = x1 ?? 1;     // x1如果是null,则给y赋值1,x1不变
            Console.WriteLine(x1);
            Console.WriteLine(y);

            // ?:
            int i = 80;
            //string str = string.Empty;
            //if(x >= 60) str = "Pass";
            //else str = "Failed";
            string str = (x >= 60 ? "Pass" : "Failed");      // 等价上面的三行if-else语句,:左边是条件判断成功返回值,右边是失败后返回值
            Console.WriteLine(str);
        }
    }
}
