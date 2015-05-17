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
using Windows.UI.Xaml.Media.Imaging;
//using System.Threading;

// “空白页”项模板在 http://go.microsoft.com/fwlink/?LinkId=234238 上有介绍

namespace Moody
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Mood> allMood = new List<Mood>() {
            new Mood("Funny", "Assets/Mood/3d_funny.png"),
            new Mood("Delighted", "Assets/Mood/delighted.png"),
            new Mood("Very Delighted", "Assets/Mood/very_delighted.png"),
            new Mood("Excited", "Assets/Mood/excited.png"),
            new Mood("Extremely Happy", "Assets/Mood/extremely_happy.png"),
            new Mood("Laugh", "Assets/Mood/laugh.png"),
            new Mood("A little Shock", "Assets/Mood/3d_shock.png"),
            new Mood("Shock", "Assets/Mood/shock.png"),
            new Mood("Angry", "Assets/Mood/angry.png"),
            new Mood("A Little Sad", "Assets/Mood/a_little_sad.png"),
            new Mood("Sad", "Assets/Mood/sad.png"),
            new Mood("Very Sad", "Assets/Mood/very_sad.png"),
            new Mood("Cry", "Assets/Mood/cry.png"),
        };

        DispatcherTimer moodImageChangeAnimationTimer;

        public MainPage()
        {
            this.InitializeComponent();
            this.moodSelector.ItemsSource = this.allMood;
            moodImageChangeAnimationTimer = new DispatcherTimer();
            moodImageChangeAnimationTimer.Interval = new System.TimeSpan(0, 0, 0, 0, 500);

        }

        private void setMoodsShowPushOneByOne(string newMood)
        {
                moodShowImage1.Source = moodShowImage2.Source;
                moodShowImage2.Source = moodShowImage3.Source;
                moodShowImage3.Source = moodShowImage4.Source;
                moodShowImage4.Source = moodShowImage5.Source;
                moodShowImage5.Source = moodShowImage6.Source;
                moodShowImage6.Source = moodShowImage7.Source;
                moodShowImage7.Source = new BitmapImage(new Uri("ms-appx:///" + newMood));
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Statistics));
        }

        private void signout_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(Login));
        }

        private void moodSelector_ItemClick(object sender, ItemClickEventArgs e)
        {
            int index = moodSelector.Items.IndexOf(e.ClickedItem);
            
            // 当前心情有十三种,所以分数为100 - 7 * index
            addNewMood(new SingleMoodRecord(DateTime.Today.ToString(), 100 - (7 * index), allMood[index].src));
        }

        /// <summary>
        ///  添加心情
        /// </summary>
        /// <param name="mood"></param>
        private void addNewMood(SingleMoodRecord mood)
        {
            setMoodsShowPushOneByOne(mood.moodImage);
        }

        // 心情描述输入
        private void inputTextBox_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            if (e.Key == Windows.System.VirtualKey.Enter)
            {
                inputTextBox.Text += "\n";
                inputTextBox.SelectionStart = inputTextBox.Text.Length;
            }
            
        }
    }
}
