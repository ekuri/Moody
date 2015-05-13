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
        public MainPage()
        {
            this.InitializeComponent();
            this.moodSelector.ItemsSource = this.allMood;
        }
    }
}
