using MVVM.Mock.ViewModels;
using System;
using System.Windows;


namespace MVVM.Mock
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new MainWindowViewModel();
            Action action = new Action( Print);
            action();
        }

        public void Print()
        {
            System.Console.WriteLine("asd");
            Console.Read();
        }
    }
}
