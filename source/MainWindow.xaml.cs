using System;
using System.Windows;

namespace EMRADIO {
    public partial class MainWindow : Window {
        private bool _playing;
        public MainWindow() { this.InitializeComponent(); }

        private void button1_Click( object sender, RoutedEventArgs e ) {
            this.Button1.Content = this._playing ? "Play" : "Stop";
            this._playing ^=true;
            if ( this._playing )
                try {
                    this.MediaElement1.Source = new Uri( this.CmbUrl.Text );
                    this.MediaElement1.Play();
                }
                catch ( Exception ex ) {
                    MessageBox.Show( "Error occured:\r\n" + ex.Message, "Can't start playing", MessageBoxButton.OK, MessageBoxImage.Error );
                }
            else
                this.MediaElement1.Stop();
        }
    }
}