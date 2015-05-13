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
//using System.Threading;
using System;

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
            new Mood("Shock", "Assets/Mood/3d_shock.png"),
            new Mood("A Little Sad", "Assets/Mood/a_little_sad.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
            new Mood("", "Assets/3d_funny.png"),
        };

        Point moodBallCenter;
        DispatcherTimer timer;

        public MainPage()
        {
            this.InitializeComponent();
            this.moodSelector.ItemsSource = this.allMood;
            moodBall.Opacity = 0.5;
            //moodBallCenter = moodBall.Margin.
        }

        private void onUpperBall_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += new EventHandler<object>(incTempValue);
            timer.Start();
        }



        private void onLowerBall_PointerPressed(object sender, PointerRoutedEventArgs e)
        {
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            timer.Tick += new EventHandler<object>(decTempValue);
            timer.Start();
        }

        void incTempValue(object sender, object e)
        {
            if (temp.Value < 100)
            {
                temp.Value = temp.Value + 1;
                moodBall.Opacity += 0.01;
            }
        }

        void decTempValue(object sender, object e)
        {
            if (temp.Value > 0)
                temp.Value = temp.Value - 1;
        }

        private void onUpperOrLowerBall_PointerReleased(object sender, PointerRoutedEventArgs e)
        {
            timer.Stop();
        }


    }
}
