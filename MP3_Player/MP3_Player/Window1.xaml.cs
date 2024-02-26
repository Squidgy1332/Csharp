using Microsoft.Win32;
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
using NAudio.Wave;

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    /// 
    public partial class Window1 : System.Windows.Window
    {
        private readonly IWavePlayer Song = new WaveOutEvent();
        private readonly AudioFileReader audioFileReader;

        public Window1(string song)
        {
            audioFileReader = new AudioFileReader(song);
            Song.Init(audioFileReader);
            InitializeComponent();
            PlayB.Content = "Pause";
            Song.Play();
        }

        private void StopB_Click(object sender, RoutedEventArgs e)
        {
            Song.Stop();
            this.Close();
        }

        private void PlayB_Click(object sender, RoutedEventArgs e)
        {
            if(Song.PlaybackState == PlaybackState.Playing)
            {
                PlayB.Content = "Play";
                Song.Pause();
            }
            else if(Song.PlaybackState == PlaybackState.Paused)
            {
                PlayB.Content = "Pause";
                Song.Play();
            }
        }

        private void MusicProgBar_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e){}
    }
}
