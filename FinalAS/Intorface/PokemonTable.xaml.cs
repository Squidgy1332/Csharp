using PokemonDB;
using System.Windows;
/**
 * Auther: Liam Morton
 * Date: 2024-04-13
 * File: PokemonTable.cs
 * Purpose: to display all data about each pokemon in the DB
 */
namespace Intorface
{
    /// <summary>
    /// Interaction logic for PokemonTable.xaml
    /// </summary>

    public partial class PokemonTable : Window
    {
        private List<PokemonTableRow> pokemontable;
        PokemonContext context;
        public PokemonTable()
        {
            InitializeComponent();
            MakeTable();
        }

        //fill data grid with pokemon data
        void MakeTable()
        {
            context = new PokemonContext();
            pokemontable = new List<PokemonTableRow>();
            pokemonTable.ItemsSource = null;
            pokemontable.Clear();
            var query = from p in context.Pokemon select p;
            foreach (Pokemon p in query)
            {
                pokemontable.Add(new PokemonTableRow
                {
                    ID = p.Id.ToString(),
                    Name = p.Name,
                    T1 = p.Type1,
                    T2 = p.Type2 ?? "none",
                    A1 = p.Ability1,
                    A2 = p.Ability2 ?? "none",
                    HA = p.HiddenAbility ?? "none"
                });

            }
            SB_Data.Text = pokemontable.Count().ToString();
            pokemonTable.ItemsSource = pokemontable;
        }

        //close window
        private void Back_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
