using Microsoft.Win32;
using NAudio.Wave;
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

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog FileExplorer = new OpenFileDialog();
        private readonly IWavePlayer Song = new WaveOutEvent();
        private AudioFileReader audioFileReader;
        private bool isPlaying = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FBrowser_Click(object sender, RoutedEventArgs e)
        {
            FileExplorer.Filter = "mp3 Files|*.mp3";
            if (isPlaying)
            {
                Song.Stop();
            }
          
            // Open up the users home directory when opened
            FileExplorer.InitialDirectory = System.Environment.GetEnvironmentVariable("USERPROFILE");
            FileExplorer.ShowDialog();


            if (FileExplorer.CheckFileExists && FileExplorer.CheckPathExists)
            {
                F_Path.Text = FileExplorer.FileName;
                audioFileReader = new AudioFileReader(FileExplorer.FileName);
            }
        }

        private void PlaySong(object sender, RoutedEventArgs e)
        {
            if (!isPlaying)
            {
                Song.Init(audioFileReader);
                PlayB.Content = "Pause";
                Song.Play();
                isPlaying = true;
            }
            else
            {
                if (Song.PlaybackState == PlaybackState.Playing)
                {
                    PlayB.Content = "Play";
                    Song.Pause();
                }
                else if (Song.PlaybackState == PlaybackState.Paused)
                {
                    PlayB.Content = "Pause";
                    Song.Play();
                }
            }
        }

        private void StopSong(object sender, RoutedEventArgs e)
        {
            Song.Stop();
            audioFileReader.Position = 0;
            PlayB.Content = "Play";
            isPlaying = false;
        }

        private void EditSong(object sender, RoutedEventArgs e)
        {
            EditData editWin = new EditData(FileExplorer.FileName);
            editWin.Show();
        }

        private void F_Path_TextChanged(object sender, TextChangedEventArgs e){}
    }
}