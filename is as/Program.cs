using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace is_as
{
    class Program
    {
        static void Main(string[] args)
        {
            // is
            Teacher t = new Teacher();
            var result = t is Teacher;      // 对比t引用的实例是否是Teacher类
            Console.WriteLine(result.GetType());
            Teacher t1 = null;
            result = t1 is Teacher;      // 当实例为空null时,值是False
            Console.WriteLine(result.GetType());
            result = t is Human;        // 子类属于父类,所以值为真
            Console.WriteLine(result);

            // as
            Object o = new Teacher();
            Teacher t3;
            //if(o is Teacher)
            //{
            //    t3 = (Teacher)o;
            //}
            t3 = o as Teacher;      // 等价上面代码:若o和Teacher相似,那么把o地址赋给t3,否则赋值null
        }
    }
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating");
        }
    }
    class Human : Animal
    {
        //public int age;
        public void Think()
        {
            Console.WriteLine("Who am i");
        }
    }
    class Teacher : Human
    {
        //public string name;
        public void Teach()
        {
            Console.WriteLine("I teach programing");
        }
    }
}
