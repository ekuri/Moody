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

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Moody
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class Statistics : Page
    {
        List<SimgleMoodRecord> allMoodRecord = new List<SimgleMoodRecord>() {
            new SimgleMoodRecord("2015-03-01", 300, "Assets/mood_ball.png"),
            new SimgleMoodRecord("2015-03-01", 400, "Assets/mood_ball.png"),
            new SimgleMoodRecord("2015-03-01", 100, "Assets/mood_ball.png"),
            new SimgleMoodRecord("2015-03-01", 50, "Assets/mood_ball.png"),
            new SimgleMoodRecord("2015-03-01", 300, "Assets/mood_ball.png"),
        };

        List<User> allUser = new List<User>() {
            new User("ekuri", "Assets/portrait/1.jpeg"),
            new User("ekuri1", "Assets/portrait/2.jpg"),
            new User("ekuri2", "Assets/portrait/3.jpg"),
            new User("ekuri3", "Assets/portrait/4.jpeg"),
            new User("ekuri4", "Assets/portrait/5.jpg"),
            new User("ekuri5", "Assets/portrait/6.jpg"),
            new User("ekuri6", "Assets/portrait/7.jpg"),
            new User("ekuri7", "Assets/portrait/8.jpg"),
            new User("ekuri8", "Assets/portrait/9.jpg"),
            new User("ekuri9", "Assets/portrait/10.jpg"),
        };

        public Statistics()
        {
            this.InitializeComponent();
            moodStatisticListView.ItemsSource = allMoodRecord;
            moodStatisticListView.SelectionMode = ListViewSelectionMode.None;
            friendListView.ItemsSource = allUser;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void friendListView_ItemClick(object sender, ItemClickEventArgs e)
        {

        }
    }
}
