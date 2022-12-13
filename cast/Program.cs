using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cast
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;        // 子类向父类隐式类型转换
            h.Eat();        // 引用变量仅能访问变量类型的成员,不能访问所引用的实例的成员

            // cast类型转换,强塞,可能会丢失精度或数值错误
            Console.WriteLine(ushort.MaxValue);
            uint x = 65536;
            ushort y = (ushort)x;
            Console.WriteLine(y);

            
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating");
        }
    }
    class Human : Animal
    {
        public void Think()
        {
            Console.WriteLine("who am i");
        }
    }
    class Teacher : Human
    {
        public void Teach()
        {
            Console.WriteLine("i teach programing");
        }
    }
}
