using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EMRADIO
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool playing = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            button1.Content = playing ? "Play" : "Stop";
            if (!playing)
            {
                try
                {
                    mediaElement1.Source = new Uri(cmb_url.Text);
                    mediaElement1.Play();
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Error occured:\r\n" + ex.Message, "Can't start playing", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                mediaElement1.Stop();
            }
            playing = !playing;
        }
    }
}
