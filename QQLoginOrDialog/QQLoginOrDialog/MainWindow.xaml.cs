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
            cbxUserName.ItemsSource = zhanghaos;     //将键值对添加到cbxUsserName中
            cbxUserName.SelectedValuePath = "Key";      //Combox下拉栏中显示的值
            cbxUserName.DisplayMemberPath = "Key";      //Combox下拉栏中选中后实际显示的值
        }
        Dictionary<string, string> zhanghaos = new Dictionary<string, string>()     //创建键值对
            {
                {"1473072427","123"},
                {"2638456801","456"},
                {"2645296273","789"}
            };
        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tbxPassword.Password = ((KeyValuePair<string, string>)cbxUserName.SelectedItem).Value;      //当cbxUserName被选中了值（即键Key），让tbxPassword框显示被选中值对应的密码（即值Value）
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Login_Click(object sender, RoutedEventArgs e)      //登录按钮
        {
            if (zhanghaos.ContainsKey(cbxUserName.Text) & zhanghaos.ContainsValue(tbxPassword.Password))   //账号密码检测是否正确

            {
                LoginFrame.Visibility = Visibility.Collapsed;       //折叠登录界面
                DialogFrame.Visibility = Visibility.Visible;        //显示聊天界面
                MessageBox.Show("登录成功，进入聊天！");                      //显示登录成功
            }
            else
            {
                MessageBox.Show("账号或密码错误！");                //显示登录失败
            }
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Erweima_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
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



        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void MinButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Show_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ModifyButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Sending_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Min_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Max_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Exit0_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void Spread_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
