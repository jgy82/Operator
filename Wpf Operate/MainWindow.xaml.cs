using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Wpf_Operate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            // 用Convert转换
            double x = Convert.ToDouble(tb1.Text);
            double y = Convert.ToDouble(tb2.Text);
            // 用Parse转换,仅在数据格式正确时
            //double x = double.Parse(tb1.Text);
            //double y = double.Parse(tb2.Text);
            double result = x + y;
            //tb3.Text = Convert.ToString(result);      用convert转换
            tb3.Text = result.ToString();       // 用double类型的tostring方法转换

            // 为什么很多类型都有ToString()方法
            object o = new object();
            o.ToString();       // object类型作为所有数据类型的父类,那么其所有子类必然继承该方法,ToString()方法就是把实例转换为字符串
        }
    }
}
