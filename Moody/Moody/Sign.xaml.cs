using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI;
// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Moody
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Sign : Page
    {
        public Sign()
        {
            this.InitializeComponent();
        }
        public void mail_gf(object sender, RoutedEventArgs e)
        {
            if (mail.Text.Equals("邮箱"))
            {
                mail.Text = "";
            }
            mail.Foreground = new SolidColorBrush(Colors.Black);
        }
        public void mail_lf(object sender, RoutedEventArgs e)
        {
            if (mail.Text.Length == 0)
            {
                mail.Text = "邮箱";
                mail.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
        public void pass_gf(object sender, RoutedEventArgs e)
        {
            if (pass.Text.Equals("密码"))
            {
                pass.Text = "";
            }
            pass.Foreground = new SolidColorBrush(Colors.Black);
        }
        public void pass_lf(object sender, RoutedEventArgs e)
        {
            if (pass.Text.Length == 0)
            {
                pass.Text = "密码";
                pass.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
        public void passconfirm_gf(object sender, RoutedEventArgs e)
        {
            if (passconfirm.Text.Equals("确认密码"))
            {
                passconfirm.Text = "";
            }
            passconfirm.Foreground = new SolidColorBrush(Colors.Black);
        }
        public void passconfirm_lf(object sender, RoutedEventArgs e)
        {
            if (passconfirm.Text.Length == 0)
            {
                passconfirm.Text = "确认密码";
                passconfirm.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }
        public void name_gf(object sender, RoutedEventArgs e)
        {
            if (name.Text.Equals("用户名"))
            {
                name.Text = "";
            }
            name.Foreground = new SolidColorBrush(Colors.Black);
        }
        public void name_lf(object sender, RoutedEventArgs e)
        {
            if (name.Text.Length == 0)
            {
                name.Text = "用户名";
                name.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }
        public void goback_login(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }
    }
}
