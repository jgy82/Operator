using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _T_x
{
    class Program
    {
        static void Main(string[] args)
        {
            Teacher t = new Teacher();
            Human h = t;
            Teacher t1;
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("eating...");
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
        public static int x = 1;
        public void Teach()
        {
            Console.WriteLine("i teach programming.");
        }
    }
}