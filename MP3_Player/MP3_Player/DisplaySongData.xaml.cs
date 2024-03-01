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

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for SongData.xaml
    /// </summary>
    public partial class DisplaySongData : UserControl
    {
        public DisplaySongData()
        {
            InitializeComponent();
        }

        public void getSongData(SongData Song)
        {
            Title.Content = Song.GetTitle();
            Album.Content = Song.GetAlbum();
            Artist.Content = Song.GetArtist();
            Genre.Content = Song.GetGenra();
            Year.Content = Song.GetYear();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;
        }
    }
}
