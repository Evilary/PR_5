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

namespace TV_Чернышков
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Classes.TV TV = new Classes.TV();
        public MainWindow()
        {
            InitializeComponent();


        }

        private void BackChannel(object sender, RoutedEventArgs e)
        {
            TV.BackChannel(VideoPlayer, NameChannel);
        }

        private void NextChannel(object sender, RoutedEventArgs e)
        {
            TV.NextChannel(VideoPlayer, NameChannel);
        }

        private void Power(object sender, RoutedEventArgs e)
        {
            TV.Power();
            if (TV.IsOn)
            {
                VideoPlayer.Source = new Uri(TV.Channels[TV.ActiveChannel].Src);
                VideoPlayer.Play();
                NameChannel.Content = TV.Channels[TV.ActiveChannel].Name;
            }
            else 
            {
                VideoPlayer.Stop();
                VideoPlayer.Source = null;
                NameChannel.Content = "Телевизор выключен";
            }
        }
    }
}
