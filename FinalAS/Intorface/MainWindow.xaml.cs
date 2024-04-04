using PokemonDB;
using System.Windows;
using System.Windows.Controls;

namespace Intorface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private List<string> pokemons;
        PokemonContext context;
        public MainWindow()
        {
            InitializeComponent();
            context = new PokemonContext();
            pokemons = (from a in context.Pokemon select a.Name).ToList(); 
            PokemonName.ItemsSource = pokemons;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
 
        }
    }
}