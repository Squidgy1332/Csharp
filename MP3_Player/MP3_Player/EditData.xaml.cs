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
using System.Windows.Shapes;

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for EditData.xaml
    /// </summary>
    public partial class EditData : Window
    {
        TagLib.File CurrentFile;
        public EditData(string song)
        {
            InitializeComponent();
            CurrentFile = TagLib.File.Create(song);
        }

        private void ArtistF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SongF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void AlbumF_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void DateF_Changed(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
