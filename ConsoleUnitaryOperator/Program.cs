using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUnitaryOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 8;
            string xstr = Convert.ToString(x, 2).PadLeft(32, '0');
            Console.WriteLine(xstr);
            Console.WriteLine(x);
            int y = -x;     // 负数,按位取反再加1,溢出!
            string ystr = Convert.ToString(y, 2).PadLeft(32, '0');
            Console.WriteLine(ystr);
            Console.WriteLine(y);
            int i = -y;
            string istr = Convert.ToString(i, 2).PadLeft(32, '0');
            Console.WriteLine(istr);
            Console.WriteLine(i);
            int z = ~x;     // 取反操作符,按位取反
            string zstr = Convert.ToString(z, 2).PadLeft(32, '0');
            Console.WriteLine(zstr);
            Console.WriteLine(z);

            Student stu = new Student("1");
        }
    }
    class Student
    {
        public Student(string iniName)
        {
            if (!string.IsNullOrEmpty(iniName))     // 逻辑操作符!
            {
                name = iniName;
            }
            else
            {
                throw new ArgumentException("iniName cannot be null or empty.");
            }
        }
        public string name;
    }
}
