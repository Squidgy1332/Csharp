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

namespace MP3_Player
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        OpenFileDialog FileExplorer = new OpenFileDialog();
        TagLib.File CurrentFile;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void FBrowse_Click(object sender, RoutedEventArgs e)
        {
            FileExplorer.Filter = "mp3 Files|*.mp3";

            // Open up the users home directory when opened
            FileExplorer.InitialDirectory = System.Environment.GetEnvironmentVariable("USERPROFILE");
            FileExplorer.ShowDialog();


            if (FileExplorer.CheckFileExists && FileExplorer.CheckPathExists)
            {
                F_Path.Text = FileExplorer.FileName;
                CurrentFile = TagLib.File.Create(FileExplorer.FileName);
            }
        }
        private void PlayB_Click(object sender, RoutedEventArgs e)
        {
            var Pwindow = new Window1(FileExplorer.FileName);
            var Ewindow = new EditData(FileExplorer.FileName);
            Ewindow.Show();
            Pwindow.Show();
        }

        private void F_Path_TextChanged(object sender, TextChangedEventArgs e){}
    }
}