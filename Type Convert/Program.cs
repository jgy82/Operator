using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Type_Convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Stone stone = new Stone();
            stone.age = 1000;
            Monkey wuKong = (Monkey)stone;      // 类转换
            Console.WriteLine(wuKong.age);
        }
    }
    class Stone
    {
        public int age;
        public static explicit operator Monkey(Stone stone)     // 实现类转换在类内部的支撑.对比类的构造器
        {
            Monkey m = new Monkey();
            m.age = stone.age / 500;
            return m;
        }
    }
    class Monkey
    {
        public int age;
    }
}
