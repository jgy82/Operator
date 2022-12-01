using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace @new
{
    class Program
    {
        static void Main(string[] args)
        {
            //操作符new
            // 创建实例,调用实例构造器,调用实例初始化器并同时给多个属性赋值
            Form myForm = new Form() { Text = "hello", FormBorderStyle = FormBorderStyle.SizableToolWindow };
            myForm.ShowDialog();

            var x = 30;     // var自动判断有明确数据类型的数据
            var y = new { name = "John", age = 13 };        // var配合操作符new能创建全新的数据类型,灵活性高
            Console.WriteLine(y.GetType().Name);

            // 关键字new
            Student stu = new Student();
            stu.Report();
            CsStudent cstu = new CsStudent();
            cstu.Report();      // 父类方法被隐藏后

            // exercise
            double[] test = new double[] { 1.1, 2.2, 3.3 };
            Form test2 = new Form() { Text = "yes" };
            test2.ShowDialog();

            var i = new { key = 1, content = "dict" };
            Console.WriteLine(i.content);
        }
    }
    class Student
    {
        public void Report()
        {
            Console.WriteLine("111");
        }
    }
    class CsStudent : Student
    {
        new public void Report()        // 关键字new(修饰符),用于在子类对父类的方法隐藏
        {
            Console.WriteLine("222");
        }
    }
    // exercise
    class NewStudent : Student
    {
        public new void Report()
        {
            Console.WriteLine("333");
        }
    }
}
