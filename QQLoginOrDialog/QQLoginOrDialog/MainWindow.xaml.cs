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

namespace QQLoginOrDialog
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)      //登录按钮
        {
            if (cbxUserName.ToString() == "1473072427" & tbxPassword.ToString() == "123")   //账号密码检测是否正确
            {
                LoginFrame.Visibility = Visibility.Collapsed;       //折叠登录界面
                DialogFrame.Visibility = Visibility.Visible;        //显示聊天界面
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Erweima_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void SE_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Delete_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Exit_Click(object sender, RoutedEventArgs e)       //关闭按钮
        {
            LoginFrame.Visibility = Visibility.Visible;                     //显示登陆界面
            DialogFrame.Visibility = Visibility.Collapsed;                  //折叠对话界面
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
