using Microsoft.Win32;
using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for EditData.xaml
    /// </summary>
    public partial class EditData : Window
    {
        public SongData songData;
        private MainWindow mainWindow;
        private OpenFileDialog FileExplorer = new OpenFileDialog();
        public EditData(SongData song, MainWindow Window)
        {
            InitializeComponent();
            songData = song;
            mainWindow = Window;
            SetCurrentData();
        }

        private void SetCurrentData()
        {
            SongF.Text = songData.GetTitle();
            ArtistF.Text = songData.GetArtist();
            AlbumF.Text = songData.GetAlbum();
            DateF.Text = songData.GetYear();
            GenreF.Text = songData.GetGenra();
        }
        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            songData.SetTitle(SongF.Text);
            songData.SetAlbum(AlbumF.Text);
            songData.SetGenra(GenreF.Text);
            songData.SetArtist(ArtistF.Text);
            songData.SetYear(DateF.Text);

            mainWindow.ResetSong(F_Path.Text);

            ChnageMes.Visibility = Visibility.Visible;
            
        }
        private void FBrowser_Click(object sender, RoutedEventArgs e)
        {
            FileExplorer.Filter = "png Files|*.png";

            // Open up the users home directory when opened
            FileExplorer.InitialDirectory = System.Environment.GetEnvironmentVariable("USERPROFILE");
            FileExplorer.ShowDialog();

            if (FileExplorer.CheckFileExists && FileExplorer.CheckPathExists && FileExplorer.FileName != "")
            {
                F_Path.Text = FileExplorer.FileName;

                using (WebClient webClient = new WebClient())
                {
                    // Download the image from the URL as a byte array
                    byte[] imageData = webClient.DownloadData(FileExplorer.FileName);
                    songData.SetImage(imageData);
                }
            }
        }
    }
}
