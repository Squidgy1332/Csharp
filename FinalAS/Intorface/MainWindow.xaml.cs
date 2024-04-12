﻿using PokemonDB;
using System.Data;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Intorface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private List<string> pokemons;
        private List<String> PokemonAbilitys;
        private List<String> PokemonTypes;
        private List<PokemonTableRow> pokemontable;
        PokemonContext context;
        public MainWindow()
        {
            InitializeComponent();
            
            context = new PokemonContext();
            string[] items = { "Name", "Type", "Ability" };
            pokemontable = new List<PokemonTableRow>();

            foreach (string item in items)
            {
                SearchBox.Items.Add(item);
            }

            SearchBox.SelectedIndex = 0;
            pokemons = (from a in context.Pokemon select a.Name).ToList(); 
            PokemonName.ItemsSource = pokemons;
            PokemonData(false);
            PokemonTable.Visibility = Visibility.Hidden;

            PokemonAbilitys = new List<String>();
            PokemonAbilitys = (from a in context.Abilities select a.Name).ToList();
            Ability1.ItemsSource = PokemonAbilitys;
            PokemonAbilitys.Add("None");
            Ability2.ItemsSource = PokemonAbilitys;
            

            PokemonTypes = new List<String>();
            PokemonTypes = (from a in context.Types select a.Name).ToList();
            Type1.ItemsSource = PokemonTypes;
            PokemonTypes.Add("None");
            Type2.ItemsSource = PokemonTypes;
        }

        private void MakeColumnsType(string type)
        {
            PokemonTable.ItemsSource = null;
            pokemontable.Clear();
            var query = context.Pokemon.Where(p => p.Type1 == type || p.Type2 == type);
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
            SB_L.Content = "Row Count: ";
            PokemonTable.ItemsSource = pokemontable;
        }

        private void MakeColumnsAbility(string ability)
        {
            PokemonTable.ItemsSource = null;
            pokemontable.Clear();
            var query = context.Pokemon.Where(p => p.Ability1 == ability || p.Ability2 == ability);
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
            SB_L.Content = "Row Count: ";
            PokemonTable.ItemsSource = pokemontable;
        }
        
        private void PokemonData(bool state)
        {
            if (state)
            {
                View_R.Visibility = Visibility.Visible;
                Edit_R.Visibility = Visibility.Visible;
                Name_L.Visibility = Visibility.Visible;
                Name.Visibility = Visibility.Visible;
                ID.Visibility = Visibility.Visible;
                ID_L.Visibility = Visibility.Visible;
                Ability1.Visibility = Visibility.Visible;
                Ability2.Visibility = Visibility.Visible;
                A2_L.Visibility = Visibility.Visible;
                A1_L.Visibility = Visibility.Visible;
                Type1.Visibility = Visibility.Visible;
                Type2.Visibility = Visibility.Visible;
                T1_L.Visibility = Visibility.Visible;
                T2_L.Visibility = Visibility.Visible;
                HA.Visibility = Visibility.Visible;
                HA_L.Visibility = Visibility.Visible;
            }
            else
            {
                Save.Visibility = Visibility.Hidden;
                View_R.Visibility = Visibility.Hidden;
                Edit_R.Visibility = Visibility.Hidden;
                Name_L.Visibility = Visibility.Hidden;
                Name.Visibility = Visibility.Hidden;
                ID.Visibility = Visibility.Hidden;
                ID_L.Visibility = Visibility.Hidden;
                Ability1.Visibility = Visibility.Hidden;
                Ability2.Visibility = Visibility.Hidden;
                A2_L.Visibility = Visibility.Hidden;
                A1_L.Visibility = Visibility.Hidden;
                Type1.Visibility = Visibility.Hidden;
                Type2.Visibility = Visibility.Hidden;
                T1_L.Visibility = Visibility.Hidden;
                T2_L.Visibility = Visibility.Hidden;
                HA.Visibility = Visibility.Hidden;
                HA_L.Visibility = Visibility.Hidden;
            }
            
        }
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                if (PokemonName.SelectedItem != null)
                {
                    string selectedItem = PokemonName.SelectedItem.ToString();
                    SB_Data.Text = selectedItem;
                    SB_L.Content = "Pokemon: ";

                    switch (SearchBox.SelectedItem.ToString())
                    {
                        case "Name":
                            PokemonTable.Visibility = Visibility.Hidden;
                            var data = context.Pokemon.Where(p => p.Name == selectedItem);
                            foreach (Pokemon p in data)
                            {
                                PokemonData(true);
                                Name.Text = p.Name;
                                ID.Text = p.Id.ToString();
                                Type1.Text = p.Type1;
                                if (p.Type2 != null)
                                {
                                    Type2.Text = p.Type2;
                                }
                                else
                                {
                                    Type2.Text = "None";
                                }
                                Ability1.Text = p.Ability1;
                                if(p.Ability2 != null)
                                {
                                    Ability2.Text = p.Ability2;
                                }
                                else
                                {
                                    Ability2.Text = "None";
                                }
                                if(p.HiddenAbility != null)
                                {
                                    HA.Text = p.HiddenAbility;
                                }
                                else
                                {
                                    HA.Text = "None";
                                }
                            }
                            break;
                        case "Type":
                            PokemonTable.Visibility = Visibility.Visible;
                            PokemonData(false);
                            MakeColumnsType(selectedItem);
                            break;
                        case "Ability":
                            PokemonTable.Visibility = Visibility.Visible;
                            PokemonData(false);
                            MakeColumnsAbility(selectedItem);
                            break;
                        default:
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (SearchBox.SelectedItem.ToString())
            {
                case "Name":
                    pokemons = (from a in context.Pokemon select a.Name).ToList();
                    PokemonName.ItemsSource = pokemons;
                    break;
                case "Type":
                    pokemons = (from a in context.Types select a.Name).ToList();
                    PokemonName.ItemsSource = pokemons;
                    break;
                case "Ability":
                    pokemons = (from a in context.Abilities select a.Name).ToList();
                    PokemonName.ItemsSource = pokemons;
                    break;
                default:
                    break;
            }
        }

        private void Pokemon_SelectionChanged(object sender, SelectionChangedEventArgs e){}

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PokemonTable NewWin = new PokemonTable();
            NewWin.Show();
        }

        private void Save_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Edit_R_Checked(object sender, RoutedEventArgs e){
            if (Save != null)
            {
                Save.Visibility = Visibility.Visible;
                Name.IsEnabled = true;
                Ability1.IsEnabled = true;
                Ability2.IsEnabled = true;
                Type1.IsEnabled = true;
                Type2.IsEnabled = true;
                HA.IsEnabled = true;
            }

        }

        private void View_R_Checked(object sender, RoutedEventArgs e){
            if(Save != null)
            {
                Save.Visibility = Visibility.Hidden;
                Name.IsEnabled = false;
                Ability1.IsEnabled = false;
                Ability2.IsEnabled = false;
                Type1.IsEnabled = false;
                Type2.IsEnabled = false;
                HA.IsEnabled = false;
            }
        }


        private void Form(object sender, SelectionChangedEventArgs e){}
    }
}