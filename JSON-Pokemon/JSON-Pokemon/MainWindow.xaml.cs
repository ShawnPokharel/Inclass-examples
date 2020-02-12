using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace JSON_Pokemon
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string dataSetUrl = "https://pokeapi.co/api/v2/pokemon?offset=0&limit=1000";

            AllPokemonAPI pokemonInformation;

            using (var client = new HttpClient())
            {
                string json = client.GetStringAsync(dataSetUrl).Result;

                pokemonInformation = JsonConvert.DeserializeObject<AllPokemonAPI>(json);

               // string json = client.DeserializeObject<Pokemon>(json);
            }

            foreach(var character in pokemonInformation.results)
            {
                lstPokemon.Items.Add(character.name);
            }
        }

        public void LstCharacters_SelectionChange(object sender, SelectionChangedEventArgs e)
        {
            var selectedPokemonFromList = (AllPokemonResult) lstPokemon.SelectedItem;

            imgPokemon.Source = new BitmapImage(new Uri(selectedPokemonFromList.image));
        }

        private void BtnPokemon_Click(object sender, RoutedEventArgs e)
        {
           // LstCharacters_SelectionChange(sender, RoutedEventArgs e);
        }
    }
}
