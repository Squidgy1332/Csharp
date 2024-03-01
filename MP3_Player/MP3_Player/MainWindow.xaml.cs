using Microsoft.Win32;
using NAudio.Wave;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

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
        public SongData songData;
        private bool SongSelected = false;
        public BitmapImage embeddedImage;
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


            if (FileExplorer.CheckFileExists && FileExplorer.CheckPathExists && FileExplorer.FileName != "")
            {
                F_Path.Text = FileExplorer.FileName;
                audioFileReader = new AudioFileReader(FileExplorer.FileName);
                songData = new SongData(FileExplorer.FileName);
                SongSelected = true;
                DisplayCover();
            }
        }

        public void DisplayCover()
        {
            // Convert byte array to Image
            if (songData.GetCover() != null)
            {
                using (MemoryStream ms = new MemoryStream(songData.GetCover()))
                {
                    BitmapImage bitmapImage = new BitmapImage();
                    bitmapImage.BeginInit();
                    bitmapImage.StreamSource = ms;
                    bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                    bitmapImage.EndInit();
                    bitmapImage.Freeze();

                    // Set the image to the Img control
                    Img.Source = bitmapImage;
                }
            }
        }

        public void ResetSong(string ImageFile)
        {
            long SongPos;
            Song.Stop();
            SongPos = audioFileReader.Position;
            audioFileReader.Dispose();
            songData.ChnageData(ImageFile);
            audioFileReader = new AudioFileReader(songData.GetSongURL());
            audioFileReader.Position = SongPos;
            Song.Init(audioFileReader);
            DisplayCover();
            if(isPlaying)
            {
                Song.Play();
            }
        }

        private void PlaySong(object sender, RoutedEventArgs e)
        {
            if(!SongSelected)
            {
                ErrorWindow error = new ErrorWindow();
                error.DisplayError("Can not play no song selected");
                error.Show();
            }
            else
            {
                if (!isPlaying)
                {
                    Song.Init(audioFileReader);
                    PlayB.Content = "Pause";
                    MenuPlay.Header = "Pause";
                    Song.Play();
                    isPlaying = true;
                }
                else
                {
                    if (Song.PlaybackState == PlaybackState.Playing)
                    {
                        PlayB.Content = "Play";
                        MenuPlay.Header = "Play";
                        Song.Pause();
                    }
                    else if (Song.PlaybackState == PlaybackState.Paused)
                    {
                        PlayB.Content = "Pause";
                        MenuPlay.Header = "Pause";
                        Song.Play();
                    }
                }
            }
        }

        private void StopSong(object sender, RoutedEventArgs e)
        {
            if (!SongSelected)
            {
                ErrorWindow error = new ErrorWindow();
                error.DisplayError("Can not stop no song selected");
                error.Show();
            }else
            {
                Song.Stop();
                audioFileReader.Position = 0;
                PlayB.Content = "Play";
                MenuPlay.Header = "Play";
                isPlaying = false;
            }
        }

        private void LunchEditPage(object sender, RoutedEventArgs e)
        {
            if(!SongSelected)
            {
                ErrorWindow error = new ErrorWindow();
                error.DisplayError("Can not edit data no song is selected");
                error.Show();
            }else
            {
                EditData editWin = new EditData(songData, this);
                editWin.Show();
            }
        }

        private void ShowSongData(object sender, RoutedEventArgs e)
        {
            if (!SongSelected)
            {
                ErrorWindow error = new ErrorWindow();
                error.DisplayError("Can not display data no song is selected");
                error.Show();
            }
            else
            {
                DisplaySongData.getSongData(songData);
                DisplaySongData.Visibility = Visibility.Visible;
            }
        }

        private void F_Path_TextChanged(object sender, TextChangedEventArgs e){}
    }
}