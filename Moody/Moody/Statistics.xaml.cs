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
        List<SingleMoodRecord> allMoodRecord = new List<SingleMoodRecord>() {
            new SingleMoodRecord("2015-03-01", 300, "Assets/mood_ball.png"),
            new SingleMoodRecord("2015-03-01", 400, "Assets/mood_ball.png"),
            new SingleMoodRecord("2015-03-01", 100, "Assets/mood_ball.png"),
            new SingleMoodRecord("2015-03-01", 50, "Assets/mood_ball.png"),
            new SingleMoodRecord("2015-03-01", 300, "Assets/mood_ball.png"),
        };

        List<User> allUser = new List<User>() {
            new User("ekuri", "Assets/portrait/pic001.jpeg", "Happy every day"),
            new User("ekuri1", "Assets/portrait/pic002.jpg"),
            new User("ekuri2", "Assets/portrait/pic003.jpg"),
            new User("ekuri3", "Assets/portrait/pic004.jpeg"),
            new User("ekuri4", "Assets/portrait/pic005.jpg"),
            new User("ekuri5", "Assets/portrait/pic006.jpg"),
            new User("ekuri6", "Assets/portrait/pic007.jpg"),
            new User("ekuri7", "Assets/portrait/pic008.jpg"),
            new User("ekuri8", "Assets/portrait/pic009.jpg"),
            new User("ekuri9", "Assets/portrait/pic010.jpg"),
        };

        // 设置统计图表数据
        void setStatisticData(List<SingleMoodRecord> record)
        {
            allMoodRecord = record;
            moodStatisticListView.ItemsSource = record;
        }

        // 设置用户列表数据
        void setFriendListViewData(List<User> allfriend)
        {
            allUser = allfriend;
            friendListView.ItemsSource = allfriend;
        }

        public Statistics()
        {
            this.InitializeComponent();
            moodStatisticListView.SelectionMode = ListViewSelectionMode.None;

            setFriendListViewData(allUser);
            setStatisticData(allMoodRecord);
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void friendListView_ItemClick(object sender, ItemClickEventArgs e)
        {
            friendListView.SelectedItem = e.ClickedItem;
            int index = friendListView.Items.IndexOf(e.ClickedItem);
            notifyUserSelectedChanged(allUser[index]);
        }

        private void foretimeSelectComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (foretimeSelectComboBox != null) {
                int index;
                index = foretimeSelectComboBox.SelectedIndex;
                if (index == 0)
                    notifyStatisticsDataWithTime(new TimeSpan(7, 0, 0, 0));
                else if (index == 1)
                    notifyStatisticsDataWithTime(new TimeSpan(30, 0, 0, 0));
                else if (index == 2)
                    notifyStatisticsDataWithTime(new TimeSpan(90, 0, 0, 0));
                else if (index == 3)
                    notifyStatisticsDataWithTime(new TimeSpan(365, 0, 0, 0));
            }
        }

        // 用户选择统计时间变更
        private void notifyStatisticsDataWithTime(TimeSpan timeSpan)
        {

        }

        // 当前选中用户变更, 此时应该按照当前选择的时间限更改统计数据
        private void notifyUserSelectedChanged(User selectedUser)
        {

        }
    }
}
