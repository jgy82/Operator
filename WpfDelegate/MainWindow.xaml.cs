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

namespace WpfDelegate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //public MainWindow()     // 构造器
        //{
        //    InitializeComponent();
        //    myButton.Click += delegate (object sender, RoutedEventArgs e)       // 事件处理器,通过+=挂接事件处理器
        //                                                                        // 操作符delegate此处用于声明匿名方法,该技术已经过时
        //                                                                        // 匿名方法由于没有名称,不能被重复调用
        //    {
        //        myTextBox.Text = "hello world";
        //    };
        //}
        //public MainWindow()     // 构造器
        //{
        //    InitializeComponent();
        //    myButton.Click += (sender, e) =>          // 事件处理器,通过+=挂接事件处理器.=>是新型的λ表达式
        //                                              // λ表达式不需要数据类型,编译器能自动推断变量类型
        //    {
        //        myTextBox.Text = "hello world";
        //    };
        //}
        
        // exercise
        public MainWindow()
        {
            InitializeComponent();
            myButton.Click += (sender, e) =>
            {
                myTextBox.Text = "hello world";
            };
        }
    }
}
